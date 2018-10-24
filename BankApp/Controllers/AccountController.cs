using AutoMapper;
using BankApp.DTO;
using BankApp.Filters;
using BankApp.Process.Interface;
using BankApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    [AuthorizeRoles(UserType.BankTeller)]
    public class AccountController : Controller
    {
        private IAccountProcess AccountProcess = null;
        public AccountController(IAccountProcess _accountProcess)
        {
            this.AccountProcess = _accountProcess;
        }
        // GET: Account
        public ActionResult Create()
        {
            AccountVM vm = new AccountVM();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Create(AccountVM vm)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(vm);
                }

                AccountProcess.AddAccount(Mapper.Map<AccountDTO>(vm));
            }
            catch(Exception ex)
            {
                return View(vm);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Search()
        {
            AccountVM vm = new AccountVM();
           
            return View(vm);

        }

        [HttpPost]
        public ActionResult Search12(int accountNumber)
        {
            AccountVM vm = new AccountVM();
            try
            {
                var accountDto = AccountProcess.SearchByAccount(accountNumber);
                vm = Mapper.Map<AccountVM>(accountDto);
            }
            catch (Exception ex)
            {
                return View(vm);
            }
            return View(vm);

        }
    }
}