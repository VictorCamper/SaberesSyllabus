using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Encargado
    {
        public string nombre { get; set; }
        public string rut { get; set; }
        public EnumCargo cargo { get; set; }
    }
}