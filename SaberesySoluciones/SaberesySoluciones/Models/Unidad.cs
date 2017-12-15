using SaberesySoluciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Unidad
    {
        public string Titulo { get; set; }
        public List<Clase> Clases { get; set; }
        public List<Saber> Saberes { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public Unidad()
        {
            this.Clases = new List<Clase>();
            this.Saberes = new List<Saber>();
            this.Evaluaciones = new List<Evaluacion>();            
        }
    }
}

