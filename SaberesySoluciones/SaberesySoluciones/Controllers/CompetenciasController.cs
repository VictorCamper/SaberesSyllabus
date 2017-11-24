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
        List<Competencia> finalcompetencias;
        // GET: Competencias
        public ActionResult Index()
        {
            finalcompetencias = new List<Competencia>();
            finalcompetencias.Add(new Competencia() { codigo = 1, descripcion = "soy una descripción", nivel=1});

            return View(finalcompetencias);
        }
    }
}