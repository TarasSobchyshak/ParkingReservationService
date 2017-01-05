using PRS.Components.Constants;
using System.Configuration;
using System.Data.Entity;

namespace PRS.DAL.Repository
{
    public class DataContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DataContext(string connectionString)
            : base(connectionString)
        {
        }

        public DataContext()
            : this(ConnectionString)
        {
        }

        public static string ConnectionString
        {
            get
            {
                var temp = ConfigurationManager.ConnectionStrings[StringConstants.ConnectionString];
                if (temp != null)
                {
                    return ConfigurationManager.ConnectionStrings[StringConstants.ConnectionString].ConnectionString;
                }

                return string.Empty;
            }
        }
    }
}
