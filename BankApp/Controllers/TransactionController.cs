using AutoMapper;
using BankApp.DTO;
using BankApp.Filters;
using BankApp.Process;
using BankApp.Process.Interface;
using BankApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    [AuthorizeRoles(UserType.Customer)]
    public class TransactionController : Controller
    {
        //private ITransactionProcess TransactionProcess = null;
        //private IAccountProcess AccountProcess = null;

        //public TransactionController(ITransactionProcess _transactionProcess, IAccountProcess _accountProcess)
        //{
        //    this.TransactionProcess = _transactionProcess;
        //    this.AccountProcess = _accountProcess;
        //}
        private IProcessFactory ProcessFactory = null;
        public TransactionController(IProcessFactory _processFactory)
        {
            this.ProcessFactory = _processFactory;
            
        }
        // GET: Transaction
        public ActionResult Index()
        {
            TransactionVM vm = new TransactionVM();
            vm.FromAccount =  from action in ProcessFactory.GetProcessFactory<IAccountProcess>().GetAccountByUserId(1)
                              select new SelectListItem
            {
                Text = action.AccountNumber.ToString(),
                Value = action.AccountId.ToString()
            };

            vm.ToAccount = from action in ProcessFactory.GetProcessFactory<IAccountProcess>().GetLinkedAccountByUserId(1)
                             select new SelectListItem
                             {
                                 Text = action.AccountNumber.ToString(),
                                 Value = action.AccountId.ToString()
                             };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Create(TransactionVM transactionVM)
        {
            ProcessFactory.GetProcessFactory<ITransactionProcess>().CreateTransactiion(Mapper.Map<TransactionDTO>(transactionVM));
            return RedirectToAction("Index");
        }
    }
}