﻿using PRS.DAL.Repository.Interfaces;
using System;
using System.Data.Entity;

namespace PRS.DAL.Repository.Implementations
{
    public abstract class Repository : IRepository
    {
        #region Properties
        public DbContext Context { get; set; }
        #endregion


        #region Constructors
        protected Repository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", "context");
            }

            Context = context;
        }
        #endregion


        #region Interface Members
        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
                Context = null;
            }
        }
        #endregion
    }
}
