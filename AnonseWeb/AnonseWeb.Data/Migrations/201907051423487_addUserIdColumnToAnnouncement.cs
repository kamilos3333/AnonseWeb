namespace AnonseWeb.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserIdColumnToAnnouncement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Announcements", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Announcements", "UserId");
        }
    }
}
