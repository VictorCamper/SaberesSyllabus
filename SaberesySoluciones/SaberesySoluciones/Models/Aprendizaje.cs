using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Aprendizaje
    {
        public int codigo { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }
        public string descripcion { get; set; }
        public List<Saber> saberes { get; set; }
        public EnumEstado estado { get; set;}
        public int porcentajeLogro { get; set;}

        public Aprendizaje()
        {
            this.saberes = new List<Saber>();
        }
    }
}