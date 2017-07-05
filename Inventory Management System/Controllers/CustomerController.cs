using Inventory_Management_System.DAL;
using Inventory_Management_System.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace Inventory_Management_System.Controllers
{
    public class CustomerController : ApiController
    {
        private IMS_DB db = new IMS_DB();

        // GET api/Employee
        public IQueryable<Customer> GetEmployee()
        {
            return db.Customer;
        }

        // GET api/Employee/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetEmployee(int id)
        {
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // POST: api/Customer
        [ResponseType(typeof(Customer))]
        public IHttpActionResult PostCustomer (Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Customer.Add(customer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = customer.CustomerId }, customer);
        }

        //PUT: api/Customer/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult PutCustomer (int id, Customer customer)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(id != customer.CustomerId)
            {
                return BadRequest();
            }

            db.Entry(customer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!CustomerExists(id))
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

        private bool CustomerExists(int id)
        {
            return db.Customer.Count(c => c.CustomerId == id) > 0;
        }

        //DELETE: api/Customer/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult DeleteCustomer(int id, Customer customer)
        {
            customer = db.Customer.Find(id);
            if(customer == null)
            {
                return NotFound();
            }

            db.Customer.Remove(customer);
            db.SaveChanges();

            return Ok(customer);
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
