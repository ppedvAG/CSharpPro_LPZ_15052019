namespace ppedv.FlyingPluto.Data.EFdotnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kennzeichen = c.String(nullable: false, maxLength: 27),
                        Marke = c.String(),
                        Modell = c.String(),
                        Farbe = c.String(),
                        Sizte = c.Int(nullable: false),
                        Automatik = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Standort_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Standort", t => t.Standort_Id)
                .Index(t => t.Standort_Id);
            
            CreateTable(
                "dbo.Vermietung",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Von = c.DateTime(nullable: false),
                        Bis = c.DateTime(nullable: false),
                        Km = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        AbholStandort_Id = c.Int(nullable: false),
                        Auto_Id = c.Int(),
                        Kunde_Id = c.Int(),
                        ZielStandort_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Standort", t => t.AbholStandort_Id)
                .ForeignKey("dbo.Auto", t => t.Auto_Id)
                .ForeignKey("dbo.Kunde", t => t.Kunde_Id)
                .ForeignKey("dbo.Standort", t => t.ZielStandort_Id)
                .Index(t => t.AbholStandort_Id)
                .Index(t => t.Auto_Id)
                .Index(t => t.Kunde_Id)
                .Index(t => t.ZielStandort_Id);
            
            CreateTable(
                "dbo.Standort",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Ort = c.String(),
                        Chef = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kunde",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GebDatum = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vermietung", "ZielStandort_Id", "dbo.Standort");
            DropForeignKey("dbo.Vermietung", "Kunde_Id", "dbo.Kunde");
            DropForeignKey("dbo.Vermietung", "Auto_Id", "dbo.Auto");
            DropForeignKey("dbo.Vermietung", "AbholStandort_Id", "dbo.Standort");
            DropForeignKey("dbo.Auto", "Standort_Id", "dbo.Standort");
            DropIndex("dbo.Vermietung", new[] { "ZielStandort_Id" });
            DropIndex("dbo.Vermietung", new[] { "Kunde_Id" });
            DropIndex("dbo.Vermietung", new[] { "Auto_Id" });
            DropIndex("dbo.Vermietung", new[] { "AbholStandort_Id" });
            DropIndex("dbo.Auto", new[] { "Standort_Id" });
            DropTable("dbo.Kunde");
            DropTable("dbo.Standort");
            DropTable("dbo.Vermietung");
            DropTable("dbo.Auto");
        }
    }
}
