using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Competencia
    {
        public int Codigo { get; set; }
        public String Descripcion { get; set; }
        public String Nivel { get; set; }
        public String Basico { get; set; }
        public String Intermedio { get; set; }
        public String Avanzado { get; set; }
        public String TiempoDesarrollo { get; set; }
        public String Estado { get; set; }
        public List<Aprendizaje> Aprendizajes { get; set; }

        public Competencia()
        {
            this.Aprendizajes = new List<Aprendizaje>();
        }
    }
}