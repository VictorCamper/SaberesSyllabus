using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Curso
    {
        private string nombre { get; set; }
        private int horasPresenciales { get; set; }
        private int horasAutonomas { get; set; }
        private string descripcion { get; set; }
        private List<Unidad> unidades { get; set; }
        private List<Competencia> competencias { get; set; }
        private Encargado encargado { get; set; }
        private List<Alumno> alumnos { get; set; }
        private EnumEstado estado { get; set; }

        public Curso()
        {
            this.unidades = new List<Unidad>();
            this.competencias = new List<Competencia>();
            this.alumnos = new List<Alumno>();
        }
    }
}