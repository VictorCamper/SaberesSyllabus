using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SaberesySoluciones.Models;
using SaberesSyllabus.Models;
using SaberesySoluciones.Repositories;

namespace SaberesySoluciones.ViewModel
{
    public class SaberesLogrados
    {
        internal static List<Saber> LeerTodo()
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_saber_logrado_leertodo", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Saber> comps = new List<Saber>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;

                        Enum.TryParse(prodData["nivel_logro"].ToString(), out EnumLogro ELogro);
                        Enum.TryParse(prodData["estado"].ToString(), out EnumEstado EEstado);
                        var sabe = new Saber()
                        {
                            Codigo = Convert.ToString(prodData["codigo"]),
                            Descripcion = prodData["descripcion"].ToString(),
                            Logro = ELogro,
                            Estado = EEstado,
                            PorcentajeLogro = prodData["porcentajeLogro"].ToString()
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