using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIAS.Core.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }

        [MaxLength(100)]
        public string Observation { get; set; } = string.Empty;

        public int FlightId { get; set; }

        public int UserId { get; set; }

        public Reservation? ReservationStatus { get; set; }

        public virtual Flight? Flight { get; set; }

        public virtual User? User { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }

    public enum ReservationStatus
    {
        Active,
        Canceled,
    }
}
