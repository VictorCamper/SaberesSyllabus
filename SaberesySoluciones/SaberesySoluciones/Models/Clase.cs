using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Clase
    {
        public DateTime Fecha { get; set; }
        public TimeZone Horario { get; set; }
        public string Tema { get; set; }
        public string Descripcion { get; set; }
        public List<Saber> Saberes { get; set; }
        public EnumTipoClase Tipo { get; set; }

        public Clase()
        {
            this.Saberes = new List<Saber>();
        }
    }
}