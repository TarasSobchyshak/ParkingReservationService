using PRS.DAL.Repository.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRS.DAL.Entities
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }

        public int ParkingId { get; set; }

        [ForeignKey("ParkingId")]
        public Parking Parking { get; set; }

        public int ParkingSpotId { get; set; }

        [ForeignKey("ParkingSpotId")]
        public ParkingSpot ParkingSpot { get; set; }

        public int TransactionId { get; set; }

        [ForeignKey("TransactionId")]
        public Transaction Transaction { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}