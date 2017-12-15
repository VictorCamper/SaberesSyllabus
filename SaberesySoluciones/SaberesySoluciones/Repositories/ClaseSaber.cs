using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaberesySoluciones.Repositories
{
    public class ClaseSaber
    {
        public ClaseSaber()
        {

        }

        public void agregar(string idClase, string idSaber)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_claseSaber", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_idClase", Direction = System.Data.ParameterDirection.Input, Value = idClase });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_idSaber", Direction = System.Data.ParameterDirection.Input, Value = idSaber });
                DataSource.ExecuteProcedure(command);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        internal void quitar(string valor, string codigoSaber)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_claseSaberQuitar", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_idClase", Direction = System.Data.ParameterDirection.Input, Value = valor });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_idSaber", Direction = System.Data.ParameterDirection.Input, Value = codigoSaber });
                DataSource.ExecuteProcedure(command);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}