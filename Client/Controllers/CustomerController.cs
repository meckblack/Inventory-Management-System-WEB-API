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

        public ActionResult Details(int Id)
        {
            CustomerClient cc = new CustomerClient();
            ViewBag.CustomerDetail = cc.Find(Id);
            return View("Details");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(CustomerViewModel cvm)
        {
            CustomerClient cc = new CustomerClient();
            cc.Create(cvm.customer);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            CustomerClient cc = new CustomerClient();
            cc.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CustomerClient cc = new CustomerClient();
            CustomerViewModel cvm = new CustomerViewModel();
            cvm.customer = cc.Find(id); 
            return View("Edit", cvm);
        }

        [HttpPost]
        public ActionResult Edit(CustomerViewModel cvm)
        {
            CustomerClient cc = new CustomerClient();
            cc.Edit(cvm.customer);
            return RedirectToAction("Index");
        }
    }
}