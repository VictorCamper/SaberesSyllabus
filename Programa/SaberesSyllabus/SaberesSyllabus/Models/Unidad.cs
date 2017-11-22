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
    }
}