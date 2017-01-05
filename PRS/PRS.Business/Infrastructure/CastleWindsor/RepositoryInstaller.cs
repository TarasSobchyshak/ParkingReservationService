using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using PRS.Components.Constants;
using PRS.DAL.Repository;
using PRS.DAL.Repository.Implementations;
using PRS.DAL.Repository.Interfaces;
using System.Data.Entity;

namespace PRS.Business.Infrastructure.CastleWindsor
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IApplicationUnitOfWork>().Named(typeof(IApplicationUnitOfWork).FullName).ImplementedBy<ApplicationUnitOfWork>().LifeStyle.Transient);

            container.Register(Component.For<DbContext>().ImplementedBy<DataContext>()
                .DependsOn(Dependency.OnAppSettingsValue("connectionString", StringConstants.ConnectionString)).LifeStyle.Transient);

        }
    }
}
