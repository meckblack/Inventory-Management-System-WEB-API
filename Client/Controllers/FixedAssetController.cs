using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class FixedAssetController : Controller
    {
        // GET: FixedAsset
        public ActionResult Index()
        {
            FixedAssetClient fac = new FixedAssetClient();

            ViewBag.FixedAssetList = fac.FindAll();
            return View();
        }

        //// GET: FixedAsset/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: FixedAsset/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FixedAsset/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FixedAsset/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FixedAsset/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FixedAsset/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FixedAsset/Delete/5
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
