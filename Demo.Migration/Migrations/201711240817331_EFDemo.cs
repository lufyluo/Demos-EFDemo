namespace Demo.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EFDemo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        UserInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInfo", t => t.UserInfo_Id)
                .Index(t => t.UserInfo_Id);
            
            CreateTable(
                "dbo.Diary",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.User_Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "UserInfo_Id", "dbo.UserInfo");
            DropForeignKey("dbo.User_Roles", "UserId", "dbo.User");
            DropForeignKey("dbo.Diary", "User_Id", "dbo.User");
            DropIndex("dbo.User_Roles", new[] { "UserId" });
            DropIndex("dbo.Diary", new[] { "User_Id" });
            DropIndex("dbo.User", new[] { "UserInfo_Id" });
            DropTable("dbo.UserInfo");
            DropTable("dbo.User_Roles");
            DropTable("dbo.Diary");
            DropTable("dbo.User");
        }
    }
}
