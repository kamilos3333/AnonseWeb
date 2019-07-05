namespace AnonseWeb.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editNameColumnInCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "lat", c => c.Double(nullable: false));
            DropColumn("dbo.Cities", "log");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "log", c => c.Double(nullable: false));
            DropColumn("dbo.Cities", "lat");
        }
    }
}
