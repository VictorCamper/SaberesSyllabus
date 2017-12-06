using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SaberesySoluciones.Models;

namespace SaberesSyllabus.Models
{
    public class Evaluacion
    {
        public EnumTipoEvaluacion tipo { get; set; }
        public List<Saber> saberes { get; set; }

        public Evaluacion()
        {
            this.saberes = new List<Saber>();
        }
    }
}