using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularMVC.DbUtil;

namespace TodoApp.Controllers
{
    public class CustomerOrderController : Controller
    {
        //
        // GET: /CustomerOrder/
        [HttpPost]
        public string addcustomer(string customer)
        {
            return new DbUtility().SaveDocumentAndReturnObjectId(customer, "customers");
        }
        [HttpPost]
        public bool addorder(string customer, string objectid)
        {
            //return new DbUtility().UpdateDocumentsByObjectIdnew(objectid, "customers", "orders", customer);
            //return new DbUtility().UpdateDocumentsByObjectIdForMultipleAttributes(objectid, "customers", customer);
            return new DbUtility().UpdateDocumentsById("custid", 1, "customers", "orders", customer);
        }
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /CustomerOrder/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /CustomerOrder/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CustomerOrder/Create

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
        // GET: /CustomerOrder/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CustomerOrder/Edit/5

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
        // GET: /CustomerOrder/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CustomerOrder/Delete/5

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
