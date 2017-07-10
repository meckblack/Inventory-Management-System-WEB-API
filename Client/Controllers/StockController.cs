using Client.Models;
using Client.ViewModels;
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
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}


        // GET: Stock/Create
        [HttpGet]
        public ActionResult Create()
        {
            StockClient sc = new StockClient();

            ViewBag.CategoryId = new SelectList(cc.FindAll(), "CategoryId", "CategoryName");
            ViewBag.ProductId = new SelectList(pc.FindAll(), "ProductId", "ProductName");
            ViewBag.SupplierId = new SelectList(suc.FindAll(), "SupplierId", "SupplierName");

            return View("Create");
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(StockViewModel svm)
        {
            StockClient sc = new StockClient();

            ViewBag.CategoryId = new SelectList(cc.FindAll(), "CategoryId", "CategoryName", svm.stock.CategoryId);
            ViewBag.ProductId = new SelectList(pc.FindAll(), "ProductId", "ProductName", svm.stock.ProductId);
            ViewBag.SupplierId = new SelectList(suc.FindAll(), "SupplierId", "SupplierName", svm.stock.SupplierId);
            sc.Create(svm.stock);


            return RedirectToAction("Index");

        }


        // GET: Stock/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            StockClient sc = new StockClient();
            StockViewModel svm = new StockViewModel();
            svm.stock = sc.Find(id);

            ViewBag.CategoryId = new SelectList(sc.FindAll(), "CategoryId", "StockCategory");
            ViewBag.ProductId = new SelectList(sc.FindAll(), "ProductId", "StockProduct");
            ViewBag.SupplierId = new SelectList(sc.FindAll(), "SupplierId", "StockSupplier");

            return View("Edit", svm);
        }

        // POST: Stock/Edit/5
        [HttpPost]
        public ActionResult Edit()
        {
            StockViewModel svm = new StockViewModel();
            StockClient sc = new StockClient();
            sc.Edit(svm.stock);

            ViewBag.CategoryId = new SelectList(sc.FindAll(), "StockId", "StockCategory", svm.stock.CategoryId);
            ViewBag.ProductId = new SelectList(sc.FindAll(), "ProductId", "StockProduct", svm.stock.ProductId);
            ViewBag.SupplierId = new SelectList(sc.FindAll(), "SupplierId", "StockSupplier", svm.stock.SupplierId);

            return RedirectToAction("Index");
        }

        // POST: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            StockClient sc = new StockClient();
            sc.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
