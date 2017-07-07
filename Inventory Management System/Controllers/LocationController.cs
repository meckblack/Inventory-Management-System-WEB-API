using Inventory_Management_System.DAL;
using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
        public IHttpActionResult GetLocation(int id)
        {
            Location location = db.Location.Find(id);
            if(location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }

        // POST: api/Location
        [ResponseType(typeof(Location))]
        public IHttpActionResult PostLocation(Location location)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Location.Add(location);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = location.LocationId }, location);
        }

        // PUT: api/Location/5
        [ResponseType(typeof(Location))]
        public IHttpActionResult PutLocation(int id, Location location)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != location.LocationId)
            {
                return BadRequest();
            }

            db.Entry(location).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!LocationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool LocationExists(int id)
        {
            return db.Location.Count(c => c.LocationId == id) > 0;
        }

        // DELETE: api/Location/5
        [ResponseType(typeof(Location))]
        public IHttpActionResult DeleteLocation(int id, Location location)
        {
            location = db.Location.Find(id);
            if(location == null)
            {
                return NotFound();
            }

            db.Location.Remove(location);
            db.SaveChanges();

            return Ok(location);
        }
    }
}
