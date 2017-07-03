using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}