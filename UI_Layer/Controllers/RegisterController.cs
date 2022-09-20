using Business_Layer;
using Business_Layer.Concrete;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI_Layer.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        CustomerManager customerManager;
        AdminManager adminManager;

        public RegisterController(CustomerManager customerManager, AdminManager adminManager)
        {
            this.customerManager = customerManager;
            this.adminManager = adminManager;
        }

        [HttpGet]
        public ActionResult CustomerRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CustomerRegister(Customer p)
        {
            customerManager.TInsert(p);
            return RedirectToAction("Customer", "Login");          
        }
    }
}