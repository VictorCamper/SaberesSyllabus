using SaberesySoluciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Unidad
    {
        public string titulo { get; set; }
        public List<Clase> clases { get; set; }
        public List<Saber> saberes { get; set; }
        public List<Evaluacion> evaluaciones { get; set; }

        public Unidad()
        {
            this.clases = new List<Clase>();
            this.saberes = new List<Saber>();
            this.evaluaciones = new List<Evaluacion>();            
        }
    }
}

