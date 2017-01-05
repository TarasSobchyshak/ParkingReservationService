using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using PRS.Components.Constants;
using PRS.Components.Implementations.ConfigurationManager;
using PRS.Components.Implementations.Logger;
using PRS.Components.Implementations.ObjectMapper;
using PRS.Components.Interfaces.ConfigurationManager;
using PRS.Components.Interfaces.Logger;
using PRS.Components.Interfaces.ObjectMapper;

namespace PRS.Business.Infrastructure.CastleWindsor
{
    public class ComponentsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IConfigurationManager>().Named(typeof(IConfigurationManager).FullName).ImplementedBy<ConfigurationManager>().LifeStyle.Transient);

            container.Register(Component.For<IObjectMapper>().Named(typeof(IObjectMapper).FullName).ImplementedBy<ObjectMapper>().LifeStyle.Transient);

            container.Register(Component.For<ILogManager>().ImplementedBy<LogManager>()
                .DependsOn(Dependency.OnAppSettingsValue("loggerName", StringConstants.LogManager)).LifeStyle.Transient);
        }
    }
}
