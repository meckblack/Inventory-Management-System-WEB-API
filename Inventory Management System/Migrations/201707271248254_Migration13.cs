namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration13 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Purchase");
        }
        
        public override void Down()
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
                        PurchaseProduct_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Purchase", "PurchaseProduct_Id");
            CreateIndex("dbo.Purchase", "ProductId_Id");
            AddForeignKey("dbo.Purchase", "PurchaseProduct_Id", "dbo.Product", "Id");
            AddForeignKey("dbo.Purchase", "ProductId_Id", "dbo.Product", "Id");
        }
    }
}
