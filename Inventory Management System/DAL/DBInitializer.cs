using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
