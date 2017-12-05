using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Clase
    {
        private DateTime fecha { get; set; }
        private TimeZone horario { get; set; }
        private string tema { get; set; }
        private string descripcion { get; set; }
        private List<Saber> saberes { get; set; }
        private EnumTipoClase tipo { get; set; }

        public Clase()
        {
            this.saberes = new List<Saber>();
        }
    }
}