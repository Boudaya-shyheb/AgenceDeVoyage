using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AV.ApplicationCore.Domain;

public class Conseiller
{
        [Key]
        public int IdConseiller { get; set; }

        [StringLength(15)]
        public string Nom { get; set; }

        [StringLength(15)]
        public string Prenom { get; set; }
    
        public ICollection<Client> Clients { get; set; }
    }


