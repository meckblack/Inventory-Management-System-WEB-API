namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationNine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "Name", c => c.String(nullable: false, unicode: false));
            DropColumn("dbo.Category", "CategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "CategoryName", c => c.String(nullable: false, unicode: false));
            DropColumn("dbo.Category", "Name");
        }
    }
}
