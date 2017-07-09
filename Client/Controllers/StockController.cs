using Client.Models;
using Client.ViewModels;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            StockClient sc = new StockClient();

            ViewBag.StockList = sc.FindAll();
            return View();
        }

        // GET: Stock/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}


        // GET: Stock/Create
        [HttpGet]
        public ActionResult Create()
        {
            StockClient sc = new StockClient();

            ViewBag.CategoryId = new SelectList(sc.FindAll(), "CategoryId", "StockCategory");
            ViewBag.ProductId = new SelectList(sc.FindAll(), "ProductId", "StockProduct");
            ViewBag.SupplierId = new SelectList(sc.FindAll(), "SupplierId", "StockSupplier");

            return View("Create");
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(StockViewModel svm)
        {
            StockClient sc = new StockClient();

            ViewBag.CategoryId = new SelectList(sc.FindAll(), "StockId", "StockCategory", svm.stock.CategoryId);
            ViewBag.ProductId = new SelectList(sc.FindAll(), "ProductId", "StockProduct", svm.stock.ProductId);
            ViewBag.SupplierId = new SelectList(sc.FindAll(), "SupplierId", "StockSupplier", svm.stock.SupplierId);
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
