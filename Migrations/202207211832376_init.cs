namespace Progetto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.giardinieres",
                c => new
                    {
                        MATgiard = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false),
                        nome = c.String(),
                        cognome = c.String(),
                    })
                .PrimaryKey(t => t.MATgiard);
            
            CreateTable(
                "dbo.ordines",
                c => new
                    {
                        cod_ordine = c.Int(nullable: false, identity: true),
                        termine = c.DateTime(nullable: false),
                        completato = c.Boolean(nullable: false),
                        latitudine = c.Single(nullable: false),
                        longitudine = c.Single(nullable: false),
                        piantaId = c.Int(nullable: false),
                        giardiniereId = c.Int(),
                        paesaggistaId = c.Int(),
                    })
                .PrimaryKey(t => t.cod_ordine)
                .ForeignKey("dbo.giardinieres", t => t.giardiniereId)
                .ForeignKey("dbo.paesaggistas", t => t.paesaggistaId)
                .ForeignKey("dbo.piantas", t => t.piantaId, cascadeDelete: true)
                .Index(t => t.piantaId)
                .Index(t => t.giardiniereId)
                .Index(t => t.paesaggistaId);
            
            CreateTable(
                "dbo.paesaggistas",
                c => new
                    {
                        identificativo = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false),
                        nome = c.String(),
                        cognome = c.String(),
                    })
                .PrimaryKey(t => t.identificativo);
            
            CreateTable(
                "dbo.piantas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        taglia = c.Int(nullable: false),
                        ordinata = c.Boolean(nullable: false),
                        prezzopianta = c.Double(nullable: false),
                        prezzolavoro = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
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
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
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
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.ordines", "piantaId", "dbo.piantas");
            DropForeignKey("dbo.ordines", "paesaggistaId", "dbo.paesaggistas");
            DropForeignKey("dbo.ordines", "giardiniereId", "dbo.giardinieres");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.ordines", new[] { "paesaggistaId" });
            DropIndex("dbo.ordines", new[] { "giardiniereId" });
            DropIndex("dbo.ordines", new[] { "piantaId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.piantas");
            DropTable("dbo.paesaggistas");
            DropTable("dbo.ordines");
            DropTable("dbo.giardinieres");
        }
    }
}
