using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SaberesySoluciones.Models;
using SaberesySoluciones.Repositories;
using SaberesSyllabus.Models;

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

                saber.codigo = Convert.ToInt32(datos.Parameters["out_id"].Value);
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
            var command = new MySqlCommand() { CommandText = "sp_saber_leertodo", CommandType = System.Data.CommandType.StoredProcedure };
            var datos = DataSource.GetDataSet(command);

            List<Saber> sabs = new List<Saber>();
            if (datos.Tables[0].Rows.Count > 0)
            {
                foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                {
                    var prodData = row;
                    var sab = new Saber()
                    {
                        codigo = Convert.ToInt32(prodData["codigo"]),
                        descripcion = prodData["descripcion"].ToString(),
                        nivelLogro = prodData["nivelLogro"].ToString(),
                        estado = prodData["estado"].ToString()
                    };
                    sabs.Add(sab);
                }
            }
            return sabs;
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }
            return null;

        }
    }
}