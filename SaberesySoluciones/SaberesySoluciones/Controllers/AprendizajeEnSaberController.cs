using SaberesSyllabus.Models;
using SaberesSyllabus.Repositories;
using SaberesySoluciones.Models;
using SaberesySoluciones.Repositories;
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
            aprendizajeSaber.aprendizajes = Aprendizajes.LeerHabilitados();
            if (aprendizajeSaber.aprendizajes == null)
            {
                aprendizajeSaber.aprendizajes = new List<Aprendizaje>();
            }
            aprendizajeSaber.saberes = Saberes.LeerHabilitado();
            if (aprendizajeSaber.saberes == null)
            {
                aprendizajeSaber.saberes = new List<Saber>();
            }

            return View(aprendizajeSaber);
        }

        [HttpPost]
        public ActionResult CargarSaberes(String codigo)
        {

            return RedirectToAction("Index", "AprendizajeEnSaberController");
        }
    }
}