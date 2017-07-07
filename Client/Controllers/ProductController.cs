using System.Web.Mvc;
using Client.Models;
using Client.ViewModels;

namespace Client.Controllers
{
    public class ProductController : Controller
    {
        ProductClient pc;

        public ProductController()
        {
            pc = new ProductClient();
        }

        // GET: Product
        public ActionResult Index(int id)
        {
            ViewBag.ProductList = pc.FindByCategory(id);
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel pvm)
        {
            ProductClient sc = new ProductClient();
            sc.Create(pvm.product);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            ProductClient sc = new ProductClient();
            sc.Delete(id);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    ProductClient sc = new ProductClient();
        //    ProductViewModel svm = new ProductViewModel();
        //    svm.product = sc.Find(id);
        //    return View("Edit", svm);
        //}

        [HttpPost]
        public ActionResult Edit(ProductViewModel pvm)
        {
            ProductClient pc = new ProductClient();
            pc.Edit(pvm.product);
            return RedirectToAction("Index");
        }
    }
}