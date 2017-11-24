using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Curso
    {
        public string nombre { get; set; }
        public int horasPresenciales { get; set; }
        public int horasAutonomas { get; set; }
        public List<Unidad> unidades { get; set; }
        public List<Competencia> competencias { get; set; }
        public Encargado encargado { get; set; }
        public List<Alumno> alumnos { get; set; }

        public Curso()
        {
            this.unidades = new List<Unidad>();
            this.competencias = new List<Competencia>();
            this.alumnos = new List<Alumno>();
        }
    }
}