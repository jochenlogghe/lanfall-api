namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserDetailAttributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserDetail", "FirstName", c => c.String());
            AddColumn("dbo.UserDetail", "LastName", c => c.String());
            AddColumn("dbo.UserDetail", "Street", c => c.String());
            AddColumn("dbo.UserDetail", "ZipCode", c => c.String());
            AddColumn("dbo.UserDetail", "City", c => c.String());
            AddColumn("dbo.UserDetail", "LicensePlate", c => c.String());
            AddColumn("dbo.UserDetail", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserDetail", "PhoneNumber");
            DropColumn("dbo.UserDetail", "LicensePlate");
            DropColumn("dbo.UserDetail", "City");
            DropColumn("dbo.UserDetail", "ZipCode");
            DropColumn("dbo.UserDetail", "Street");
            DropColumn("dbo.UserDetail", "LastName");
            DropColumn("dbo.UserDetail", "FirstName");
        }
    }
}
