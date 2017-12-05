using SaberesySoluciones.Models;
using SaberesySoluciones.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaberesySoluciones.Controllers
{
    public class SaberesController : Controller
    {
        // GET: Saber
        public ActionResult Index()
        {
            List<Saber> finalSaber = Saberes.LeerTodo();
            if (finalSaber == null)
            {
                finalSaber = new List<Saber>();
            }

            return View(finalSaber);

        }


        [HttpPost]
        public ActionResult Crear(Saber saber)
        {
            saber = Saberes.Crear(saber);
            return RedirectToAction("Index", "Saberes");
        }

        public ActionResult Editar(Saber saber)
        {

            Boolean result = Saberes.Editar(saber);
            return RedirectToAction("Index", "Saberes");
        }

        [HttpPost]
        public ActionResult Deshabilitar(int codigo)
        {
            Boolean resultadoConsulta;
            resultadoConsulta = Saberes.Deshabilitar(codigo);

            return RedirectToAction("Index", "Saberes");
        }

        [HttpPost]
        public ActionResult Habilitar(int codigo)
        {
            Boolean resultadoConsulta;
            resultadoConsulta = Saberes.Habilitar(codigo);
            return RedirectToAction("Index", "Saberes");
        }
    }
}