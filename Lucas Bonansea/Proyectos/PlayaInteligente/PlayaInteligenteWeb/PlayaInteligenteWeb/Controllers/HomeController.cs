using PlayaInteligenteModel;
using PlayaInteligenteWeb.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayaInteligenteWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult IndexOld()
        {
            List<DarsenaViewModel> darsenasVM = new List<DarsenaViewModel>();
            foreach (Darsena darsena in Estacionamiento.Instancia.Darsenas)
            {
                darsenasVM.Add(new DarsenaViewModel(darsena));
            }
            return View();
        }

        public ActionResult Index()
        {
            List<DarsenaViewModel> darsenasVM = new List<DarsenaViewModel>();
            foreach (Darsena darsena in Estacionamiento.Instancia.Darsenas)
            {
                darsenasVM.Add(new DarsenaViewModel(darsena));
            }
            return View(darsenasVM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}