using PRS.Business.Factories.Interfaces;
using PRS.Business.Managers.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace PRS.Business.Managers.Implementations
{
    public class ManagerStore : IManagerStore
    {
        #region Fields
        private IManagerFactory _managerFactory;

        #endregion


        #region Properties

        #endregion


        #region Constructors
        public ManagerStore(IManagerFactory managerFactory)
        {
            _managerFactory = managerFactory;
        }
        #endregion


        #region Interface Members
        public void Dispose()
        {
            foreach (var field in GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(m => m.FieldType != typeof(IManagerFactory)))
            {
                var value = field.GetValue(this) as IDisposable;

                if (value != null)
                {
                    value.Dispose();
                    field.SetValue(this, null);
                }
            }
        }
        #endregion
    }
}
