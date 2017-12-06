using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SaberesySoluciones.Models;

namespace SaberesySoluciones.ViewModel
{
    public class AprendizajeEnSaber
    {
        public List<Aprendizaje> aprendizajes { get; set; }
        public List<Saber> saberes { get; set; }
    }
}