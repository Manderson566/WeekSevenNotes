using GoatHuntHarvestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoatHuntHarvestAPI.Controllers
{

    public class HarvestController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        public IQueryable<Harvest> Get()
        {
            return db.Harvests;
        }

        public IHttpActionResult Get(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var instance = db.Harvests.Find(id);
            if (instance == null)
            {
                return NotFound();
            }
            return Ok(instance);
        }
    }
}
