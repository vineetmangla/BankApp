using BankApp.Filters;
using BankApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    [AuthorizeRoles(UserType.BankTeller,UserType.Customer)]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}