namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelRefinement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clan", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Competition", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.CompetitionAdmin", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Role", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Seat", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.SeatType", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserDetail", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.CompetitionType", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Edition", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Game", "ModifiedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clan", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Competition", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Competition", "ShortDescription", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Competition", "LongDescription", c => c.String(maxLength: 2000));
            AlterColumn("dbo.Role", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.SeatType", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.UserDetail", "FirstName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.UserDetail", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.UserDetail", "ZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.UserDetail", "City", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.UserDetail", "LicensePlate", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.CompetitionType", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Edition", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Game", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Game", "Name", c => c.String());
            AlterColumn("dbo.Edition", "Name", c => c.String());
            AlterColumn("dbo.CompetitionType", "Name", c => c.String());
            AlterColumn("dbo.UserDetail", "LicensePlate", c => c.String());
            AlterColumn("dbo.UserDetail", "City", c => c.String());
            AlterColumn("dbo.UserDetail", "ZipCode", c => c.String());
            AlterColumn("dbo.UserDetail", "LastName", c => c.String());
            AlterColumn("dbo.UserDetail", "FirstName", c => c.String());
            AlterColumn("dbo.SeatType", "Name", c => c.String());
            AlterColumn("dbo.Role", "Name", c => c.String());
            AlterColumn("dbo.Competition", "LongDescription", c => c.String());
            AlterColumn("dbo.Competition", "ShortDescription", c => c.String());
            AlterColumn("dbo.Competition", "Name", c => c.String());
            AlterColumn("dbo.Clan", "Name", c => c.String());
            DropColumn("dbo.Game", "ModifiedOn");
            DropColumn("dbo.Edition", "ModifiedOn");
            DropColumn("dbo.CompetitionType", "ModifiedOn");
            DropColumn("dbo.UserDetail", "ModifiedOn");
            DropColumn("dbo.SeatType", "ModifiedOn");
            DropColumn("dbo.Seat", "ModifiedOn");
            DropColumn("dbo.Role", "ModifiedOn");
            DropColumn("dbo.User", "ModifiedOn");
            DropColumn("dbo.CompetitionAdmin", "ModifiedOn");
            DropColumn("dbo.Competition", "ModifiedOn");
            DropColumn("dbo.Clan", "ModifiedOn");
        }
    }
}
