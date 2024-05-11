namespace PruebaIAS.Core.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Chair { get; set; }
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public virtual Reservation? Reservation { get; set; } 

    }
}
