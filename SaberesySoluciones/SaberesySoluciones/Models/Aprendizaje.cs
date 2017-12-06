using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Aprendizaje
    {
        private int codigo { get; set; }
        private string categoria { get; set; }
        private string subCategoria { get; set; }
        private string descripcion { get; set; }
        private List<Saber> saberes { get; set; }
        private EnumEstado estado { get; set;}
        private int porcentajeLogro { get; set;}

        public Aprendizaje()
        {
            this.saberes = new List<Saber>();
        }
    }
}