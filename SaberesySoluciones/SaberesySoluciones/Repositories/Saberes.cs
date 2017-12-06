using MySql.Data.MySqlClient;
using SaberesySoluciones.Models;
using SaberesySoluciones.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesSyllabus.Repositories
{
    public class Saberes
    {
        public static Saber Crear(Saber saber)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_saber_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigo", Direction = System.Data.ParameterDirection.Input, Value = saber.codigo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_descripcion", Direction = System.Data.ParameterDirection.Input, Value = saber.descripcion });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_nivelLogro", Direction = System.Data.ParameterDirection.Input, Value = saber.nivelLogro });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = saber.Estado });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "out_codigo", Direction = System.Data.ParameterDirection.Output, Value = -1 });
                var datos = DataSource.ExecuteProcedure(command);

                saber.Codigo = Convert.ToInt32(datos.Parameters["out_id"].Value);
                return saber;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static bool Editar(Saber saber)
        {
            return false;
        }

        public static bool Eliminar(Saber saber)
        {
            return false;
        }

        public static Saber Leer(int codigo)
        {
            return null;
        }

        public static List<Saber> LeerTodo()
        {
            var saberes = new List<Saber>();
            try
            {
                var ds = new DataSet();
                using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["Syllabus"].ConnectionString))
                {
                    var command = new MySqlCommand() { CommandText = "getSaberes", CommandType = CommandType.StoredProcedure };
                    conn.Open();
                    command.Connection = conn;
                    var sqlda = new MySqlDataAdapter(command);
                    sqlda.Fill(ds);
                    conn.Close();
                }
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Saber s = new Saber();
                    s.CargarDatos(dr);
                    saberes.Add(s);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return saberes;
        }
    }
}