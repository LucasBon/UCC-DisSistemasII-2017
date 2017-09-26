using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaTurnosWeb.Controllers
{
    public class JerarquiaMenuController : Controller
    {
        // GET: JerarquiaMenu
        public ActionResult Index()
        {
            return View();
        }

        // GET: JerarquiaMenu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JerarquiaMenu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JerarquiaMenu/Create
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

        // GET: JerarquiaMenu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JerarquiaMenu/Edit/5
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

        // GET: JerarquiaMenu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JerarquiaMenu/Delete/5
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
