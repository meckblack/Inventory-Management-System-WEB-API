using System.Data.Entity;

namespace Inventory_Management_System.DAL
{
    class DBInitializer : CreateDatabaseIfNotExists<IMS_DB>
    {
        protected override void Seed(IMS_DB context)
        {
            base.Seed(context);  
        }
    }
}
