namespace AnonseWeb.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserIdColumnToAnnouncement1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Announcements", name: "users_Id", newName: "Id");
            RenameIndex(table: "dbo.Announcements", name: "IX_users_Id", newName: "IX_Id");
            DropColumn("dbo.Announcements", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Announcements", "UserId", c => c.String());
            RenameIndex(table: "dbo.Announcements", name: "IX_Id", newName: "IX_users_Id");
            RenameColumn(table: "dbo.Announcements", name: "Id", newName: "users_Id");
        }
    }
}
