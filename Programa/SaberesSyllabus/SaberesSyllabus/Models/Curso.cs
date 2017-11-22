using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Models
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
    }
}