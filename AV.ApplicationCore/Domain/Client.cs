using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AV.ApplicationCore.Domain;

public class Client
{
    
        [Key]
        public int Identifiant { get; set; }

        [Required, ]
        public string Login { get; set; }

        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
        [DataType(DataType.Password)]
        [StringLength(15)]
        public string Password { get; set; }
        
        public string Photo { get; set; }
        
        public virtual ICollection<Reservation> Reservations { get; set; }
        
        public int ConseillerFK { get; set; }
        public Conseiller Conseiller { get; set; }
    
}

