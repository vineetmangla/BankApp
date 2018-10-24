using BankApp.Process;
using BankApp.Process.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers.React
{
    public class ReactUserController : Controller
    {
        private IProcessFactory ProcessFactory = null;

        public ReactUserController(IProcessFactory _ProcessFactory)
        {
            this.ProcessFactory = _ProcessFactory;
        }
        // GET: ReactUser
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetUserList()
        {
            var user = ProcessFactory.GetProcessFactory<IUserProcess>().GetAll();
            return Json(new {data=user.ToArray() },JsonRequestBehavior.AllowGet);

        }
    }
}