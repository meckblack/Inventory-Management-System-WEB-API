using Client.Models;
using Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class StockController : Controller
    {

        StockClient sc;
        CategoryClient cc;
        ProductClient pc;
        SupplierClient suc;

        public StockController()
        {
            sc = new StockClient();
            cc = new CategoryClient();
            pc = new ProductClient();
            suc = new SupplierClient();
        }

        // GET: Stock
        public ActionResult Index()
        {
            ViewBag.StockList = sc.FindAll();
            return View();
        }

        // GET: Stock/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.StockDetails = cc.Find(id);
            return View("Details");
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            var svm = new StockViewModel();
            ViewBag.CategoryId = new SelectList(cc.FindAll(), "Id", "CategoryName");
            ViewBag.ProductId = new SelectList(pc.FindAll(), "Id", "ProductName");
            ViewBag.SupplierId = new SelectList(suc.FindAll(), "Id", "SupplierName");
            return View("Create", svm);
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(StockViewModel svm)
        {
            
            ViewBag.CategoryId = new SelectList(cc.FindAll(), "Id", "CategoryName", svm.stock.CategoryId);
            ViewBag.ProductId = new SelectList(pc.FindAll(), "Id", "ProductName", svm.stock.ProductId);
            ViewBag.SupplierId = new SelectList(suc.FindAll(), "Id", "SupplierName", svm.stock.SupplierId);
                 
            sc.Create(svm.stock);
            return RedirectToAction("Index");
        }

        // GET: Stock/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Stock/Edit/5
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

        // GET: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Stock/Delete/5
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
