namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrationone : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Category");
        }
        
        public override void Down()
        {
        }
    }
}
