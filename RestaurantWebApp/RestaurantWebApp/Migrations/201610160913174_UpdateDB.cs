namespace RestaurantWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            //DropTable("dbo.ViewReportVMs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ViewReportVMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeId = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Type = c.String(),
                        PickDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
