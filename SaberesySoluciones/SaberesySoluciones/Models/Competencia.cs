using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Competencia
    {
        private int codigo { get; set; }
        private string nombre { get; set;}
        private string descripcion { get; set; }
        private EnumNivelDominio dominio { get; set;}
        private string basico { get; set; }
        private string intermedio { get; set; }
        private string avanzado { get; set; }
        private string tiempoDesarrollo { get; set; }
        private List<Aprendizaje> aprendizajes { get; set; }
        private EnumEstado estado { get; set; }
        private int porcentajeLogro { get; set; }

        public Competencia()
        {
            this.aprendizajes = new List<Aprendizaje>();
        }
    }
}