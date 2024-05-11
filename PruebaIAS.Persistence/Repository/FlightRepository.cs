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
    public class FlightRepository(BookingDbContext dbContext) : IFlightsRepository
    {
        private readonly BookingDbContext _dbContext = dbContext;

        public async Task<IEnumerable<Flight>> GetAll()
        {
            return await _dbContext.Flights.ToListAsync();
        }
    }
}
