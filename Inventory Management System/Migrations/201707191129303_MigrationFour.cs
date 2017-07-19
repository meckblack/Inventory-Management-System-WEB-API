namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationFour : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ProductPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "Description", c => c.String(unicode: false));
            AddColumn("dbo.Product", "ProductDate", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.Product", "ProductModel", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ProductModel");
            DropColumn("dbo.Product", "ProductDate");
            DropColumn("dbo.Product", "Description");
            DropColumn("dbo.Product", "ProductPrice");
        }
    }
}
