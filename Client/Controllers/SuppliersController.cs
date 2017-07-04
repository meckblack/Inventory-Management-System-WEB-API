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
            ViewBag.SupplierList = sc.findAll();
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


        public ActionResult Delete(int Id)
        {
            SupplierClient sc = new SupplierClient();
            sc.Delete(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            SupplierClient sc = new SupplierClient();
            SupplierViewModel svm = new SupplierViewModel();
            svm.supplier = sc.find(Id);
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