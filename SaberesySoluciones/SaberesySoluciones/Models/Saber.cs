using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Saber
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public EnumLogros logro { get; set; }
    }
}