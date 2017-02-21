using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoatHuntHarvestAPI.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Harvest> Harvests { get; set; }
    }
}