﻿using AutoMapper;
using Castle.Windsor;
using PRS.Business.Infrastructure.CastleWindsor;
using PRS.WebApi.Common.CastleWindsor.Infrastructure;
using PRS.WebApi.Common.CastleWindsor.Installers;
using System;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;

namespace PRS.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        private readonly IWindsorContainer container;

        public WebApiApplication()
        {
            container = new WindsorContainer();
            container.Install(
                new ControllerInstaller(),
                new ComponentsInstaller(),
                new ProvidersInstaller(),
                new FactoriesInstaller(),
                new ManagerInstaller(),
                new RepositoryInstaller());

            ServiceLocator.Current.SetLocatorProvider(container);
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.Services
                .Replace(typeof(IHttpControllerActivator),
                         new WindsorCompositionRoot(container));

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            InitializeAutoMapper();
        }

        private void InitializeAutoMapper()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("PRS")))
            {
                foreach (var profile in assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Profile))))
                {
                    Mapper.AddProfile((Profile)Activator.CreateInstance(profile, null));
                }
            }
        }

        public override void Dispose()
        {
            container.Dispose();
            base.Dispose();
        }
    }
}
