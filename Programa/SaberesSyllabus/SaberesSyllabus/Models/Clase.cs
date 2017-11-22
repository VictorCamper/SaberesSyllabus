using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Clase
    {
        public DateTime fecha { get; set;}
        public TimeZone horario { get; set; }
        public string tema { get; set; }
        public string descripcion { get; set; }
        public List<Saber> saberes { get; set; }
        public EnumTipoClase tipo { get; set; }
    }
}