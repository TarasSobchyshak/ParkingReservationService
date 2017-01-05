using PRS.DAL.Repository.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRS.DAL.Entities
{
    public class Organization : IEntity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(512)]
        [Index("IX_Organization_Name", IsUnique = true)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Parking> Parkings { get; set; }
    }
}
