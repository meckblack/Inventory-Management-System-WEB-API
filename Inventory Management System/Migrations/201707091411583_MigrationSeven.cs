namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationSeven : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FixedAsset",
                c => new
                    {
                        FixedAssetId = c.Int(nullable: false, identity: true),
                        FixedAssetName = c.String(unicode: false),
                        FixedAssetDate = c.DateTime(nullable: false, precision: 0),
                        FixedAssetAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FixedAssetDepreciation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LocationId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FixedAssetId)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Location", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FixedAsset", "LocationId", "dbo.Location");
            DropForeignKey("dbo.FixedAsset", "CategoryId", "dbo.Category");
            DropIndex("dbo.FixedAsset", new[] { "CategoryId" });
            DropIndex("dbo.FixedAsset", new[] { "LocationId" });
            DropTable("dbo.FixedAsset");
        }
    }
}
