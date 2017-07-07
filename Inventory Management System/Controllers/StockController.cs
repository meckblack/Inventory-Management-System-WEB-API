using System.Linq;
using System.Web.Http;
using Inventory_Management_System.DAL;
using Inventory_Management_System.Models;
using System.Web.Http.Description;

namespace Inventory_Management_System.Controllers
{
    public class StockController : ApiController
    {
        private IMS_DB db = new IMS_DB();

        // GET: api/Stock
        public IQueryable<Stock> GetStock()
        {
            return db.Stock;
        }

        // GET: api/Stock/5
        [ResponseType(typeof(Stock))]
        public IHttpActionResult GetStock(int id)
        {
            Stock stock = db.Stock.Find(id);
            if(stock == null)
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
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stock/5
        public void Delete(int id)
        {
        }
    }
}
