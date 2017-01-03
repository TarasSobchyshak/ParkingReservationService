using System.Data.Entity;

namespace PRS.DAL.Repository
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        public override void InitializeDatabase(DataContext context)
        {

            base.InitializeDatabase(context);
        }
    }

}
