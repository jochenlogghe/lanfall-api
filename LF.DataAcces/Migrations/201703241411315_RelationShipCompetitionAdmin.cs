namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipCompetitionAdmin : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Competition", "AdminId", "dbo.User");
            DropForeignKey("dbo.User", "Competition_Id", "dbo.Competition");
            DropIndex("dbo.Competition", new[] { "AdminId" });
            DropIndex("dbo.User", new[] { "Competition_Id" });
            CreateTable(
                "dbo.CompetitionAdmin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsMain = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .ForeignKey("dbo.Competition", t => t.CompetitionId)
                .Index(t => t.UserId)
                .Index(t => t.CompetitionId);
            
            DropColumn("dbo.Competition", "AdminId");
            DropColumn("dbo.User", "Competition_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Competition_Id", c => c.Int());
            AddColumn("dbo.Competition", "AdminId", c => c.Int(nullable: false));
            DropForeignKey("dbo.CompetitionAdmin", "CompetitionId", "dbo.Competition");
            DropForeignKey("dbo.CompetitionAdmin", "UserId", "dbo.User");
            DropIndex("dbo.CompetitionAdmin", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionAdmin", new[] { "UserId" });
            DropTable("dbo.CompetitionAdmin");
            CreateIndex("dbo.User", "Competition_Id");
            CreateIndex("dbo.Competition", "AdminId");
            AddForeignKey("dbo.User", "Competition_Id", "dbo.Competition", "Id");
            AddForeignKey("dbo.Competition", "AdminId", "dbo.User", "Id");
        }
    }
}
