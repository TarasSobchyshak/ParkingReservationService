using PRS.Business.Managers.Interfaces;
using System.Collections.Generic;

namespace PRS.Business.Models
{
    public class ParkingModel : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public OrganizationModel Organization { get; set; }
        public List<ParkingSpotModel> ParkingSpots { get; set; }
    }
}