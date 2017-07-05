using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.DAL
{
    public class IMS_DB :DbContext
    {
        public IMS_DB() : base("ims")
        {
            Database.SetInitializer<IMS_DB>(new DBInitializer());
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        

    }
}