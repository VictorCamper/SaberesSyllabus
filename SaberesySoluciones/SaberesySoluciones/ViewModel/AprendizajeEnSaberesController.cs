using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SaberesySoluciones.Models;
using SaberesSyllabus.Models;

namespace SaberesySoluciones.ViewModel
{
    public class AprendizajeEnSaberesController
    {
        public List<Aprendizaje> aprendizajes { get; set; }
        public List<Saber> saberes { get; set; }
        public List<Saber> saberDeAprendizaje { get; set; }

        public AprendizajeEnSaberesController()
        {
            this.aprendizajes = new List<Aprendizaje>();
            this.saberes = new List<Saber>();
            this.saberDeAprendizaje = new List<Saber>();
        }
    }
}