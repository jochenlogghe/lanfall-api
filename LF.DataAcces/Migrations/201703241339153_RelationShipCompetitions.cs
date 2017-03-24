namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipCompetitions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        HeaderImageUrl = c.String(),
                        CompetitionTypeId = c.Int(nullable: false),
                        AdminId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.AdminId, cascadeDelete: true)
                .ForeignKey("dbo.CompetitionType", t => t.CompetitionTypeId, cascadeDelete: true)
                .Index(t => t.CompetitionTypeId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.CompetitionType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.User", "Competition_Id", c => c.Int());
            CreateIndex("dbo.User", "Competition_Id");
            AddForeignKey("dbo.User", "Competition_Id", "dbo.Competition", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Competition", "CompetitionTypeId", "dbo.CompetitionType");
            DropForeignKey("dbo.User", "Competition_Id", "dbo.Competition");
            DropForeignKey("dbo.Competition", "AdminId", "dbo.User");
            DropIndex("dbo.Competition", new[] { "AdminId" });
            DropIndex("dbo.Competition", new[] { "CompetitionTypeId" });
            DropIndex("dbo.User", new[] { "Competition_Id" });
            DropColumn("dbo.User", "Competition_Id");
            DropTable("dbo.CompetitionType");
            DropTable("dbo.Competition");
        }
    }
}
