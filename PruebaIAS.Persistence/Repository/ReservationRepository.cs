using Microsoft.EntityFrameworkCore;
using PruebaIAS.Core.Entities;
using PruebaIAS.Core.Ports;
using PruebaIAS.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIAS.Persistence.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly BookingDbContext _bookingDbContext;

        public ReservationRepository(BookingDbContext bookingDbContext)
        {
            _bookingDbContext = bookingDbContext;
        }
        public async Task CreateReservation(Reservation reservation)
        {
            _bookingDbContext.Reservations.Add(reservation);
            await _bookingDbContext.SaveChangesAsync(); 
        }

        public async Task<Reservation?> GetById(int id)
        {
            var reservation = await _bookingDbContext.Reservations.FirstOrDefaultAsync(r => r.Id ==id);
            return reservation; 
        }

        public async void Update(int Id)
        {
            var reservation = await GetById(Id);

            if (reservation == null)
                return;

        }
    }
}
