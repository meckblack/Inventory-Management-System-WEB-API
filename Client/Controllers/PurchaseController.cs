using Client.Models;
using Client.ViewModels;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class PurchaseController : Controller
    {
        PurchaseViewModel pvm;
        PurchaseClient pc;

        public PurchaseController()
        {
            pvm = new PurchaseViewModel();
            pc = new PurchaseClient();
        }


        // GET: Purchase
        public ActionResult Index()
        {
            ViewBag.PurchaseList = pc.FindAll();
            return View();
        }

        // GET: Purchase/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Purchase/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Purchase/Create
        [HttpPost]
        public ActionResult Create(PurchaseViewModel pvm)
        {
            pc.Create(pvm.purchase);
            return RedirectToAction("Index");
        }

        // GET: Purchase/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            pvm.purchase = pc.Find(id);
            return View("Edit", pvm);
        }

        // POST: Purchase/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            pc.Edit(pvm.purchase);
            return RedirectToAction("Index");
        }

        // POST: Purchase/Delete/5
        [HttpPost]
        public ActionResult Delete()
        {
            pc.Edit(pvm.purchase);
            return RedirectToAction("Index");
        }
    }
}
