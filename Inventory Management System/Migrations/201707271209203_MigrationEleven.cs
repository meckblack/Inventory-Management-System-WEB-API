namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationEleven : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Purchase");
        }
        
        public override void Down()
        {
        }
    }
}
