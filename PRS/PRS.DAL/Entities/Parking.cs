using PRS.DAL.Repository.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRS.DAL.Entities
{
    public class Parking : IEntity
    {
        public int Id { get; set; }

        [Required, MaxLength(512)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public int OrganizationId { get; set; }

        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }

        public virtual Collection<ParkingSpot> ParkingSpots { get; set; }
    }
}