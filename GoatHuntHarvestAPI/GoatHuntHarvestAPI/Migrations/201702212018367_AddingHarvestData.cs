namespace GoatHuntHarvestAPI.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class AddingHarvestData : DbMigration
    {
        ApplicationContext db = new ApplicationContext();

        public override void Up()
        {
            var systemPath = AppDomain.CurrentDomain.BaseDirectory + @"..\App_Data\Data.csv";
            var openFile = File.ReadAllLines(systemPath);

            foreach (string row in openFile)
            {
                var data = row.Split(',');
                Harvest newHarvest = new Harvest
                {
                    number = data[0],
                    name = data[1],
                    type = data[2],
                    permits = data[3],
                    hunters_afield = data[4],
                    harvest = data[5],
                    average_days = data[6],
                    success = data[7],
                };
                db.Harvests.Add(newHarvest);
            }
            db.SaveChanges();
        }

        public override void Down()
        {
        }
    }
}
