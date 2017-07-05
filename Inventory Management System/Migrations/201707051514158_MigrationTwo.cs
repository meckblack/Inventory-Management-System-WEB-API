namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationTwo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                {
                    CategoryId = c.Int(nullable: false, identity: true),
                    CategoryName = c.String(nullable: false),
                })
                .PrimaryKey(t => t.CategoryId);



        }

        public override void Down()
        {
            DropTable("dbo.Category");
        }
    }
}
