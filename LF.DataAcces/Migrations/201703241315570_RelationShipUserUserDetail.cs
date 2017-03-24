namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipUserUserDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDetail",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.User", "UserDetailId", c => c.Int(nullable: false));
            AlterColumn("dbo.User", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDetail", "Id", "dbo.User");
            DropIndex("dbo.UserDetail", new[] { "Id" });
            AlterColumn("dbo.User", "Email", c => c.String());
            AlterColumn("dbo.User", "UserName", c => c.String());
            DropColumn("dbo.User", "UserDetailId");
            DropTable("dbo.UserDetail");
        }
    }
}
