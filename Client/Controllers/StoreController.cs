using Client.Models;
using Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class StoreController : Controller
    {

        StoreClient sc;
        ProductClient pc;
        SupplierClient suc;

        public StoreController()
        {
            sc = new StoreClient();
            pc = new ProductClient();
            suc = new SupplierClient();
        }

        // GET: Store
        public ActionResult Index()
        {
            ViewBag.StoreList = sc.FindAll();
            return View();
        }

        // GET: Store/Details/5
        //public ActionResult Details(int id)
        //{
        //    ViewBag.StoreDetails = cc.Find(id);
        //    return View("Details");
        //}

        // GET: Store/Create
        public ActionResult Create()
        {
            var svm = new StoreViewModel();
            ViewBag.ProductId = new SelectList(pc.FindAll(), "Id", "ProductName");
            ViewBag.SupplierId = new SelectList(suc.FindAll(), "Id", "SupplierName");
            return View("Create", svm);
        }

        // POST: Store/Create
        [HttpPost]
        public ActionResult Create(StoreViewModel svm)
        {
            
            ViewBag.ProductId = new SelectList(pc.FindAll(), "Id", "ProductName", svm.store.ProductId);
            ViewBag.SupplierId = new SelectList(suc.FindAll(), "Id", "SupplierName", svm.store.SupplierId);

            System.Diagnostics.Debug.WriteLine("Product C ID is " + svm.store.ProductId);
            System.Diagnostics.Debug.WriteLine("Supplier C ID is " + svm.store.SupplierId);

            sc.Create(svm.store);
            return RedirectToAction("Index");
        }

        // GET: Store/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Store/Edit/5
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

        // GET: Store/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Store/Delete/5
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
