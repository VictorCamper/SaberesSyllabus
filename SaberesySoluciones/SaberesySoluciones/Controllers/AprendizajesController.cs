using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaberesSyllabus.Models;
using SaberesSyllabus.Repositories;
using SaberesySoluciones.Models;
using SaberesySoluciones.ViewModel;

namespace SaberesySoluciones.Controllers
{
    public class AprendizajesController : Controller
    {
        // GET: Aprendizajes
        public ActionResult Index()
        {
            List<Aprendizaje> aprendizajes = Aprendizajes.LeerTodo();

            if (aprendizajes == null)
            {
                aprendizajes = new List<Aprendizaje>();
            }

            return View(aprendizajes);
        }

        [HttpPost]
        public ActionResult Crear(Aprendizaje aprendizaje)
        {
            aprendizaje = Aprendizajes.Crear(aprendizaje);
            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult Editar(Aprendizaje aprendizaje)
        {
            Boolean result = Aprendizajes.Editar(aprendizaje);
            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult Deshabilitar(Aprendizaje aprendizaje)
        {
            Boolean resultadoConsulta = Aprendizajes.Deshabilitar(aprendizaje.Codigo);

            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult Habilitar(Aprendizaje aprendizaje)
        {
            Boolean resultadoConsulta = Aprendizajes.Habilitar(aprendizaje.Codigo);
            return RedirectToAction("Index", "Aprendizajes");
        }
    }
}
