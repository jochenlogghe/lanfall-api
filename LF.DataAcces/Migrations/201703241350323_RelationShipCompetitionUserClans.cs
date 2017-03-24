namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipCompetitionUserClans : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRole", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Seat", "SeatTypeId", "dbo.SeatType");
            DropForeignKey("dbo.Competition", "AdminId", "dbo.User");
            DropForeignKey("dbo.Competition", "CompetitionTypeId", "dbo.CompetitionType");
            CreateTable(
                "dbo.CompetitionClan",
                c => new
                    {
                        CompetitionId = c.Int(nullable: false),
                        ClanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CompetitionId, t.ClanId })
                .ForeignKey("dbo.Competition", t => t.CompetitionId)
                .ForeignKey("dbo.Clan", t => t.ClanId)
                .Index(t => t.CompetitionId)
                .Index(t => t.ClanId);
            
            CreateTable(
                "dbo.CompetitionUser",
                c => new
                    {
                        CompetitionId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CompetitionId, t.UserId })
                .ForeignKey("dbo.Competition", t => t.CompetitionId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.CompetitionId)
                .Index(t => t.UserId);
            
            AddForeignKey("dbo.UserRole", "UserId", "dbo.User", "Id");
            AddForeignKey("dbo.UserRole", "RoleId", "dbo.Role", "Id");
            AddForeignKey("dbo.Seat", "SeatTypeId", "dbo.SeatType", "Id");
            AddForeignKey("dbo.Competition", "AdminId", "dbo.User", "Id");
            AddForeignKey("dbo.Competition", "CompetitionTypeId", "dbo.CompetitionType", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Competition", "CompetitionTypeId", "dbo.CompetitionType");
            DropForeignKey("dbo.Competition", "AdminId", "dbo.User");
            DropForeignKey("dbo.Seat", "SeatTypeId", "dbo.SeatType");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.UserRole", "UserId", "dbo.User");
            DropForeignKey("dbo.CompetitionUser", "UserId", "dbo.User");
            DropForeignKey("dbo.CompetitionUser", "CompetitionId", "dbo.Competition");
            DropForeignKey("dbo.CompetitionClan", "ClanId", "dbo.Clan");
            DropForeignKey("dbo.CompetitionClan", "CompetitionId", "dbo.Competition");
            DropIndex("dbo.CompetitionUser", new[] { "UserId" });
            DropIndex("dbo.CompetitionUser", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionClan", new[] { "ClanId" });
            DropIndex("dbo.CompetitionClan", new[] { "CompetitionId" });
            DropTable("dbo.CompetitionUser");
            DropTable("dbo.CompetitionClan");
            AddForeignKey("dbo.Competition", "CompetitionTypeId", "dbo.CompetitionType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Competition", "AdminId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Seat", "SeatTypeId", "dbo.SeatType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRole", "RoleId", "dbo.Role", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRole", "UserId", "dbo.User", "Id", cascadeDelete: true);
        }
    }
}
