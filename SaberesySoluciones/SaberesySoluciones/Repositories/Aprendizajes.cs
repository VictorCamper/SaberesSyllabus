using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using SaberesSyllabus.Models;
using SaberesySoluciones.Repositories;
using SaberesySoluciones.Models;

namespace SaberesSyllabus.Repositories
{
    public class Aprendizajes
    {
        public static Aprendizaje Crear(Aprendizaje aprendizaje)
        {
            try
            {
                Enum.TryParse("Habilitado", out EnumEstado EEstado);
                aprendizaje.Estado = EEstado;
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigo", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.Codigo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_categoria", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.Categoria });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_subCategoria", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.SubCategoria });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_descripcion", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.Descripcion });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_porcentajeLogro", Direction = System.Data.ParameterDirection.Input, Value = 0 });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.Estado.ToString() });
                DataSource.ExecuteProcedure(command);

                return aprendizaje;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static bool Editar(Aprendizaje aprendizaje)
        {
            return false;
        }

        public static bool Habilitar(string codigo)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_habilitar_deshabilitar", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigo", Direction = System.Data.ParameterDirection.Input, Value = codigo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = "Habilitado" });
                DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool Deshabilitar(string codigo)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_habilitar_deshabilitar", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigo", Direction = System.Data.ParameterDirection.Input, Value = codigo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = "Deshabilitado" });
                DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        public static List<Aprendizaje> LeerTodo()
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_leertodo", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Aprendizaje> aprendizajes = new List<Aprendizaje>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        Enum.TryParse(prodData["estado"].ToString(), out EnumEstado EEstado);
                        var aprendizaje = new Aprendizaje()
                        {
                            Codigo = Convert.ToString(prodData["codigo"]),
                            Categoria = prodData["categoria"].ToString(),
                            SubCategoria = prodData["subCategoria"].ToString(),
                            Descripcion = prodData["descripcion"].ToString(),
                            PorcentajeLogro = Convert.ToInt32(prodData["porcentajeLogro"]),
                            Estado = EEstado
                        };
                        aprendizajes.Add(aprendizaje);
                    }
                }
                return aprendizajes;
            }
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