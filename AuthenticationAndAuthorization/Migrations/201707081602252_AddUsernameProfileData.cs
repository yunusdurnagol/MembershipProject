namespace AuthenticationAndAuthorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsernameProfileData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AnotherField", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AnotherField");
        }
    }
}
