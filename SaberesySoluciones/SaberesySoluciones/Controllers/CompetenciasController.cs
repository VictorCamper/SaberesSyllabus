using SaberesySoluciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaberesySoluciones.Controllers
{
    public class CompetenciasController : Controller
    {
        List<Competencia> finalcompetencias = new List<Competencia>();
        // GET: Competencias
        public ActionResult Index()
        {
            finalcompetencias.Add(new Competencia() { Codigo = 1, Descripcion = "soy una descripción", Nivel = "Básico", Basico="soy basico", Intermedio="soy intermedio", Avanzado="soy avanzado", TiempoDesarrollo="pta, igual depende", Estado="Habilitado" });

            return View(finalcompetencias);
        }

        [HttpPost]
        public ActionResult Crear(Competencia competencia)
        {
            
            return RedirectToAction("Index", "Competencias");
        }

        public ActionResult Editar(Competencia competencia)
        {

            return RedirectToAction("Index", "Competencias");
        }

        [HttpPost]
        public ActionResult Deshabilitar(int codigo)
        {

            return RedirectToAction("Index", "Competencias");
        }

        [HttpPost]
        public ActionResult Habilitar(int codigo)
        {

            return RedirectToAction("Index", "Competencias");
        }
    }
}