namespace YapiApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnotherPropertyToFoo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Suspended", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "ImagePath", c => c.String());
            AddColumn("dbo.AspNetUsers", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "DeviceID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DeviceID");
            DropColumn("dbo.AspNetUsers", "CreateDate");
            DropColumn("dbo.AspNetUsers", "ImagePath");
            DropColumn("dbo.AspNetUsers", "Suspended");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
