using System.Data.Entity;

namespace PRS.DAL.Repository.Interfaces
{
    public interface IRepository
    {
        DbContext Context { get; set; }
    }
}
