using MySql.Data.MySqlClient;
using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Models
{
    public class Clase
    {
        public long codigo { get; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha { get; set; }
        public string horario { get; set; }
        public string tema { get; set; }
        public string descripcion { get; set; }
        public List<Saber> saberes { get; set; }
        public TipoClase tipo { get; set; }

        public Clase()
        {
            this.saberes = new List<Saber>();
        }

        public bool Crear()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["Syllabus"].ConnectionString))
            {
                conn.Open();
                var sqlTran = conn.BeginTransaction();
                try
                {
                    var command = new MySqlCommand() { CommandText = "crearClase", CommandType = CommandType.StoredProcedure };
                    //Setea el valor de los atributos del SP (procedimiento almacenado)
                    command.Parameters.AddWithValue("fecha", this.fecha);
                    command.Parameters.AddWithValue("tema", this.tema);
                    command.Parameters.AddWithValue("descripcion", this.descripcion);
                    command.Connection = conn;
                    command.Transaction = sqlTran;
                    command.ExecuteNonQuery();
                    sqlTran.Commit();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    sqlTran.Rollback();
                }
            }
            return true;
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
            //this.horario = String.Concat(dr["horaInicio"].ToString(), " - ", dr["horaTermino"]);
            this.tema = dr["tema"].ToString();
            this.descripcion = dr["descripcion"].ToString();
            //this.tipo = (TipoClase)Convert.ToInt32(dr["tipoClase"].ToString());

        }

        public void Seleccionar(long id)
        {
            try
            {
                var ds = new DataSet();
                using (var conn = new
                MySqlConnection(ConfigurationManager.ConnectionStrings["Syllabus"].ConnectionString))
                {
                    var command = new MySqlCommand()
                    {
                        CommandText = "getClaseID",
                        CommandType =
                    CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("id", this.codigo);
                    conn.Open();
                    command.Connection = conn;
                    var sqlda = new MySqlDataAdapter(command);
                    sqlda.Fill(ds);
                    conn.Close();
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.CargarDatos(ds.Tables[0].Rows[0]);
                }
                else
                {
                    /*
                    this.Nombre = "Not Found";
                    this.Direccion = "Not Found";
                    this.Estado = "Not Found";
                    this.Id = -1;
                    */
                }
            }
            catch (Exception ex)
            {
                //notificar administrador
                throw ex;
            }
        }
    

        public void EliminarSucursal(long codigo)
        {
            try
            {
                using (var conn = new
                MySqlConnection(ConfigurationManager.ConnectionStrings["Syllabus"].ConnectionString))
                {
                    var command = new MySqlCommand()
                    {
                        CommandText = "eliminarClase",
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("id", this.codigo);
                    command.Connection = conn;
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                //notificar administrador
                throw ex;
            }
        }


    }

    public enum TipoClase
    {
        [Description("Clase")]
        Clase,
        [Description("Laboratorio")]
        Laboratorio,
        [Description("Ayudantia")]
        Ayudantia,
    }
}