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
            finalcompetencias.Add(new Competencia() { codigo = 1, descripcion = "soy una descripción", nivel = 1 });

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
        public ActionResult Eliminar(int codigo)
        {

            return RedirectToAction("Index", "Competencias");
        }
    }
}