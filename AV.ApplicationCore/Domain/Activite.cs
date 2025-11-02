using System.ComponentModel.DataAnnotations;

namespace AV.ApplicationCore.Domain;

public class Activite
{
    
    [Key]
    public int ActiviteId { get; set; }
    
    public String ville { get; set; }
    
    public String pays { get; set; }
    
    public double prix { get; set; }
    
    public String TypeService { get; set; }
    
    public ICollection<Pack> Packs { get; set; }
    
}