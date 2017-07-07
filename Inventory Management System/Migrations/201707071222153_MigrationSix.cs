namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationSix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        StockBuyingRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockSellingRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockId)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stock", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Stock", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Stock", "CategoryId", "dbo.Category");
            DropIndex("dbo.Stock", new[] { "CategoryId" });
            DropIndex("dbo.Stock", new[] { "SupplierId" });
            DropIndex("dbo.Stock", new[] { "ProductId" });
            DropTable("dbo.Stock");
        }
    }
}
