using PRS.DAL.Repository.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRS.DAL.Entities
{
    public class Transaction : IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public int ReservationId { get; set; }

        [ForeignKey("ReservationId")]
        public Reservation Reservation { get; set; }

        public decimal Payment { get; set; }
    }
}
