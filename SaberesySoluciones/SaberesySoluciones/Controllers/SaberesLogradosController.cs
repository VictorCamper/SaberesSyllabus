using SaberesySoluciones.Models;
using SaberesSyllabus.Models;
using SaberesySoluciones.Repositories;
using SaberesySoluciones.ViewModel;
using SaberesSyllabus.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaberesySoluciones.Controllers
{
    public class SaberesLogradosController : Controller
    {
        // GET: SaberesLogrados
        public ActionResult Index()
        {
            SaberesLogrados finalsaberes = new SaberesLogrados();
            finalsaberes.aprendizajes = Aprendizajes.LeerTodo();
            if (finalsaberes.aprendizajes == null)
            {
                finalsaberes.aprendizajes = new List<Aprendizaje>();
            }

            finalsaberes.saberes = Saberes.LeerTodo();
            if (finalsaberes.saberes == null)
            {
                finalsaberes.saberes = new List<Saber>();
            }

            finalsaberes.competencias = Competencias.LeerTodo();
            if (finalsaberes.competencias == null)
            {
                finalsaberes.competencias= new List<Competencia>();
            }

            finalsaberes.resultados = SaberesLogrados.LeerTodo();
            if(finalsaberes.resultados == null)
            {
                finalsaberes.resultados = new List<String>();
            }

            return View(finalsaberes);

            /*List<String> finalsaberes= SaberesLogrados.LeerTodo();
            if (finalsaberes == null)
            {
                finalsaberes = new List<String>();
            }

            return View(finalsaberes);*/
        }

        // GET: SaberesLogrados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaberesLogrados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaberesLogrados/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SaberesLogrados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaberesLogrados/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SaberesLogrados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaberesLogrados/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
