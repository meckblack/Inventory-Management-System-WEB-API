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
    public class StockController : ApiController
    {
        private IMS_DB db = new IMS_DB();

        // GET: api/Stock
        public IQueryable<Stock> GetStock()
        {
            return db.Stock.Include(s => s.StockCategory).Include(s => s.StockProduct).Include(s => s.StockSupplier);
        }

        // GET: api/Stock/5
        [ResponseType(typeof(Stock))]
        public IHttpActionResult GetStock(int id)
        {
            Stock stock = db.Stock.Find(id);
            if (stock == null)
            {
                return NotFound();
            }

            return Ok();
        }

        // POST: api/Stock
        [ResponseType(typeof(Stock))]
        public IHttpActionResult PostStock(Stock stock)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Stock.Add(stock);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = stock.StockId }, stock);
        }

        // PUT: api/Stock/5
        [ResponseType(typeof(Stock))]
        public IHttpActionResult PutStock(int id, Stock stock)
        {
            if(!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }

            db.Entry(stock).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!StockExists(id))
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

        private bool StockExists(int id)
        {
            return db.Stock.Count(e => e.StockId == id) > 0;
        }

        // DELETE: api/Stock/5
        [ResponseType(typeof(Stock))]
        public IHttpActionResult DeleteStock(int id)
        {
            Stock stock = db.Stock.Find(id);
            if (stock == null)
            {
                return NotFound();
            }

            db.Stock.Remove(stock);
            db.SaveChanges();

            return Ok(stock);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
