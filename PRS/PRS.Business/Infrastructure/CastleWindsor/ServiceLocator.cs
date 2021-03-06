﻿using Castle.Windsor;

namespace PRS.Business.Infrastructure.CastleWindsor
{
    public class ServiceLocator
    {
        private static ServiceLocator instance;
        private IWindsorContainer _serviceContainer;

        private ServiceLocator()
        { }

        public static ServiceLocator Current
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServiceLocator();
                }

                return instance;
            }
        }

        public void SetLocatorProvider(IWindsorContainer container)
        {
            _serviceContainer = container;
        }

        public T Get<T>()
        {
            return _serviceContainer.Resolve<T>();
        }
    }
}
