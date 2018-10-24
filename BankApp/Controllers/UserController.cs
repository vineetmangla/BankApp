using AutoMapper;
using BankApp.Filters;
using BankApp.Process;
using BankApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    [AuthorizeRoles(UserType.BankTeller)]
    public class UserController : Controller
    {
        private IUserProcess UserProcess = null;
        public UserController(IUserProcess _UserProcess)
        {
            this.UserProcess = _UserProcess;
        }
       

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            UserVM vm = new UserVM();
            return View(vm);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserVM collection)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(collection);
                }
                // TODO: Add insert logic here
                UserProcess.AddUser(Mapper.Map<UserDto>(collection));
                return RedirectToAction("Create");
            }
            catch(Exception ex)
            {
                return View(collection);
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
