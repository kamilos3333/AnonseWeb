namespace AnonseWeb.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editDataTypeCity2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "log", c => c.Double(nullable: false));
            AlterColumn("dbo.Cities", "lon", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "lon", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Cities", "log", c => c.String());
        }
    }
}
