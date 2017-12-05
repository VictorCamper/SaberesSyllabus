using SaberesySoluciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Unidad
    {
        private string titulo { get; set; }
        private List<Clase> clases { get; set; }
        private List<Saber> saberes { get; set; }
        private List<Evaluacion> evaluaciones { get; set; }

        public Unidad()
        {
            this.clases = new List<Clase>();
            this.saberes = new List<Saber>();
            this.evaluaciones = new List<Evaluacion>();            
        }
    }
}

