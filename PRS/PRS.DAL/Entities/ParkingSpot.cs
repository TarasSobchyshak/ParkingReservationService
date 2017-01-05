using PRS.DAL.Repository.Interfaces;
using System.Collections.ObjectModel;

namespace PRS.DAL.Entities
{
    public class ParkingSpot : IEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public bool IsReserved { get; set; }
        public bool IsFree { get; set; }
        public bool IsActive { get; set; }
        public int ParkingId { get; set; }
        public virtual Collection<Reservation> Reservations { get; set; }
    }
}