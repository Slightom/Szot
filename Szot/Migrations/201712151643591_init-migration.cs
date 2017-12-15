namespace Szot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Country = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        AuthorID = c.Int(nullable: false),
                        BackingID = c.Int(),
                        WithBacking = c.Boolean(nullable: false),
                        TextLanguage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SongID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .ForeignKey("dbo.Backings", t => t.BackingID)
                .Index(t => t.AuthorID)
                .Index(t => t.BackingID);
            
            CreateTable(
                "dbo.Backings",
                c => new
                    {
                        BackingID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        BackingStatus = c.Int(nullable: false),
                        path = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BackingID);
            
            CreateTable(
                "dbo.SongCategories",
                c => new
                    {
                        SongID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SongID, t.CategoryID })
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Songs", t => t.SongID, cascadeDelete: true)
                .Index(t => t.SongID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        PlaceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventID)
                .ForeignKey("dbo.Places", t => t.PlaceID, cascadeDelete: true)
                .Index(t => t.PlaceID);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        PlaceID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.PlaceID);
            
            CreateTable(
                "dbo.PlacePhotos",
                c => new
                    {
                        PlaceID = c.Int(nullable: false),
                        PhotoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlaceID, t.PhotoID })
                .ForeignKey("dbo.Photos", t => t.PhotoID, cascadeDelete: true)
                .ForeignKey("dbo.Places", t => t.PlaceID, cascadeDelete: true)
                .Index(t => t.PlaceID)
                .Index(t => t.PhotoID);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        PhotoID = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PhotoID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Text = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Posts", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.PlacePhotoes", "PlaceID", "dbo.Places");
            DropForeignKey("dbo.PlacePhotoes", "PhotoID", "dbo.Photos");
            DropForeignKey("dbo.Events", "PlaceID", "dbo.Places");
            DropForeignKey("dbo.SongCategories", "SongID", "dbo.Songs");
            DropForeignKey("dbo.SongCategories", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Songs", "BackingID", "dbo.Backings");
            DropForeignKey("dbo.Songs", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Roles", "RoleNameIndex");
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.Users", "UserNameIndex");
            DropIndex("dbo.Posts", new[] { "User_Id" });
            DropIndex("dbo.PlacePhotoes", new[] { "PhotoID" });
            DropIndex("dbo.PlacePhotoes", new[] { "PlaceID" });
            DropIndex("dbo.Events", new[] { "PlaceID" });
            DropIndex("dbo.SongCategories", new[] { "CategoryID" });
            DropIndex("dbo.SongCategories", new[] { "SongID" });
            DropIndex("dbo.Songs", new[] { "BackingID" });
            DropIndex("dbo.Songs", new[] { "AuthorID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.UserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Photos");
            DropTable("dbo.PlacePhotoes");
            DropTable("dbo.Places");
            DropTable("dbo.Events");
            DropTable("dbo.Categories");
            DropTable("dbo.SongCategories");
            DropTable("dbo.Backings");
            DropTable("dbo.Songs");
            DropTable("dbo.Authors");
        }
    }
}
