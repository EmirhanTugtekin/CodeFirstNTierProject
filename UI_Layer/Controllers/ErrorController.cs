using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI_Layer.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Page403()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Page401()
        {
            Response.StatusCode = 401;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        /*
         <customErrors mode="On">
      <error statusCode="404" redirect="/Error/Page404"/>
      <error statusCode="403" redirect="/Error/Page403"/>
      <error statusCode="401" redirect="/Error/Page401"/>
    </customErrors>
         */
    }
}