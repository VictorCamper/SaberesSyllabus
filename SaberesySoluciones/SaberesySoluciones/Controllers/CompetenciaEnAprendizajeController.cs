using SaberesSyllabus.Models;
using SaberesySoluciones.Models;
using SaberesySoluciones.ViewModel;
using SaberesySoluciones.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaberesySoluciones.Controllers
{
    public class CompetenciaEnAprendizajeController : Controller
    {
        // GET: CompetenciaEnAprendizaje
        public ActionResult Index()
        {
            CompetenciaEnAprendizajesController competenciaAprendizaje = new CompetenciaEnAprendizajesController();
            return View(competenciaAprendizaje);
        }

        [HttpPost]
        public ActionResult CargarAprendizajes(String codigo)
        {

            return RedirectToAction("Index", "CompetenciaEnAprendizajeController ");
        }
    }
}