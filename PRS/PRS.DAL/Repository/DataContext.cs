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
                var temp = ConfigurationManager.ConnectionStrings["TimeBookingToolConnectionString"];
                if (temp != null)
                {
                    return ConfigurationManager.ConnectionStrings["TimeBookingToolConnectionString"].ConnectionString;
                }
                return "TimeBookingToolConnectionString";
            }
        }
    }
}
