using System;
using System.Collections.Generic;
using SaberesySoluciones.Repositories;
using System.Linq;
using System.Web;
using SaberesySoluciones.Models;
using SaberesSyllabus.Models;
using SaberesSyllabus.Repositories;

namespace SaberesySoluciones.ViewModel
{
    public class CompetenciaEnAprendizajesController    
    {
        public List<Competencia> ListaCompetencias { get; set; }
        public List<Aprendizaje> ListaAprendizajes { get; set; }
        public List<Aprendizaje> ListaAprendizajeDeCompentencia { get; set; }

        public CompetenciaEnAprendizajesController()
        {
            this.ListaCompetencias = new List<Competencia>();
            this.ListaAprendizajes = new List<Aprendizaje>();
            this.ListaAprendizajeDeCompentencia = new List<Aprendizaje>();
            ListaCompetencias = Competencias.LeerTodo();
            ListaAprendizajes = Aprendizajes.LeerHabilitados();
            
        }

        public CompetenciaEnAprendizajesController(int Codigo)
        {
            this.ListaCompetencias = new List<Competencia>();
            this.ListaAprendizajes = new List<Aprendizaje>();
            this.ListaAprendizajeDeCompentencia = new List<Aprendizaje>();
            ListaCompetencias = Competencias.LeerTodo();
            ListaAprendizajes = Aprendizajes.LeerHabilitados();
            this.ListaAprendizajeDeCompentencia = Aprendizajes.LeerAprendizajesDeCompetencia(Codigo);
        }

        

    }
}