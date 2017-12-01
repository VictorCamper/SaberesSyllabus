using SaberesSyllabus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Base de datos
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace SaberesSyllabus.Models
{
    public class Evaluacion
    {
        public EnumTipoEvaluacion tipo { get; set; }
        public List<Saber> saberes { get; set; }

        public Evaluacion()
        {
            this.saberes = new List<Saber>();
        }

        /*public bool Crear()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["algo va aqui"].ConnectionString))
            {
                conn.Open();
                var sqlTran = conn.BeginTransaction();
                try
                {
                    var command = new MySqlCommand()
                    {
                        CommandText = "crearSucursal",
                        CommandType = CommandType.StoredProcedure
                    };
                    //Setea el valor de los atributos del SP (procedimiento almacenado)
                    command.Parameters.AddWithValue("nombre", this.Nombre);
                    command.Parameters.AddWithValue("direccion", this.Direccion);
                    command.Parameters.AddWithValue("estado", this.Estado);
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
        }*/
    }
}