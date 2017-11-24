using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Saber
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public EnumLogro logro { get; set; }
    }
}