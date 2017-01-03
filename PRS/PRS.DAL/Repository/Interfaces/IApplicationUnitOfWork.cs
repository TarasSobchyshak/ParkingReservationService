using System;
using System.Threading.Tasks;

namespace PRS.DAL.Repository.Interfaces
{
    public interface IApplicationUnitOfWork : IDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
