using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularMVC.DbUtil;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace TodoApp.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        public ActionResult customer()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public bool synch(string todos)
        {
            return new DbUtility().SaveDocuments(todos, "todos");
           
        }
        //
        // GET: /Customer/Details/5
        [HttpPost]
        public bool updatetodostatus(string todoid,int  todoidvalue,string key,string value)
        {
            //return new DbUtility().UpdateDocumentsById(todoid, todoidvalue,"todos", key, value);
            return true;
            
        }
        [HttpPost]
        public bool deletetodo(string text)
        {
            return new DbUtility().DeleteDocumentById("todos", "text", text);
            
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Customer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Customer/Create

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
        // GET: /Customer/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Customer/Edit/5

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
        // GET: /Customer/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Customer/Delete/5

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
