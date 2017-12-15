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
            List<Categoria> categorias = Aprendizajes.LeerCategorias();
            if (categorias == null)
            {
                categorias = new List<Categoria>();
            }
            foreach (Categoria cat in categorias)
            {
                cat.Subcategorias = Aprendizajes.LeerSubCategorias(cat.Nombre);
                
                //Ordenar las subcategorias según el codigo para evitar que se vean desordenadas :)
                cat.Subcategorias.Sort((x,y)=>x.Codigo.CompareTo(y.Codigo));

                if (cat.Subcategorias == null)
                {
                    cat.Subcategorias = new List<Subcategoria>();
                }
                foreach (Subcategoria subcat in cat.Subcategorias)
                {
                    subcat.Aprendizajes = Aprendizajes.LeerAprendizajes(subcat.Id);
                    if (subcat.Aprendizajes == null)
                    {
                        subcat.Aprendizajes = new List<Aprendizaje>();
                    }
                }
            }
            
            

            return View(categorias);
        }

        [HttpPost]
        public ActionResult CrearAprendizaje(Aprendizaje aprendizaje, int subcategoria)
        {
            aprendizaje = Aprendizajes.Crear(aprendizaje, subcategoria);
            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult CrearSubcategoria(Subcategoria subcategoria, string categoria)
        {
            subcategoria = Aprendizajes.CrearSubcategoria(subcategoria, categoria);
            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult CrearCategoria(Categoria categoria)
        {
            categoria = Aprendizajes.CrearCategoria(categoria);
            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult EditarAprendizaje(Aprendizaje aprendizaje, int subcategoria, int aprendizajeanterior)
        {
            Boolean result = Aprendizajes.Editar(aprendizaje, subcategoria, aprendizajeanterior);
            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult EditarCategoria(Categoria categoria, string categoriaprev)
        {
            Boolean result = Aprendizajes.EditarCategoria(categoria, categoriaprev);
            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult EditarSubcategoria(Subcategoria subcategoria, int subcategoriaprev)
        {
            Boolean result = Aprendizajes.EditarSubcategoria(subcategoria, subcategoriaprev);
            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult Deshabilitar(Aprendizaje aprendizaje)
        {
            Boolean resultadoConsulta = Aprendizajes.Deshabilitar(aprendizaje.Codigo);
            return RedirectToAction("Index", "Aprendizajes");
        }

        [HttpPost]
        public ActionResult Habilitar(Aprendizaje aprendizaje)
        {
            Boolean resultadoConsulta = Aprendizajes.Habilitar(aprendizaje.Codigo);
            return RedirectToAction("Index", "Aprendizajes");
        }

        public JsonResult GetListSubcategorias(string selection)
        {
            List<Categoria> categorias = Aprendizajes.LeerCategorias();
            List<Subcategoria> list = new List<Subcategoria>();
            foreach (Categoria categoria in categorias)
            {
                if (categoria.Nombre == selection)
                {
                    list = Aprendizajes.LeerSubCategorias(categoria.Nombre);
                    break;
                }
            }
            return Json(list, JsonRequestBehavior.AllowGet);

        }
    }
}
