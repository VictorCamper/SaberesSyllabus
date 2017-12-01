using SaberesySoluciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaberesySoluciones.Controllers
{
    public class ClasesController : Controller
    {
        // GET: Clases
        public ActionResult Index()
        {
            ViewBag.title = "Vista Clases";
            var clases = new Clase().ListarClases();
            return View(clases);
        }
    }
}