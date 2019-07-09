namespace AnonseWeb.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCostToAnnoucement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Announcements", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Announcements", "Cost");
        }
    }
}
