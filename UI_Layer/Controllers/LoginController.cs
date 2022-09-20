using Business_Layer.Concrete;
using Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Entity_Layer;
using System.Security.Claims;
using DAL_Layer.Concrete;
using System.Web.Security;
using Ninject.Activation;
using Context = DAL_Layer.Concrete.Context;

namespace UI_Layer.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        CustomerManager customerManager;
        AdminManager adminManager;

        public LoginController(CustomerManager customerManager, AdminManager adminManager)
        {
            this.customerManager = customerManager;
            this.adminManager = adminManager;
        }

        [HttpGet]
        public ActionResult CustomerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CustomerLogin(Customer p)
        {
            Context context = new Context();
            var bilgiler = context.Customers.FirstOrDefault(x => x.CustomerName == p.CustomerName && x.CustomerPassword == p.CustomerPassword);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.CustomerName, false);
                Session["Name"] = bilgiler.CustomerName.ToString();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return RedirectToAction("CustomerLogin", "Login");
            }


        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            Context context = new Context();
            var bilgiler = context.Admins.FirstOrDefault(x => x.AdminName == p.AdminName && x.AdminPassword == p.AdminPassword);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.AdminName, false);
                Session["Name"] = bilgiler.AdminName.ToString();
                return RedirectToAction("Index", "Customer");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }

        }
       
    }
}