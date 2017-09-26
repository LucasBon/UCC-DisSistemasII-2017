using PlayaInteligenteModel;
using PlayaInteligenteWeb.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayaInteligenteWeb.Controllers
{
    public class DarsenasController : Controller
    {
        iplayadbEntities db = new iplayadbEntities();

        // GET: Darsenas
        public ActionResult Index()
        {
            List<DarsenaViewModel> darsenasVM = new List<DarsenaViewModel>();
            foreach (DarsenaDao darsenaDao in db.DarsenasDao)
            {
                darsenasVM.Add(new DarsenaViewModel(darsenaDao.Darsena));
            }
            return View(darsenasVM);
        }

        // GET: Darsenas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Darsenas/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Numero,Estado")] DarsenaViewModel darsenaVM)
        {
            if (ModelState.IsValid)
            {
                DarsenaDao darsenaDao = new DarsenaDao();
                darsenaDao.Numero = darsenaVM.Numero;
                darsenaDao.Estado = (int) Enum.Parse(typeof(EstadoDarsena), darsenaVM.Estado, true);
                db.DarsenasDao.Add(darsenaDao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(darsenaVM);
        }

        // GET: Darsenas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Darsenas/Delete/5
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
