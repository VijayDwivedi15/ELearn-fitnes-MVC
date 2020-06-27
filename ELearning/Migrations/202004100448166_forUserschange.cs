namespace ELearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forUserschange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MobileNumber", c => c.String(maxLength: 10));
            AddColumn("dbo.AspNetUsers", "EmailID", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "EmailConfirmed", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "EmailConfirmed");
            DropColumn("dbo.AspNetUsers", "EmailID");
            DropColumn("dbo.AspNetUsers", "MobileNumber");
        }
    }
}
