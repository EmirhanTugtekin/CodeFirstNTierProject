using Business_Layer.Concrete;
using DAL_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace UI_Layer.Controllers
{
    [Authorize(Roles="A")]
    public class CustomerController : Controller
    {
        // GET: Customer

        //CustomerManager customerManager = new CustomerManager(new EfCustomerDal()); // ninject yapısıyla bu bağımlılıktan kurtuldum
        
        CustomerManager customerManager;

        public CustomerController(CustomerManager customerManager)
        {
            this.customerManager = customerManager;
        }

        public ActionResult Index()
        {
            var values = customerManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer p)
        {
            customerManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCustomer(int id)
        {
            var value = customerManager.TGetByID(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCustomer(int id)
        {
            var value = customerManager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditCustomer(Customer p)
        {
            customerManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}