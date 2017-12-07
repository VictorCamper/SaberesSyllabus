using SaberesSyllabus.Models;
using SaberesySoluciones.Models;
using SaberesySoluciones.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaberesySoluciones.Controllers
{
    public class AprendizajeEnSaberController : Controller
    {
        // GET: AprendizajeEnSaber
        public ActionResult Index()
        {
            AprendizajeEnSaberesController aprendizajeSaber = new AprendizajeEnSaberesController();

            return View(aprendizajeSaber);
        }

        [HttpPost]
        public ActionResult CargarSaberes(String codigo)
        {

            return RedirectToAction("Index", "AprendizajeEnSaberController");
        }
    }
}