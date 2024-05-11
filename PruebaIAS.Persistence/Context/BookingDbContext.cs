using Microsoft.EntityFrameworkCore;
using PruebaIAS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIAS.Persistence.Context
{
    public class BookingDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users {  get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Flight>().HasMany(r => r.reservations).WithOne(f => f.Flight).HasForeignKey(e => e.FlightId);

        }
    }


}
