using PRS.Components.Constants;
using PRS.DAL.Entities;
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

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
