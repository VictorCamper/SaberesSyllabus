using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaberesySoluciones.Models;

namespace SaberesySoluciones.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult Index()
        {
            ViewBag.title = "Principal";
            var principal = new Principal();
            return View(principal);
        }

        [HttpGet]
        public ActionResult CrearPrincipal()
        {
            Principal principal = new Principal();
            return View(principal);
        }

        [HttpPost]
        public ActionResult CrearPrincipal(Principal nueva)
        {
            //nueva.Crear();
            return RedirectToAction("Index");

        }
    }
}