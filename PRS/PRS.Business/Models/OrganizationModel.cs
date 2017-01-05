using PRS.Business.Managers.Interfaces;
using System.Collections.Generic;

namespace PRS.Business.Models
{
    public class OrganizationModel : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<ParkingModel> Parkings { get; set; }
    }
}
