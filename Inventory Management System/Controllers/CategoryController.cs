﻿using Inventory_Management_System.DAL;
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
    public class CategoryController : ApiController
    {
        private IMS_DB db = new IMS_DB();

        // GET: api/Category
        public IQueryable<Category> GetCategory()
        {
            return db.Category;
        }

        // GET: api/Category/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult GetCategory(int id, Category category)
        {
            category = db.Category.Find(id);
            if(category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        
        // POST: api/Category
        [ResponseType(typeof(Category))]
        public IHttpActionResult PostCateogry(Category category)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Category.Add(category);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = category.CategoryId }, category);
        }




        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}