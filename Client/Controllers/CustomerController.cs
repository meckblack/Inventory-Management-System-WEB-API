using System.Web.Mvc;
using Client.Models;
using Client.ViewModels;

namespace Client.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomerClient cc = new CustomerClient();
            ViewBag.CustomerList = cc.FindAll();
            return View();
        }

        // GET: Stock/Details/5
        public ActionResult Details(int Id)
        {
            CustomerClient cc = new CustomerClient();
            ViewBag.CustomerDetail = cc.Find(Id);
            return View("Details");
        }

        // GET: Stock/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(CustomerViewModel cvm)
        {
            CustomerClient cc = new CustomerClient();
            cc.Create(cvm.customer);
            return RedirectToAction("Index");

        }

        // GET: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            CustomerClient cc = new CustomerClient();
            cc.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: Stock/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            CustomerClient cc = new CustomerClient();
            CustomerViewModel cvm = new CustomerViewModel();
            cvm.customer = cc.Find(id); 
            return View("Edit", cvm);
        }

        // POST: Stock/Edit/5
        [HttpPost]
        public ActionResult Edit()
        {
            CustomerViewModel cvm = new CustomerViewModel();
            CustomerClient cc = new CustomerClient();
            cc.Edit(cvm.customer);
            return RedirectToAction("Index");
        }
    }
}
