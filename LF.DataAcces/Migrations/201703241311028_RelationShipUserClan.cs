namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipUserClan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        UserName = c.String(),
                        Email = c.String(),
                        FounderOfClanId = c.Int(),
                        ClanId = c.Int(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clan", t => t.Id)
                .ForeignKey("dbo.Clan", t => t.ClanId)
                .Index(t => t.Id)
                .Index(t => t.ClanId);
            
            AddColumn("dbo.Clan", "FounderId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "ClanId", "dbo.Clan");
            DropForeignKey("dbo.User", "Id", "dbo.Clan");
            DropIndex("dbo.User", new[] { "ClanId" });
            DropIndex("dbo.User", new[] { "Id" });
            DropColumn("dbo.Clan", "FounderId");
            DropTable("dbo.User");
        }
    }
}
