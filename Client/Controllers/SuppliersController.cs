using System.Web.Mvc;
using Client.Models;
using Client.ViewModels;
using System.Linq;

namespace Client.Controllers
{
    public class SuppliersController : Controller
    {
        SupplierViewModel svm;
        SupplierClient sc;

        public SuppliersController()
        {
            svm = new SupplierViewModel();
            sc = new SupplierClient();
        }

        // GET: Suppliers
        public ActionResult Index()
        {
            ViewBag.SupplierList = sc.FindAll().OrderBy(s => s.Name);
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
            sc.Create(svm.supplier);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            sc.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            svm.supplier = sc.Find(id);
            return View("Edit", svm);
        }

        [HttpPost]
        public ActionResult Edit()
        {
            sc.Edit(svm.supplier);
            return RedirectToAction("Index");
        }
    }
}