using PRS.DAL.Repository.Interfaces;
using System;

namespace PRS.DAL.Entities
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public int ParkingId { get; set; }
        public int ParkingSpotId { get; set; }
        public int TransactionId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}