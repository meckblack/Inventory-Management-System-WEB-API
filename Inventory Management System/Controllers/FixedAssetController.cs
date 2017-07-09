using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Web.Http;
using Inventory_Management_System.DAL;
using Inventory_Management_System.Models;
using System.Web.Http.Description;
using System.Net;
using System;

namespace Inventory_Management_System.Controllers
{
    public class FixedAssetController : ApiController
    {
        private IMS_DB db = new IMS_DB();

        // GET: api/FixedAsset
        public IQueryable<FixedAsset> GetFixedAsset()
        {
            return db.FixedAsset.Include(f => f.CategoryId).Include(f => f.LocationId);
        }

        // GET: api/FixedAsset/5
        [ResponseType(typeof(FixedAsset))]
        public IHttpActionResult GetFixedAsset(int id)
        {
            FixedAsset fixedAsset = new FixedAsset();
            if(fixedAsset == null)
            {
                return NotFound();
            }

            return Ok();
        }

        // POST: api/FixedAsset
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/FixedAsset/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FixedAsset/5
        public void Delete(int id)
        {
        }
    }
}
