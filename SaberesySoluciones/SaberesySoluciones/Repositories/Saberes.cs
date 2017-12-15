using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using SaberesySoluciones.Models;
using SaberesSyllabus.Models;
using SaberesySoluciones.Repositories;

namespace SaberesySoluciones.Repositories

{
    public class Saberes
    {
        
        public static List<Saber> leerRelacionadosClase(string codigoClase)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_saber_leerrelacion", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigoClase", Direction = System.Data.ParameterDirection.Input, Value = codigoClase });
                var datos = DataSource.GetDataSet(command);

                List<Saber> comps = new List<Saber>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;

                        Enum.TryParse(prodData["nivelLogro"].ToString(), out EnumLogro ELogro);
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
                return null;
            }
        }

        public static List<Saber> leerNoRelacionadosClase(string codigoClase)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_saber_leerNoRelacion", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigoClase", Direction = System.Data.ParameterDirection.Input, Value = codigoClase });
                var datos = DataSource.GetDataSet(command);

                List<Saber> comps = new List<Saber>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;

                        Enum.TryParse(prodData["nivelLogro"].ToString(), out EnumLogro ELogro);
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
                return null;
            }
        }
    }
}