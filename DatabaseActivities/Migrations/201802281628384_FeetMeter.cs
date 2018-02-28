namespace DatabaseActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FeetMeter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FahrenheitCelsius",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fahrenheit = c.Double(nullable: false),
                        Celsius = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeetMeters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Meter = c.Double(nullable: false),
                        Feet = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MileFathoms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mile = c.Double(nullable: false),
                        Fathom = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PoundNewtons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pound = c.Double(nullable: false),
                        Newton = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PoundNewtons");
            DropTable("dbo.MileFathoms");
            DropTable("dbo.FeetMeters");
            DropTable("dbo.FahrenheitCelsius");
        }
    }
}
