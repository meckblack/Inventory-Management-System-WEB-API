﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Inventory_Management_System.Controllers
{
    public class LocationController : ApiController
    {
        // GET: api/Location
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Location/5
        public string Get(int id)
        {
            return "value";
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
