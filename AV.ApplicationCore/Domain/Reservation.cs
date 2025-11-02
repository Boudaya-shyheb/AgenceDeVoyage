using System;
using System.ComponentModel.DataAnnotations;

namespace AV.ApplicationCore.Domain;

public class Reservation
{
    
    [Required]
        [DataType(DataType.Date)]
        public DateTime DateReservation { get; set; }

        [Range(1, 4)]
        public int NbPersonnes { get; set; }
        
        public int ClientFK { get; set; }
        public virtual Client Client { get; set; }

        public int PackFK { get; set; }
        public virtual Pack Pack { get; set; }
    }


