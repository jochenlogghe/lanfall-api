namespace LF.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipRolesTableAdjustments : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserRole", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.UserRole", name: "Role_Id", newName: "RoleId");
            RenameIndex(table: "dbo.UserRole", name: "IX_User_Id", newName: "IX_UserId");
            RenameIndex(table: "dbo.UserRole", name: "IX_Role_Id", newName: "IX_RoleId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserRole", name: "IX_RoleId", newName: "IX_Role_Id");
            RenameIndex(table: "dbo.UserRole", name: "IX_UserId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.UserRole", name: "RoleId", newName: "Role_Id");
            RenameColumn(table: "dbo.UserRole", name: "UserId", newName: "User_Id");
        }
    }
}
