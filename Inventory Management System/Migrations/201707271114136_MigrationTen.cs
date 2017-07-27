namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationTen : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Purchase",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Quantity = c.Int(nullable: false),
                    Date = c.DateTime(nullable: false, precision: 0),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    ProductId_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId_Id)
                .Index(t => t.ProductId_Id);
            
            AddColumn("dbo.Customer", "Name", c => c.String(unicode: false));
            AddColumn("dbo.Customer", "Address", c => c.String(unicode: false));
            AddColumn("dbo.Customer", "Contact", c => c.String(unicode: false));
            AlterColumn("dbo.Category", "Name", c => c.String(unicode: false));
            DropColumn("dbo.Customer", "CustomerName");
            DropColumn("dbo.Customer", "CustomerAddress");
            DropColumn("dbo.Customer", "CustomerContact");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customer", "CustomerContact", c => c.String(nullable: false, unicode: false));
            AddColumn("dbo.Customer", "CustomerAddress", c => c.String(nullable: false, unicode: false));
            AddColumn("dbo.Customer", "CustomerName", c => c.String(nullable: false, unicode: false));
            DropForeignKey("dbo.Purchase", "ProductId_Id", "dbo.Product");
            DropIndex("dbo.Purchase", new[] { "PurchaseProduct_Id" });
            DropIndex("dbo.Purchase", new[] { "ProductId_Id" });
            AlterColumn("dbo.Category", "Name", c => c.String(nullable: false, unicode: false));
            DropColumn("dbo.Customer", "Contact");
            DropColumn("dbo.Customer", "Address");
            DropColumn("dbo.Customer", "Name");
            DropTable("dbo.Purchase");
        }
    }
}
