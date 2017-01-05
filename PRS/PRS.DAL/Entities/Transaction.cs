using PRS.DAL.Repository.Interfaces;

namespace PRS.DAL.Entities
{
    public class Transaction : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReservationId { get; set; }
        public decimal Payment { get; set; }
    }
}
