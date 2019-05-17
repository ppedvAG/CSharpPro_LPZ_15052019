namespace ppedv.FlyingPluto.Data.EFdotnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Auto", "Created", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Auto", "Modified", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Vermietung", "Created", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Vermietung", "Modified", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Standort", "Created", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Standort", "Modified", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Kunde", "Created", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Kunde", "Modified", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kunde", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Kunde", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Standort", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Standort", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vermietung", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vermietung", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Auto", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Auto", "Created", c => c.DateTime(nullable: false));
        }
    }
}
