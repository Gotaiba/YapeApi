namespace YapiApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EBSFiledsUpdatedv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "EntityGroup", c => c.Int(nullable: true));
            AddColumn("dbo.AspNetUsers", "RegistrationType", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RegistrationType");
            DropColumn("dbo.AspNetUsers", "EntityGroup");
        }
    }
}
