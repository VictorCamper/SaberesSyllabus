using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
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
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigo", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.Codigo });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_categoria", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.Categoria });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_descripcion", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.Descripcion });
                //command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigoCompetencia", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.codigoCompetencia });
                //command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.estado });
                var datos = DataSource.ExecuteProcedure(command);
                
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

        public static bool Habilitar(Aprendizaje aprendizaje)
        {
            return false;
        }

        public static bool Deshabilitar(Aprendizaje aprendizaje)
        {
            return false;
        }

        public static Aprendizaje Leer(string codigo)
        {
            return null;
        }

        public static List<Aprendizaje> LeerTodo()
        {
            return null;
        }
    }
}