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
        int CodigoCompetencia = -1;

        public ActionResult Index()
        {
            CompetenciaEnAprendizajesController competenciaAprendizaje = new CompetenciaEnAprendizajesController();
            return View(competenciaAprendizaje);
        }

        [HttpPost]
        public ActionResult AgregarAprendizajeCompetencia(int Competencia, string Aprendizaje)
        {
            CompetenciaEnAprendizajesController competenciaAprendizajes = new CompetenciaEnAprendizajesController();

            return View("Index", competenciaAprendizajes);
        }

        [HttpPost]
        public ActionResult SeleccionarCompetencia(int Competencia) {
            CodigoCompetencia = Competencia;
            CompetenciaEnAprendizajesController competenciaAprendizaje = new CompetenciaEnAprendizajesController(Competencia);
            return View("Index",competenciaAprendizaje);
        }

        [HttpPost]
        public ActionResult AgregarAprendizajeCompetencia(string Aprendizaje)
        {

            CompetenciaEnAprendizajesController competenciaAprendizaje = new CompetenciaEnAprendizajesController(CodigoCompetencia,Aprendizaje);
            return View("Index", competenciaAprendizaje);
        }
    }


}