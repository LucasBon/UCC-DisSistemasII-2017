using SistemaTurnos;
using SistemaTurnosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaTurnosWeb.Controllers
{
    public class MotivoAtencionController : Controller
    {
        private TurnosContexto contexto = TurnosContexto.Instancia;

        // GET: MotivoAtencion
        public ActionResult Index()
        {
            List<MotivoAtencionViewModel> motivosAtencionVM = new List<MotivoAtencionViewModel>();
            foreach (MotivoAtencion ma in contexto.MotivosAtencion)
            {
                motivosAtencionVM.Add(new MotivoAtencionViewModel(ma));
            }
            return View(motivosAtencionVM);
        }

        // GET: MotivoAtencion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MotivoAtencion/Create
        public ActionResult Create(int? id)
        {
            MotivoAtencionViewModel mavm = null;
            if (id != null)
            {
                mavm = new MotivoAtencionViewModel(contexto.MotivosAtencion.Find(ma => ma.Id == id.Value));
            }
            return View(mavm);
        }

        // POST: MotivoAtencion/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "LetraDescriptiva,Nombre")] MotivoAtencionViewModel mavm)
        {
            if (ModelState.IsValid)
            {
                MotivoAtencion motivoNuevo = new MotivoAtencion(mavm.Nombre, mavm.LetraDescriptiva);
                motivoNuevo.Id = contexto.MotivosAtencion.Count + 1;
                contexto.MotivosAtencion.Add(motivoNuevo);

                return View(new MotivoAtencionViewModel(motivoNuevo));
            }

            return View(mavm);
        }

        public ActionResult ListDisponibilidad(int IdMotivoAtencion)
        {
            ViewData.Add("IdMotivoAtencion", IdMotivoAtencion);
            MotivoAtencion motivo = contexto.MotivosAtencion.Find(ma => ma.Id == IdMotivoAtencion);

            List<DisponibilidadViewModel> disponibilidades = new List<DisponibilidadViewModel>();
            
            foreach (DayOfWeek diaSemana in motivo.Disponibildiad.Keys)
            {
                disponibilidades.Add(new DisponibilidadViewModel(diaSemana, motivo.Disponibildiad[diaSemana]));
            }

            return View(disponibilidades);
        }

        // GET: MotivoAtencion/Create
        public ActionResult CreateDisponibilidad(int? IdMotivoAtencion)
        {
            ViewData.Add("IdMotivoAtencion", IdMotivoAtencion);
            return View();
        }

        // POST: MotivoAtencion/Create
        [HttpPost]
        public ActionResult CreateDisponibilidad([Bind(Include = "IdMotivoAtencion,DiaSemana,Desde,Hasta")] DisponibilidadViewModel disponibilidad)
        {
            if (ModelState.IsValid)
            {
                MotivoAtencion motivo = contexto.MotivosAtencion.Find(ma => ma.Id == disponibilidad.IdMotivoAtencion);

                DayOfWeek diaDeSemana;
                switch (disponibilidad.DiaSemana.ToUpper())
                {
                    case "LUNES":
                        diaDeSemana = DayOfWeek.Monday;
                        break;
                    case "MARTES":
                        diaDeSemana = DayOfWeek.Tuesday;
                        break;
                    case "MIERCOLES":
                        diaDeSemana = DayOfWeek.Wednesday;
                        break;
                    case "JUEVES":
                        diaDeSemana = DayOfWeek.Thursday;
                        break;
                    case "VIERNES":
                        diaDeSemana = DayOfWeek.Friday;
                        break;
                    case "SABADO":
                        diaDeSemana = DayOfWeek.Saturday;
                        break;
                    default:
                        diaDeSemana = DayOfWeek.Sunday;
                        break;

                }

                if (!motivo.Disponibildiad.ContainsKey(diaDeSemana))
                {
                    motivo.Disponibildiad.Add(diaDeSemana, new RangoHora(disponibilidad.Desde, disponibilidad.Hasta));
                } else
                {
                    motivo.Disponibildiad[diaDeSemana] = new RangoHora(disponibilidad.Desde, disponibilidad.Hasta);
                }

                return RedirectToAction("Create", new { id = disponibilidad.IdMotivoAtencion});
            }

            return View(disponibilidad);
        }


        // GET: MotivoAtencion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MotivoAtencion/Edit/5
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

        // GET: MotivoAtencion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MotivoAtencion/Delete/5
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
