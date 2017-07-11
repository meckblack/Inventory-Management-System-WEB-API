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

              
        }

        // GET: Category
        public ActionResult Index()
        {
            CategoryClient cc = new CategoryClient();
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
        public ActionResult Create(CategoryViewModel cvm, CategoryClient cc)
        {
            cc.Create(cvm.category);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            CategoryClient cc = new CategoryClient();
            cc.Delete(id);
            return RedirectToAction("Index");
        }


        // GET: Category/Edit/5
        [HttpGet]
        public ActionResult Edit(int id, CategoryClient cc, CategoryViewModel cvm)
        {
            cvm.category = cc.Find(id);
            return View("Edit", cvm);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(CategoryClient cc, CategoryViewModel cvm)
        {
            cc.Edit(cvm.category);
            return RedirectToAction("Index");
        }

     
      
    }
}
