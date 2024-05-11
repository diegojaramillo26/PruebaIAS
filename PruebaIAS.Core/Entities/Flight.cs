using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIAS.Core.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Origin { get; set; } = string.Empty;
        [MaxLength(30)]
        public string Destination { get; set; } = string.Empty;
        public DateTime FlightDate { get; set; }
        [MaxLength(30)]
        public string AirLine { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Description { get; set; } = string.Empty;

        public ICollection<Reservation> reservations { get; set; } = new List<Reservation>();


    }
}
