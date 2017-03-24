namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipEditionCompetition : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Edition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Name = c.String(),
                        NumberOfParticipants = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Competition", "EditionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Competition", "EditionId");
            AddForeignKey("dbo.Competition", "EditionId", "dbo.Edition", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Competition", "EditionId", "dbo.Edition");
            DropIndex("dbo.Competition", new[] { "EditionId" });
            DropColumn("dbo.Competition", "EditionId");
            DropTable("dbo.Edition");
        }
    }
}
