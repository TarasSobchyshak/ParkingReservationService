using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using PRS.Business.Factories.Interfaces;
using PRS.Business.Infrastructure.CastleWindsor.ComponentSelector;
using PRS.DAL.Repository.Interfaces;

namespace PRS.Business.Infrastructure.CastleWindsor
{
    public class FactoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<TypedFactoryFacility>();
            container.Register(Component.For<IManagerFactory>().AsFactory(c => c.SelectedWith(new FactoryComponentSelector())).LifeStyle.Transient);
            container.Register(Component.For<IRepositoryFactory>().AsFactory(r => r.SelectedWith(new FactoryComponentSelector())).LifeStyle.Transient);
        }
    }
}
