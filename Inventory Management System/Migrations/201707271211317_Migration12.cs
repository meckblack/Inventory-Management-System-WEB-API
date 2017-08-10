namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration12 : DbMigration
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
                   ProductId = c.Int(),
               })
               .PrimaryKey(t => t.Id)
               .ForeignKey("dbo.Product", t => t.ProductId)
               .Index(t => t.ProductId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchase", "ProductId", "dbo.Product");
            DropIndex("dbo.Purchase", new[] { "ProductId" });
            DropTable("dbo.Purchase");
        }
    }
}
