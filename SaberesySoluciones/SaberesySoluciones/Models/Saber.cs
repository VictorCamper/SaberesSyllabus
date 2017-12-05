using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Saber
    {
        public int CodigoSaber { get; set; }
        public int Codigo { get; set; }
        public String Descripcion { get; set; }
        public String Logro { get; set; }
        public String Estado { get; set; }
        public List<Saber> Saberes { get; set; }
    }

}