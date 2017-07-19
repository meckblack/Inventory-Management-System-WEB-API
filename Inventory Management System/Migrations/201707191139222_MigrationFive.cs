namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationFive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ProductDescription", c => c.String(unicode: false));
            DropColumn("dbo.Product", "Description");
            DropTable("dbo.Location");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocationName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Product", "Description", c => c.String(unicode: false));
            DropColumn("dbo.Product", "ProductDescription");
        }
    }
}
