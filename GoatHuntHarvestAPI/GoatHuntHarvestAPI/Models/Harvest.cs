using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoatHuntHarvestAPI.Models
{
    public class Harvest
    {
        public int Id { get; set; }
        public string number { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string permits { get; set; }
        public string hunters_afield { get; set; }
        public string harvest { get; set; }
        public string average_days { get; set; }
        public string success { get; set; }
    }
}