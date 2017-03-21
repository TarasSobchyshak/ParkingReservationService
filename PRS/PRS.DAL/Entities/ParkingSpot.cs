using PRS.DAL.Repository.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRS.DAL.Entities
{
    public class ParkingSpot : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public bool IsReserved { get; set; }

        [Required]
        public bool IsFree { get; set; }

        public bool IsActive { get; set; }

        public int ParkingId { get; set; }

        [ForeignKey("ParkingId")]
        public Parking Parking { get; set; }

        public virtual Collection<Reservation> Reservations { get; set; }
    }
}