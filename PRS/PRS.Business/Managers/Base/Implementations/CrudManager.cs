using PRS.Business.Managers.Implementations;
using PRS.Business.Managers.Interfaces;
using PRS.Business.Providers.Interfaces;
using PRS.Components.Interfaces.ObjectMapper;
using PRS.DAL.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRS.Business.Managers.Base.Implementations
{
    public abstract class CrudManager<TEntity, TModel> : BaseCrudManager<TEntity>, ICrudManager<TModel>
           where TModel : class, IModel
           where TEntity : class, IEntity
    {
        protected CrudManager(
            IApplicationUnitOfWork unitOfWork,
            IRepository<TEntity> repository,
            IObjectMapper objectMapper,
            IConfigurationProvider configurationProvider)
            : base(unitOfWork, repository, objectMapper, configurationProvider)
        { }

        public virtual async Task<List<TModel>> GetAsync()
        {
            return ObjectMapper.Map<IQueryable<TEntity>, List<TModel>>(
                await Repository.GetAsync());
        }

        public virtual async Task<TModel> GetAsync(int id)
        {
            return ObjectMapper.Map<TEntity, TModel>(
                await Repository.GetAsync(id));
        }

        public virtual async Task<int> AddAsync(TModel model)
        {
            var dBModel = ObjectMapper.Map<TModel, TEntity>(model);

            await Repository.AddAsync(dBModel);

            await UnitOfWork.SaveChangesAsync();

            return dBModel.Id;
        }

        public virtual async Task UpdateAsync(TModel model)
        {
            await Repository.DetachAsync(
                await Repository.GetAsync(model.Id));

            await Repository.UpdateAsync(
                ObjectMapper.Map<TModel, TEntity>(model));

            await UnitOfWork.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(TModel model)
        {
            await Repository.DeleteAsync(
                ObjectMapper.Map<TModel, TEntity>(model));

            await UnitOfWork.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int id)
        {
            await Repository.DeleteAsync(id);

            await UnitOfWork.SaveChangesAsync();
        }

        public virtual async Task BulkInsertAsync(IEnumerable<TModel> entities)
        {
            await Repository.BulkInsertAsync(
                ObjectMapper.Map<IEnumerable<TModel>, IEnumerable<TEntity>>(entities));

            await UnitOfWork.SaveChangesAsync();
        }
    }

}
