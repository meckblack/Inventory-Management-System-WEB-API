using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            CustomerClient cs = new CustomerClient();
            ViewBag.CustomerList = cs.FindAll();
            return View();
        }

        public ActionResult Details(int Id)
        {
            CustomerClient cs = new CustomerClient();
            ViewBag.CustomerDetail = cs.Find(Id);
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
            CustomerClient sc = new CustomerClient();
            sc.Create(cvm.customer);
            return RedirectToAction("Index");
        }
    }
}