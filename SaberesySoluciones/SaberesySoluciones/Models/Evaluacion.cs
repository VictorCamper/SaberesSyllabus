using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Evaluacion
    {
        private EnumTipoEvaluacion tipo { get; set; }
        private List<Saber> saberes { get; set; }

        public Evaluacion()
        {
            this.saberes = new List<Saber>();
        }
    }
}