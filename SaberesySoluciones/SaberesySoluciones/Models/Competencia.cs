using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Competencia
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public int nivel { get; set; }
        public List<Aprendizaje> aprendizajes { get; set; }

        public Competencia()
        {
            this.aprendizajes = new List<Aprendizaje>();
        }
    }
}