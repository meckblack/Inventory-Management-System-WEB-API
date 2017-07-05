using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Inventory_Management_System.DAL;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        

    }
}