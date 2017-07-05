using System.Web.Mvc;
using Client.Models;
using Client.ViewModels;

namespace Client.Controllers
{
    public class SuppliersController : Controller
    {
        // GET: Suppliers
        public ActionResult Index()
        {
            SupplierClient sc = new SupplierClient();
            ViewBag.SupplierList = sc.FindAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(SupplierViewModel svm)
        {
            SupplierClient sc = new SupplierClient();
            sc.Create(svm.supplier);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            SupplierClient sc = new SupplierClient();
            sc.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            SupplierClient sc = new SupplierClient();
            SupplierViewModel svm = new SupplierViewModel();
            svm.supplier = sc.Find(id);
            return View("Edit", svm);
        }

        [HttpPost]
        public ActionResult Edit(SupplierViewModel svm)
        {
            SupplierClient sc = new SupplierClient();
            sc.Edit(svm.supplier);
            return RedirectToAction("Index");
        }
    }
}