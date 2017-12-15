﻿using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Aprendizaje
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public List<Saber> Saberes { get; set; }
        public EnumEstado Estado { get; set;}
        public int PorcentajeLogro { get; set;}

        public Aprendizaje()
        {
            this.Saberes = new List<Saber>();
        }
    }
}