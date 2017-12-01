using SaberesySoluciones.Models;
using SaberesySoluciones.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaberesySoluciones.Controllers
{
    public class CompetenciasController : Controller
    {
        
        // GET: Competencias
        public ActionResult Index()
        {
            List<Competencia> finalcompetencias = Competencias.LeerTodo();
            if (finalcompetencias == null)
            {
                finalcompetencias = new List<Competencia>();
            }

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