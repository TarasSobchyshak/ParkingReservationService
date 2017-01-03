using PRS.DAL.Repository.Interfaces;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PRS.DAL.Repository.Implementations
{
    public class ApplicationUnitOfWork : IApplicationUnitOfWork
    {
        private DbContext _context;
        private IRepositoryFactory _repositoryFactory;

        public ApplicationUnitOfWork(IRepositoryFactory repositoryFactory, DbContext context)
        {
            _context = context;
            _repositoryFactory = repositoryFactory;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            //try
            //{
            //    return await _context.SaveChangesAsync();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}",
            //                                    validationError.PropertyName,
            //                                    validationError.ErrorMessage);
            //        }
            //    }
            //}

            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
