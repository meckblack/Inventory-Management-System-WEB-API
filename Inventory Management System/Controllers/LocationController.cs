using Inventory_Management_System.DAL;
using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Inventory_Management_System.Controllers
{
    public class LocationController : ApiController
    {

        private IMS_DB db = new IMS_DB();

        // GET: api/Location
        public IQueryable<Location> GetLocation()
        {
            return db.Location;
        }

        // GET: api/Location/5
        [ResponseType(typeof(Location))]
        public IHttpActionResult GetLocation(int id, Location location)
        {
            location = db.Location.Find(id);
            if(location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }

        // POST: api/Location
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Location/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Location/5
        public void Delete(int id)
        {
        }
    }
}
