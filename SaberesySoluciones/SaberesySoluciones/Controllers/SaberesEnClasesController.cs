using SaberesSyllabus.Models;
using SaberesySoluciones.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaberesySoluciones.Controllers
{
    public class SaberesEnClasesController : Controller
    {

        public Clase clase;
        public string id;

        // GET: SaberesEnClases
        public ActionResult Index(string valor)

        {
            
            SaberesySoluciones.ViewModel.SaberesEnClasesController aprendizajeSaber = new SaberesySoluciones.ViewModel.SaberesEnClasesController();

            aprendizajeSaber.clases = SaberesSyllabus.Repositories.Clase.LeerTodo();
            if (aprendizajeSaber.clases == null)
            {
                aprendizajeSaber.clases = new List<Clase>();
            }

            if (valor == "")
            {
                if (ViewBag.valor != null)
                {
                    valor = ViewBag.valor;
                }
                else {
                    valor = Convert.ToString(aprendizajeSaber.clases.First().id);
                }
            }

            ViewBag.valor = valor;

            aprendizajeSaber.saberesNo = Repositories.Saberes.leerNoRelacionadosClase(valor);
            if (aprendizajeSaber.saberesNo == null)
            {
                aprendizajeSaber.saberesNo = new List<Saber>();
            }
            aprendizajeSaber.saberDeClase = Repositories.Saberes.leerRelacionadosClase(valor);
            if (aprendizajeSaber.saberDeClase == null)
            {
                aprendizajeSaber.saberDeClase = new List<Saber>();
            }

            return View(aprendizajeSaber);
        }

        // GET: SaberesEnClases/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaberesEnClases/Create
        public ActionResult Create(string idClase)
        {
            SaberesySoluciones.ViewModel.SaberesEnClasesController aprendizajeSaber = new SaberesySoluciones.ViewModel.SaberesEnClasesController();


            aprendizajeSaber.saberesNo = Repositories.Saberes.leerNoRelacionadosClase(idClase);
            if (aprendizajeSaber.saberesNo == null)
            {
                aprendizajeSaber.saberesNo = new List<Saber>();
            }
            aprendizajeSaber.saberDeClase = Repositories.Saberes.leerRelacionadosClase(idClase);
            if (aprendizajeSaber.saberDeClase == null)
            {
                aprendizajeSaber.saberDeClase = new List<Saber>();
            }

            

            return View(aprendizajeSaber);
        }

        // POST: SaberesEnClases/Create
        [HttpPost]
        public void Agregar(string valor, string codigoSaber)
        {
            try
            {
                // TODO: Add insert logic here
                //Debug.WriteLine(this.id);
                SaberesySoluciones.ViewModel.SaberesEnClasesController aprendizajeSaber = new SaberesySoluciones.ViewModel.SaberesEnClasesController();
                SaberesySoluciones.Repositories.ClaseSaber cs = new SaberesySoluciones.Repositories.ClaseSaber();
                cs.agregar(valor, codigoSaber);
                
                //return Index(valor);
                //return RedirectToAction("Index", new { valor = valor2 });
            }
            catch
            {
                //return View();
            }
        }

        // POST: SaberesEnClases/Create
        [HttpPost]
        public void Quitar(string valor, string codigoSaber)
        {
            try
            {
                // TODO: Add insert logic here
                //Debug.WriteLine(this.id);
                SaberesySoluciones.ViewModel.SaberesEnClasesController aprendizajeSaber = new SaberesySoluciones.ViewModel.SaberesEnClasesController();
                SaberesySoluciones.Repositories.ClaseSaber cs = new SaberesySoluciones.Repositories.ClaseSaber();
                cs.quitar(valor, codigoSaber);
                //return Index(valor);
                //return RedirectToAction("Index", new { valor = valor2 });
            }
            catch
            {
                //return View();
            }
        }

        // POST: SaberesEnClases/Edit/5
        [HttpPost]
        public ActionResult Modificar(string valorSalida)
        {
            try
            {
                // TODO: Add update logic here
                if (valorSalida!=null)
                {
                    this.id = valorSalida;
                    ViewBag.Message = valorSalida;
                }
                return RedirectToAction("Index" , new { valor = valorSalida });
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // POST: SaberesEnClases/Delete/5
        public ActionResult Recargar()
        {
            return View();
        }

        // POST: SaberesEnClases/Delete/5
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
