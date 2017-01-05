using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using PRS.Business.Managers.Implementations;
using PRS.Business.Managers.Interfaces;

namespace PRS.Business.Infrastructure.CastleWindsor
{
    public class ManagerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IManagerStore>().ImplementedBy<ManagerStore>().LifeStyle.Transient);

        }
    }
}
