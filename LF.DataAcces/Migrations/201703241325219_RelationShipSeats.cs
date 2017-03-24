namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipSeats : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seat",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        XPosition = c.Int(nullable: false),
                        YPosition = c.Int(nullable: false),
                        UserId = c.Int(),
                        SeatTypeId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SeatType", t => t.SeatTypeId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.SeatTypeId);
            
            CreateTable(
                "dbo.SeatType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BackgroundColor = c.String(),
                        BackgroundImageUrl = c.String(),
                        ForeColor = c.String(),
                        Border = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seat", "UserId", "dbo.User");
            DropForeignKey("dbo.Seat", "SeatTypeId", "dbo.SeatType");
            DropIndex("dbo.Seat", new[] { "SeatTypeId" });
            DropIndex("dbo.Seat", new[] { "UserId" });
            DropTable("dbo.SeatType");
            DropTable("dbo.Seat");
        }
    }
}
