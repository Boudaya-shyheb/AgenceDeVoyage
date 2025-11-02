using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AV.ApplicationCore.Domain;


public class Pack
{

        [Key]
        public int PackId { get; set; }

        public DateTime DateDeb { get; set; }

        public int Duree { get; set; }

        public int NbPlaces { get; set; }
        
        public String IntitulePack { get; set; }
        
        public virtual ICollection<Reservation> Reservations { get; set; }
    }


