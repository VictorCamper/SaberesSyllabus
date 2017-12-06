using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaberesSyllabus.Models;
using SaberesySoluciones.Models;
using SaberesySoluciones.ViewModel;

namespace SaberesySoluciones.Controllers
{
    public class AprendizajesController : Controller
    {
        // GET: Aprendizajes
        public ActionResult Index()
        {
           /* AprendizajesViewModel aprendizajes = new AprendizajesViewModel()
            {
                aprendizajes = new List<Aprendizaje>
                {
                    new Aprendizaje() {codigo = "AL", categoria = "Análisis Básico de Algoritmos", descripcion = "Conoce tiempo de ejecución de algoritmos", saberes = new List<Saber>()
                    {
                        new Saber(){codigo = "1.1", descripcion = "Conoce la diferencia entre el “peor”, “promedio” y “mejor” tiempo de ejecución de un algoritmo", logro = EnumLogros.Saber},
                        new Saber(){codigo = "1.7", descripcion = "Es capaz de dar ejemplos que ilustren la compensación que debe existir entre tiempo y espacio para los algoritmos", logro = EnumLogros.Saber}

                    }},
                    new Aprendizaje() {codigo = "AL", categoria = "Análisis Básico de Algoritmos", descripcion = "Realiza procedimientos básicos de análisis de algoritmos", saberes = new List<Saber>()
                    {
                        new Saber(){codigo = "1.4", descripcion = "Reproduce la definición formal de la notación O-grande", logro = EnumLogros.Saber},
                        new Saber(){codigo = "1.7", descripcion = "Lista y contrasta clases de complejidad estándar", logro = EnumLogros.Saber},
                        new Saber(){codigo = "1.3", descripcion = "Determina de manera informal la complejidad de tiempo y espacio de algoritmos simples", logro = EnumLogros.SaberHacer}

                    }}
                
            };*/
            
            return View(/*aprendizajes*/);
        }
    }
}