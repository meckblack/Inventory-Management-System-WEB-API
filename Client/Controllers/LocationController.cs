using Client.Models;
using Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            LocationClient cc = new LocationClient();
            ViewBag.LocationList = cc.FindAll();
            return View();
        }

        // GET: Location/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Location/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Location/Create
        [HttpPost]
        public ActionResult Create(LocationViewModel lvm, LocationClient lc)
        {
            lc.Create(lvm.location);
            return RedirectToAction("Index");
        }

        // GET: Location/Edit/5
        [HttpGet]
        public ActionResult Edit(int id, LocationClient lc, LocationViewModel lvm)
        {
            lvm.location = lc.Find(id);
            return View("Edit", lvm);
        }

        // POST: Location/Edit/5
        [HttpPost]
        public ActionResult Edit(LocationClient lc, LocationViewModel lvm)
        {
            lc.Edit(lvm.location);
            return RedirectToAction("Index");
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Location/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
