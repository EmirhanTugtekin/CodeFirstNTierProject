using Business_Layer.Concrete;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI_Layer.Controllers
{
    [Authorize(Roles = "A,C")]
    public class ProductController : Controller
    {
        // GET: Product
        ProductManager productManager;

        public ProductController(ProductManager productManager)
        {
            this.productManager = productManager;
        }

        public ActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            productManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int id)
        {
            var value = productManager.TGetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            var value = productManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditProduct(Product p)
        {
            productManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}