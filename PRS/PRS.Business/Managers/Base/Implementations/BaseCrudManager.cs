﻿using PRS.Business.Providers.Interfaces;
using PRS.Components.Interfaces.ObjectMapper;
using PRS.DAL.Repository.Interfaces;
using System;

namespace PRS.Business.Managers.Implementations
{
    public abstract class BaseCrudManager<TEntity> : BaseManager, IDisposable
        where TEntity : class, IEntity
    {
        #region Fields
        private readonly IRepository<TEntity> repository;
        #endregion


        #region Properties
        protected IRepository<TEntity> Repository
        {
            get { return repository; }
        }
        #endregion


        #region Constructors
        protected BaseCrudManager(
            IApplicationUnitOfWork unitOfWork,
            IRepository<TEntity> repository,
            IObjectMapper objectMapper,
            IConfigurationProvider configurationProvider)
            : base(unitOfWork, objectMapper, configurationProvider)
        {
            this.repository = repository;
        }
        #endregion


        #region Interface Members
        public override void Dispose()
        {
            base.Dispose();
        }
        #endregion
    }
}
