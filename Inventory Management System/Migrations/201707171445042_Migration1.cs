namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, unicode: false),
                        CustomerAddress = c.String(nullable: false, unicode: false),
                        CustomerContact = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FixedAsset",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FixedAssetName = c.String(unicode: false),
                        FixedAssetDate = c.DateTime(nullable: false, precision: 0),
                        FixedAssetAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FixedAssetDepreciation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LocationId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Location", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocationName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(unicode: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockBuyingRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockSellingRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(nullable: false, unicode: false),
                        SupplierContact = c.String(nullable: false, unicode: false),
                        SupplierAddress = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stock", "SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Stock", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Stock", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Product", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.FixedAsset", "LocationId", "dbo.Location");
            DropForeignKey("dbo.FixedAsset", "CategoryId", "dbo.Category");
            DropIndex("dbo.Stock", new[] { "CategoryId" });
            DropIndex("dbo.Stock", new[] { "SupplierId" });
            DropIndex("dbo.Stock", new[] { "ProductId" });
            DropIndex("dbo.Product", new[] { "CategoryId" });
            DropIndex("dbo.FixedAsset", new[] { "CategoryId" });
            DropIndex("dbo.FixedAsset", new[] { "LocationId" });
            DropTable("dbo.Supplier");
            DropTable("dbo.Stock");
            DropTable("dbo.Product");
            DropTable("dbo.Location");
            DropTable("dbo.FixedAsset");
            DropTable("dbo.Customer");
            DropTable("dbo.Category");
        }
    }
}
