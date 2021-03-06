﻿using System;
using PRS.Components.Interfaces.ConfigurationManager;

namespace PRS.Components.Implementations.ConfigurationManager
{
    public class ConfigurationManager : IConfigurationManager
    {
        public T Get<T>(string key)
        {
            var value = System.Configuration.ConfigurationManager.AppSettings[key];

            if (value == null)
            {
                return default(T);
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public System.Configuration.ConnectionStringSettingsCollection ConnectionStrings
        {
            get { return System.Configuration.ConfigurationManager.ConnectionStrings; }
        }
    }
}
