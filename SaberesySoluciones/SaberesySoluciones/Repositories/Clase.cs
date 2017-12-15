using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using SaberesySoluciones.Repositories;
using SaberesySoluciones.Models;
using System.Diagnostics;

namespace SaberesSyllabus.Repositories
{
    public class Clase
    {
        public static List<SaberesySoluciones.Models.Clase> LeerTodo()
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_clases_leertodo", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<SaberesySoluciones.Models.Clase> clases = new List<SaberesySoluciones.Models.Clase>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        Debug.WriteLine(row);
                        Console.Write(row);
                        var prodData = row;
                        Console.WriteLine(row);
                        var clase = new SaberesySoluciones.Models.Clase()
                        {
                            id = Convert.ToInt16(prodData["id"]),
                            fecha = Convert.ToDateTime(prodData["fecha"]),
                            descripcion = prodData["descripcion"].ToString()
                        };
                        clases.Add(clase);
                    }
                }
                return clases;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!!!!" + ex.ToString());
            }
            finally
            {

            }
            return null;
        }

    }
}