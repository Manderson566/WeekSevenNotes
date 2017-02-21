using DayTwoApiServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DayTwoApiServer.Controllers
{
    public class CerealController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        public IQueryable<Cereal> Get()
        {
            return db.Cereals;
        }

        [ResponseType(typeof(Cereal))]
        public IHttpActionResult Get(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var instance = db.Cereals.Find(id);
            if (instance == null)
            {
                return NotFound();
            }
            return Ok(instance);
        }

    }
}
