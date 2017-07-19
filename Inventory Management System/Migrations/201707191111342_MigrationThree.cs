namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationThree : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stock", "StockQuantity", c => c.Int(nullable: false));
            DropColumn("dbo.Stock", "StockBuyingRate");
            DropColumn("dbo.Stock", "StockSellingRate");
            
        }
        
        public override void Down()
        {
            
            AddColumn("dbo.Stock", "StockSellingRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Stock", "StockBuyingRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Stock", "StockQuantity");
            
        }
    }
}
