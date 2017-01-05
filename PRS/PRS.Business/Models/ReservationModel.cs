using PRS.Business.Managers.Interfaces;
using System;

namespace PRS.Business.Models
{
    public class ReservationModel : IModel
    {
        public int Id { get; set; }
        public ParkingModel Parking { get; set; }
        public ParkingSpotModel ParkingSpot { get; set; }
        public TransactionModel Transaction { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}