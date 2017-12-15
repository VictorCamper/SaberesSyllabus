using SaberesSyllabus.Models;
using SaberesySoluciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaberesySoluciones.ViewModel
{ 
    public class SaberesEnClasesController
    {

        public Clase clase { get; set; }
        public List<Clase> clases { get; set; }
        public List<SaberesSyllabus.Models.Saber> saberesNo { get; set; }
        public List<SaberesSyllabus.Models.Saber> saberDeClase { get; set; }

        public SaberesEnClasesController()
        {
            this.clase = new SaberesySoluciones.Models.Clase();
            this.saberesNo = new List<SaberesSyllabus.Models.Saber>();
            this.saberDeClase = new List<Saber>();
            this.clases = new List<Clase>();
        }


    }
}