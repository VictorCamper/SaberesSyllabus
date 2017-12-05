using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Competencia
    {
        public int codigo { get; set; }
        public string nombre { get; set;}
        public string descripcion { get; set; }
        public EnumNivelDominio dominio { get; set;}
        public string basico { get; set; }
        public string intermedio { get; set; }
        public string avanzado { get; set; }
        public string tiempoDesarrollo { get; set; }
        public List<Aprendizaje> aprendizajes { get; set; }
        public EnumEstado estado { get; set; }
        public int porcentajeLogro { get; set; }

        public Competencia()
        {
            this.aprendizajes = new List<Aprendizaje>();
        }
    }
}