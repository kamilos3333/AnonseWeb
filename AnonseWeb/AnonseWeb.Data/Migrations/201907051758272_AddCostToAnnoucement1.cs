namespace AnonseWeb.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCostToAnnoucement1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Announcements", "Cost", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Announcements", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
