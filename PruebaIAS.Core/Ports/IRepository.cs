using PruebaIAS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIAS.Core.Ports
{
    public interface IReservationRepository
    {
        Task<Reservation?> GetById(int id);
        void Update(int Id);
        Task CreateReservation( Reservation reservation);
    }

    public interface IFlightsRepository
    {
        Task<IEnumerable<Flight>> GetAll();

    }

}
