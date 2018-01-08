using System.Web.Mvc;
using Client.Models;
using Client.ViewModels;
using System.Linq;

namespace Client.Controllers
{
    public class CustomerController : Controller
    {
        CustomerClient cuc;
        public CustomerController()
        {
            cuc = new CustomerClient();
        }

        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.CustomerList = cuc.FindAll().OrderBy(s => s.Name);
            return View();
        }

        //// GET: Stock/Details/5
        //public ActionResult Details(int Id)
        //{
        //    CustomerClient cc = new CustomerClient();
        //    ViewBag.CustomerDetail = cc.Find(Id);
        //    return View("Details");
        //}

        // GET: Stock/Create
        [HttpGet]
        public ActionResult Create()
        {
            var cuvm = new CustomerViewModel();
            return PartialView("Create", cuvm);
        }

        // POST: Stock/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerViewModel cuvm)
        {
            if (ModelState.IsValid)
            {
                cuc.Create(cuvm.customer);
                return Json(new { success = true });
            }

            return PartialView("Create", cuvm);
        }

        // GET: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            cuc.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: Stock/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            CustomerViewModel cuvm = new CustomerViewModel();
            cuvm.customer = cuc.Find(id); 
            return PartialView("Edit", cuvm);
        }

        // POST: Stock/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerViewModel cuvm)
        {
            if (ModelState.IsValid)
            {
                cuc.Edit(cuvm.customer);
                return Json(new { success = true });
            }

            return PartialView("Create", cuvm);
        }
    }
}
