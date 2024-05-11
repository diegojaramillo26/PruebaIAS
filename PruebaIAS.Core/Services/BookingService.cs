using PruebaIAS.Core.Entities;
using PruebaIAS.Core.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIAS.Core.Services
{
    public class BookingService : IBookingService
    {
        private readonly IFlightsRepository _flightsRepository;
        public BookingService(IFlightsRepository flightsRepository)
        {
            _flightsRepository = flightsRepository;
        }
        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            return await _flightsRepository.GetAll();
        }

        public Task<Reservation> GetReservationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> SaveReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
