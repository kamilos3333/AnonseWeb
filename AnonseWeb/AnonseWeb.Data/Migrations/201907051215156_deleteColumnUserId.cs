namespace AnonseWeb.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteColumnUserId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Announcements", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Announcements", "UserId", c => c.Int(nullable: false));
        }
    }
}
