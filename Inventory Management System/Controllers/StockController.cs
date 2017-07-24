using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Inventory_Management_System.DAL;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Controllers
{
    public class StockController : ApiController
    {
        private IMS_DB db = new IMS_DB();

        // GET: api/Stock
        public IQueryable<Store> GetStock()
        {
            return db.Store.Include(s => s.StoreProduct).Include(s => s.StoreSupplier);
        }

        // GET: api/Stock/5
        [ResponseType(typeof(Store))]
        public IHttpActionResult GetStock(int id)
        {
            Store stock = db.Store.Find(id);
            if (stock == null)
            {
                return NotFound();
            }

            return Ok(stock);
        }

        // PUT: api/Stock/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStock(int id, Store stock)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != stock.ID)
            {
                return BadRequest();
            }


            db.Entry(stock).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
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

        // POST: api/Stock
        [ResponseType(typeof(Store))]
        public IHttpActionResult PostStock(Store stock)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
            
            System.Diagnostics.Debug.WriteLine("Product ID is " + stock.ProductId);
            System.Diagnostics.Debug.WriteLine("Supplier ID is " + stock.SupplierId);

            db.Store.Add(stock);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = stock.ID }, stock);
        }

        // DELETE: api/Stock/5
        [ResponseType(typeof(Store))]
        public IHttpActionResult DeleteStock(int id)
        {
            Store stock = db.Store.Find(id);
            if (stock == null)
            {
                return NotFound();
            }

            db.Store.Remove(stock);
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

        private bool StockExists(int id)
        {
            return db.Store.Count(e => e.ID == id) > 0;
        }
    }
}