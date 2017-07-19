namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationTwo : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.FixedAsset");
        }
        
        public override void Down()
        {
            DropTable("dbo.FixedAsset");
        }
    }
}
