namespace YapiApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EBSFileds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PAN", c => c.String());
            AddColumn("dbo.AspNetUsers", "iPIN", c => c.String());
            AddColumn("dbo.AspNetUsers", "expDate", c => c.String());
            AddColumn("dbo.AspNetUsers", "mbr", c => c.String());
            AddColumn("dbo.AspNetUsers", "EntityType", c => c.String());
            AddColumn("dbo.AspNetUsers", "EntityId", c => c.String());
            AddColumn("dbo.AspNetUsers", "EntityGroup", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "RegistrationType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RegistrationType");
            DropColumn("dbo.AspNetUsers", "EntityGroup");
            DropColumn("dbo.AspNetUsers", "EntityId");
            DropColumn("dbo.AspNetUsers", "EntityType");
            DropColumn("dbo.AspNetUsers", "mbr");
            DropColumn("dbo.AspNetUsers", "expDate");
            DropColumn("dbo.AspNetUsers", "iPIN");
            DropColumn("dbo.AspNetUsers", "PAN");
        }
    }
}
