using SaberesSyllabus.Models;
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
    public class SaberesLogradosController : Controller
    {
        // GET: SaberesLogrados
        public ActionResult Index()
        {
            List<Saber> finalsaberes= SaberesLogrados.LeerTodo();
            if (finalsaberes == null)
            {
                finalsaberes = new List<Saber>();
            }

            return View(finalsaberes);
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
