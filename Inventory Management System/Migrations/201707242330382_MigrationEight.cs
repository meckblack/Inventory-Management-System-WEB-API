namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationEight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supplier", "Name", c => c.String(unicode: false));
            AddColumn("dbo.Supplier", "Address", c => c.String(unicode: false));
            AddColumn("dbo.Supplier", "Contact", c => c.String(unicode: false));
            DropColumn("dbo.Supplier", "SupplierName");
            DropColumn("dbo.Supplier", "SupplierContact");
            DropColumn("dbo.Supplier", "SupplierAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supplier", "SupplierAddress", c => c.String(nullable: false, unicode: false));
            AddColumn("dbo.Supplier", "SupplierContact", c => c.String(nullable: false, unicode: false));
            AddColumn("dbo.Supplier", "SupplierName", c => c.String(nullable: false, unicode: false));
            DropColumn("dbo.Supplier", "Contact");
            DropColumn("dbo.Supplier", "Address");
            DropColumn("dbo.Supplier", "Name");
        }
    }
}
