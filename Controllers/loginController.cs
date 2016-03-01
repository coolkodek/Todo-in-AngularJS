using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularMVC.DbUtil;

namespace TodoApp.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /login/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewLogin()
        {
            return View();
        }
        public bool login(string userid, string password)
        {

            string role = new DbUtility().ValidateUser("users", userid, password);
            if (role == "customer")
                return true;
            else
                return false;

        }
        //
        // GET: /login/Details/5


        //
        // GET: /login/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /login/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /login/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /login/Edit/5

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

        //
        // GET: /login/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /login/Delete/5

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
