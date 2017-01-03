using System.ComponentModel.DataAnnotations;

namespace PRS.DAL.Repository.Interfaces
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
    }
}
