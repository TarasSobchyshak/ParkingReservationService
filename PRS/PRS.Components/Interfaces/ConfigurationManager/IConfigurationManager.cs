using System.Configuration;

namespace PRS.Components.Interfaces.ConfigurationManager
{
    public interface IConfigurationManager
    {
        T Get<T>(string key);
        ConnectionStringSettingsCollection ConnectionStrings { get; }
    }
}
