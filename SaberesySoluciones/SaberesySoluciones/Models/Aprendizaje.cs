using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Aprendizaje
    {
        public string codigo { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public List<Saber> saberes { get; set; }

        public Aprendizaje()
        {
            this.saberes = new List<Saber>();
        }
    }
}