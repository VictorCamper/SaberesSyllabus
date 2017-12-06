using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
{
    public class Saber
    {
        private string codigo { get; set; }
        private string descripcion { get; set; }
        private EnumLogro logro { get; set; }
        private EnumEstado estado { get; set; }
        private int porcentajeLogro { get; set; }
    }
}