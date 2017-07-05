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
    }
}