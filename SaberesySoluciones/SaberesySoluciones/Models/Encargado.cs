using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Encargado
    {
        private string nombre { get; set; }
        private string rut { get; set; }
        private EnumCargo cargo { get; set; }
    }
}