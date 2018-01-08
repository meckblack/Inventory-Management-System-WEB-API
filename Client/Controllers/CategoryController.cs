using System.Web.Mvc;
using Client.Models;
using Client.ViewModels;

namespace Client.Controllers
{
    public class CategoryController : Controller
    {
        CategoryClient cc;
        CategoryViewModel cvm;

        public CategoryController()
        {
            cc = new CategoryClient();
            cvm = new CategoryViewModel();
              
        }

        // GET: Category
        public ActionResult Index()
        {
            ViewBag.CategoryList = cc.FindAll();
            return View();
        }

        // GET: Category/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Category/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(CategoryViewModel cvm)
        {
            cc.Create(cvm.category);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            cc.Delete(id);
            return RedirectToAction("Index");
        }


        // GET: Category/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            cvm.category = cc.Find(id);
            return View("Edit", cvm);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit()
        {
            cc.Edit(cvm.category);
            return RedirectToAction("Index");
        }

     
      
    }
}
