using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using PRS.Business.Providers.Implementations;
using PRS.Business.Providers.Interfaces;

namespace PRS.Business.Infrastructure.CastleWindsor
{
    public class ProvidersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IConfigurationProvider>().ImplementedBy<ConfigurationProvider>().LifeStyle.Transient);
        }
    }
}
