using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Evaluacion
    {
        public EnumTipoEvaluacion Tipo { get; set; }
        public List<Saber> Saberes { get; set; }

        public Evaluacion()
        {
            this.Saberes = new List<Saber>();
        }
    }
}