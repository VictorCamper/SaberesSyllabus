using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaberesSyllabus.Models;
using SaberesSyllabus.Repositories;
using SaberesySoluciones.Models;
using SaberesySoluciones.ViewModel;

namespace SaberesySoluciones.Controllers
{
    public class AprendizajesController : Controller
    {
        // GET: Aprendizajes
        public ActionResult Index()
        {
            List<Aprendizaje> aprendizajes = Aprendizajes.LeerTodo();
            if (aprendizajes == null)
            {
                aprendizajes = new List<Aprendizaje>();
            }


            return View(aprendizajes);
        }
    }
}