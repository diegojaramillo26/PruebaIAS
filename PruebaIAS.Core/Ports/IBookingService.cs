using PruebaIAS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIAS.Core.Ports
{
    public interface IBookingService
    {
        Task<IEnumerable<Flight>> GetFlightsAsync();
        Task<Reservation> GetReservationAsync(int id);
        Task<Reservation> SaveReservation(Reservation reservation);
    }
}
