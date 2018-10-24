using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace BankApp.Controllers.React
{
    public class ReactHomeController : Controller
    {
        // GET: ReactHome
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetName()
        {
            return Json(new { name = "World from server side", number=3764345 }, JsonRequestBehavior.AllowGet);
        }
    }
}