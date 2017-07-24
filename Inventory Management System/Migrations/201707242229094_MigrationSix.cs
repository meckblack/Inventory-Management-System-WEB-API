namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationSix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Name", c => c.String(unicode: false));
            AddColumn("dbo.Product", "Description", c => c.String(unicode: false));
            AddColumn("dbo.Product", "Date", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Product", "ProductName");
            DropColumn("dbo.Product", "ProductPrice");
            DropColumn("dbo.Product", "ProductDescription");
            DropColumn("dbo.Product", "ProductDate");
            DropColumn("dbo.Product", "ProductModel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "ProductModel", c => c.String(unicode: false));
            AddColumn("dbo.Product", "ProductDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.Product", "ProductDescription", c => c.String(unicode: false));
            AddColumn("dbo.Product", "ProductPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "ProductName", c => c.String(unicode: false));
            DropColumn("dbo.Product", "Date");
            DropColumn("dbo.Product", "Description");
            DropColumn("dbo.Product", "Name");
        }
    }
}
