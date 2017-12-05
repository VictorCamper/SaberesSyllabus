using MySql.Data.MySqlClient;
using SaberesySoluciones.Models;
using SaberesySoluciones.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Repositories
{
    public class Saberes
    {
        public static Saber Crear(Saber saber)
        {
            try
            {
                saber.Estado = "Habilitado";
                var command = new MySqlCommand() { CommandText = "sp_saberes_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_descripcion", Direction = System.Data.ParameterDirection.Input, Value = saber.Descripcion });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_nivel_logro", Direction = System.Data.ParameterDirection.Input, Value = saber.Logro });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = saber.Estado });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "out_codigo", Direction = System.Data.ParameterDirection.Output, Value = -1 });
                var datos = DataSource.ExecuteProcedure(command);

                saber.Codigo = Convert.ToInt32(datos.Parameters["out_codigo"].Value);
                return saber;
            }            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static bool Deshabilitar(int codigo)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_saberes_habilitar_deshabilitar", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigo", Direction = System.Data.ParameterDirection.Input, Value = codigo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = "Deshabilitado" });
                var datos = DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {

            }
        }
    
    public static bool Habilitar(int codigo)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_saberes_habilitar_deshabilitar", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigo", Direction = System.Data.ParameterDirection.Input, Value = codigo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = "Habilitado" });
                var datos = DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {

            }
        }


        public static bool Editar(Saber saber)
        {
            Boolean estadoConsulta;
            int codigoAnterior;

            try
            {
                codigoAnterior = saber.Codigo;

                saber = Crear(saber);
                if (saber.Codigo != (-1))
                {
                    estadoConsulta = Deshabilitar(codigoAnterior);
                    if (estadoConsulta == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {

            }
        }
        public static List<Saber> LeerTodo()
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_saberes_leertodo", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Saber> comps = new List<Saber>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var sabe = new Saber()
                        {
                            Codigo = Convert.ToInt32(prodData["codigo"]),
                            Descripcion = prodData["descripcion"].ToString(),
                            Logro = prodData["nivel_logro"].ToString(),
                            Estado = prodData["estado"].ToString()
                        };
                        comps.Add(sabe);
                    }
                }
                return comps;
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