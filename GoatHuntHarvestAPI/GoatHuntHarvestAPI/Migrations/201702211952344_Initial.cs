namespace GoatHuntHarvestAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Harvests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        number = c.String(),
                        name = c.String(),
                        type = c.String(),
                        permits = c.String(),
                        hunters_afield = c.String(),
                        harvest = c.String(),
                        average_days = c.String(),
                        success = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Harvests");
        }
    }
}
