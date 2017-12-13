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
        public long codigo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha { get; set; }
        public BloquesHoras horaInicio { get; set; }
        public BloquesHoras horaTermino { get; set; }
        public string horaInicioText { get; set; }
        public string horaTerminoText { get; set; }
        public string tema { get; set; }
        public string descripcion { get; set; }
        public List<Saber> saberes { get; set; }
        public TipoClase tipo { get; set; }
        public string tipoClase { get; set; }

        public Clase()
        {
            this.saberes = new List<Saber>();
            this.fecha = DateTime.Today;
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
                    command.Parameters.AddWithValue("horaInicio", this.horaInicio);
                    command.Parameters.AddWithValue("horaTermino", this.horaTermino);
                    command.Parameters.AddWithValue("tema", this.tema);
                    command.Parameters.AddWithValue("descripcion", this.descripcion);
                    command.Parameters.AddWithValue("tipoClase", this.tipo);
                    command.Connection = conn;
                    command.Transaction = sqlTran;
                    command.ExecuteNonQuery();
                    sqlTran.Commit();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                    //sqlTran.Rollback();
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
            this.horaInicioText = dr["horaInicio"].ToString();
            this.horaTerminoText = dr["horaTermino"].ToString();
            //this.horario = String.Concat(dr["horaInicio"].ToString(), " - ", dr["horaTermino"]);
            this.tema = dr["tema"].ToString();
            this.descripcion = dr["descripcion"].ToString();
            //this.tipo = (TipoClase)Convert.ToInt32(dr["tipoClase"].ToString());
            this.tipoClase = dr["tipoClase"].ToString();
            if (this.tipoClase.Equals("1"))
            {
                this.tipoClase = "Clase";
            }
            if (this.tipoClase.Equals("2"))
            {
                this.tipoClase = "Laboratorio";
            }
            if (this.tipoClase.Equals("3"))
            {
                this.tipoClase = "Ayudantia";
            }

            HorariosString();

            this.codigo = Convert.ToInt64(dr["codigo"].ToString());
        }

        public void HorariosString()
        {
            //horas
            if (this.horaInicioText.Equals("1"))
            {
                this.horaInicioText = "08:30:00";
            }
            if (this.horaTerminoText.Equals("1"))
            {
                this.horaTerminoText = "09:30:00";
            }
            if (this.horaInicioText.Equals("2"))
            {
                this.horaInicioText = "09:40:00";
            }
            if (this.horaTerminoText.Equals("2"))
            {
                this.horaTerminoText = "10:40:00";
            }
            if (this.horaInicioText.Equals("3"))
            {
                this.horaInicioText = "10:50:00";
            }
            if (this.horaTerminoText.Equals("3"))
            {
                this.horaTerminoText = "11:50:00";
            }
            if (this.horaInicioText.Equals("4"))
            {
                this.horaInicioText = "12:00:00";
            }
            if (this.horaTerminoText.Equals("4"))
            {
                this.horaTerminoText = "13:00:00";
            }
            if (this.horaInicioText.Equals("5"))
            {
                this.horaInicioText = "13:10:00";
            }
            if (this.horaTerminoText.Equals("5"))
            {
                this.horaTerminoText = "14:10:00";
            }
            if (this.horaInicioText.Equals("6"))
            {
                this.horaInicioText = "14:20:00";
            }
            if (this.horaTerminoText.Equals("6"))
            {
                this.horaTerminoText = "15:20:00";
            }
            if (this.horaInicioText.Equals("7"))
            {
                this.horaInicioText = "15:30:00";
            }
            if (this.horaTerminoText.Equals("7"))
            {
                this.horaTerminoText = "16:30:00";
            }
            if (this.horaInicioText.Equals("8"))
            {
                this.horaInicioText = "16:40:00";
            }
            if (this.horaTerminoText.Equals("8"))
            {
                this.horaTerminoText = "17:40:00";
            }
            if (this.horaInicioText.Equals("9"))
            {
                this.horaInicioText = "17:50:00";
            }
            if (this.horaTerminoText.Equals("1"))
            {
                this.horaTerminoText = "18:50:00";
            }
            if (this.horaInicioText.Equals("10"))
            {
                this.horaInicioText = "19:00:00";
            }
            if (this.horaTerminoText.Equals("10"))
            {
                this.horaTerminoText = "20:00:00";
            }
            if (this.horaInicioText.Equals("11"))
            {
                this.horaInicioText = "20:10:00";
            }
            if (this.horaTerminoText.Equals("11"))
            {
                this.horaTerminoText = "21:10:00";
            }

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
        //[Description("Clase")]
        //Clase,
        //[Description("Laboratorio")]
        //Laboratorio,
        //[Description("Ayudantia")]
        //Ayudantia,
        Clase=1,
        Laboratorio=2,
        Ayudantia=3

    }

    public enum BloquesHoras
    {
        Bloque1 = 1,
        Bloque2 = 2,
        Bloque3 = 3,
        Bloque4 = 4,
        Bloque5 = 5,
        Bloque6 = 6,
        Bloque7 = 7,
        Bloque8 = 8,
        Bloque9 = 9,
        Bloque10 = 10,
        Bloque11 = 11

    }
}