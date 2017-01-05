using PRS.Business.Managers.Interfaces;
using System.Collections.Generic;

namespace PRS.Business.Models
{
    public class ParkingSpotModel : IModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public bool IsReserved { get; set; }
        public bool IsFree { get; set; }
        public bool IsActive { get; set; }
        public ParkingModel Parking { get; set; }
        public List<ReservationModel> Reservations { get; set; }
    }
}