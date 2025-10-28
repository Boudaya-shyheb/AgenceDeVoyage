using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AV.ApplicationCore.Domain;


public class Pack
{

        [Key]
        public int IdPack { get; set; }

        [StringLength(15)]
        public string Destination { get; set; }

        public int Duree { get; set; }

        public int NbPlaces { get; set; }
        
        public ICollection<Reservation> Reservations { get; set; }
    }


