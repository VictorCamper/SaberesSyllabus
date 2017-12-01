using MySql.Data.MySqlClient;
using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Clase
    {
        public DateTime fecha { get; set; }
        public string horario { get; set; }
        public string tema { get; set; }
        public string descripcion { get; set; }
        public List<Saber> saberes { get; set; }
        public EnumTipoClase tipo { get; set; }

        public Clase()
        {
            this.saberes = new List<Saber>();
        }

        public List<Clase> ListarClases()
        {
            var clases = new List<Clase>();
            try
            {
                var ds = new System.Data.DataSet();
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["Syllabus"].ConnectionString))
                {
                    var command = new MySqlCommand()
                    {
                        CommandText = "getClases",
                        CommandType = CommandType.StoredProcedure
                    };
                    conn.Open();
                    command.Connection = conn;
                    var sqlda = new MySqlDataAdapter(command);
                    sqlda.Fill(ds);
                    conn.Close();
                }
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Clase c = new Clase();
                    c.CargarDatos(dr);
                    clases.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return clases;
        }

        public void CargarDatos(DataRow dr)
        {
            this.fecha = (DateTime)dr["fecha"];
            //this.horario = dr["nombre"].ToString();
            this.horario = String.Concat(dr["horaInicio"].ToString(), " - ", dr["horaTermino"]);
            this.tema = dr["tema"].ToString();
            this.descripcion = dr["descripcion"].ToString();
        }
    }
}