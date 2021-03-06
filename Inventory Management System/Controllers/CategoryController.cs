﻿using Inventory_Management_System.DAL;
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Category.Add(category);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = category.Id }, category);
        }

        //PUT: api/CaTEGORY/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult PutCategory(int id, Category category)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(id != category.Id)
            {
                return BadRequest();
            }

            db.Entry(category).State = EntityState.Modified;

            try
            {
                System.Diagnostics.Debug.WriteLine("Category before " + category.Name);
                db.SaveChanges();
                System.Diagnostics.Debug.WriteLine("Category after " + category.Name);

            }
            catch (DbUpdateConcurrencyException)
            {
                if(!CategoryExists(id))
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

        private bool CategoryExists(int id)
        {
            return db.Category.Count(c => c.Id == id) > 0;
        }


        // DELETE: api/Category/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult DeleteCategory(int id, Category category)
        {
            category = db.Category.Find(id);
            if(category == null)
            {
                return NotFound();
            }

            db.Category.Remove(category);
            db.SaveChanges();

            return Ok(category);
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
