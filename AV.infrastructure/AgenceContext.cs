using AV.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;


namespace AV.infrastructure;

public class AgenceContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Pack> Packs { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Conseiller> Conseillers { get; set; }
    public DbSet<Activite> Activites { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                              Initial Catalog=AgenceDB;
                              Integrated Security=True;
                              MultipleActiveResultSets=True");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>()
            .HasOne(c => c.Conseiller)
            .WithMany(co => co.Clients)
            .HasForeignKey(c => c.ConseillerFK)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Pack)
            .WithMany(p => p.Reservations)
            .HasForeignKey(r => r.PackFK);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Client)
            .WithMany(c => c.Reservations)
            .HasForeignKey(r => r.ClientFK);

        modelBuilder.Entity<Reservation>()
            .HasKey(r => new { r.ClientFK, r.PackFK }); 
        
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entity.GetProperties())
            {
                if (property.ClrType == typeof(string))
                    property.SetMaxLength(15);
            }
        }
    }
    
}