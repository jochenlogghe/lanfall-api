namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipCompetitionGame : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Game",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Competition", "GameId", c => c.Int());
            CreateIndex("dbo.Competition", "GameId");
            AddForeignKey("dbo.Competition", "GameId", "dbo.Game", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Competition", "GameId", "dbo.Game");
            DropIndex("dbo.Competition", new[] { "GameId" });
            DropColumn("dbo.Competition", "GameId");
            DropTable("dbo.Game");
        }
    }
}
