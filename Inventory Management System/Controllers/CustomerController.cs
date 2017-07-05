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

        // Create: api/Customer
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
    }
}
