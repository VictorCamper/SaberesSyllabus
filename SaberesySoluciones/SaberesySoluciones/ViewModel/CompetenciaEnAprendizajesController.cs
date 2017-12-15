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
        public Competencia CompetenciaSeleccionada { get; set; }


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
            this.CompetenciaSeleccionada = Competencias.LeerUna(Codigo);
            this.ListaCompetencias = new List<Competencia>();
            this.ListaAprendizajes = new List<Aprendizaje>();
            this.ListaAprendizajeDeCompentencia = new List<Aprendizaje>();
            ListaCompetencias = Competencias.LeerTodo();
            ListaAprendizajes = Aprendizajes.LeerHabilitados();
            this.ListaAprendizajeDeCompentencia = Aprendizajes.LeerAprendizajesDeCompetencia(Codigo);
        }

        public CompetenciaEnAprendizajesController(int CodigoCompetencia, string CodigoAprendizaje)
        {

            this.ListaCompetencias = new List<Competencia>();
            this.ListaAprendizajes = new List<Aprendizaje>();
            this.ListaAprendizajeDeCompentencia = new List<Aprendizaje>();
            bool consulta = Aprendizajes.CrearCompetenciaAprendizaje(CodigoCompetencia, CodigoAprendizaje);
            if(consulta)
            {
                ListaCompetencias = Competencias.LeerTodo();
                ListaAprendizajes = Aprendizajes.LeerHabilitados();
                this.ListaAprendizajeDeCompentencia = Aprendizajes.LeerAprendizajesDeCompetencia(CodigoCompetencia);
            }
        }

        

    }
}