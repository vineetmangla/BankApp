using AutoMapper;
using BankApp.DTO;
using BankApp.Process;
using BankApp.Process.Interface;
using BankApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    public class UserAuthController : Controller
    {
        private IProcessFactory ProcessFactory = null;

        public UserAuthController(IProcessFactory _ProcessFactory)
        {
            this.ProcessFactory = _ProcessFactory;
        }

        public ActionResult Login(string returnUrl)
        {
            UserLoginVM vm = new UserLoginVM();
            vm.Message = "";
            vm.ReturnUrl = returnUrl;
            return View(vm);
        }

        [HttpPost]
        public ActionResult Login(UserLoginVM vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }

            var userDetails = ProcessFactory.GetProcessFactory<IUserLoginProcess>().ValidateCredentials(Mapper.Map<UserLoginDTO>(vm));
            if (userDetails != null && userDetails.UserId > 0 && userDetails.User!=null)
            {
                var identity = new ClaimsIdentity(new[]
                    {
                    new Claim(ClaimTypes.NameIdentifier,userDetails.UserId.ToString()),
                   new Claim(ClaimTypes.Name,userDetails.User.FirstName),
                    new Claim(ClaimTypes.Email,userDetails.User.Email),
                    new Claim(ClaimTypes.Role,((UserType)userDetails.User.UserType).ToString())
               },
                   "ApplicationCookie"
                    );

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;
                authManager.SignIn(identity);
                if (Url.IsLocalUrl(vm.ReturnUrl))
                {
                    return Redirect(vm.ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "dashboard");
                }

            }
            vm.Message = "Invalid Username or password !!";
            return View(vm);

        }

        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;
            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Login");
        }

    }
}
