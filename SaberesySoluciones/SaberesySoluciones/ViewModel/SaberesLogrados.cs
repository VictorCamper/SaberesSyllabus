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
        public List<Aprendizaje> aprendizajes { get; set; }
        public List<Saber> saberes { get; set; }
        public List<Competencia> competencias { get; set; }
        public List<String> resultados { get; set; }

        public SaberesLogrados()
        {
            this.aprendizajes = new List<Aprendizaje>();
            this.saberes = new List<Saber>();
            this.competencias = new List<Competencia>();
        }

        public static List<String> LeerTodo()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("leeeeeeeer");


                //var commandS = new MySqlCommand() { CommandText = "sp_saber_logrado_leertodo", CommandType = System.Data.CommandType.StoredProcedure };
                //var datosS = DataSource.GetDataSet(commandS);

                //var commandA = new MySqlCommand() { CommandText = "sp_aprendizaje_logrado_leertodo", CommandType = System.Data.CommandType.StoredProcedure };
                //var datosA = DataSource.GetDataSet(commandA);

                //List<Competencia> c = Competencias.LeerTodo();
                var commandC = new MySqlCommand() { CommandText = "sp_competencias_leertodo", CommandType = System.Data.CommandType.StoredProcedure };
                var datosC = DataSource.GetDataSet(commandC);

                //System.Diagnostics.Debug.WriteLine("cdcdcd: " + c[0].Descripcion);

                List<String> componentes = new List<String>();

                if(datosC.Tables[0].Rows.Count > 0)
                {
                    System.Diagnostics.Debug.WriteLine("leeeeeeeer Competencias");

                    foreach (System.Data.DataRow row in datosC.Tables[0].Rows)
                    {
                        var prodData = row;
                        var competencia = new Competencia()
                        {
                            Codigo = Convert.ToInt32(prodData["codigo"]),
                            Nombre = prodData["nombre"].ToString(),
                            Descripcion = prodData["descripcion"].ToString(),
                            Dominio = prodData["dominio"].ToString(),
                            Basico = prodData["basico"].ToString(),
                            Intermedio = prodData["intermedio"].ToString(),
                            Avanzado = prodData["avanzado"].ToString(),
                            TiempoDesarrollo = prodData["tiempoDesarrollo"].ToString(),
                            Estado = prodData["estado"].ToString()
                        };

                        System.Diagnostics.Debug.WriteLine("codC: " + competencia.Codigo);


                        var commandA = new MySqlCommand() { CommandText = "sp_aprendizaje_logrado", CommandType = System.Data.CommandType.StoredProcedure };
                        commandA.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigo", Direction = System.Data.ParameterDirection.Input, Value = competencia.Codigo });
                        var datosA = DataSource.GetDataSet(commandA);

                        int nAprendizajes = 0;
                        List<int> porcentajesA = new List<int>();
                        System.Diagnostics.Debug.WriteLine("A");

                        if (datosA.Tables[0].Rows.Count > 0)
                        {
                            foreach (System.Data.DataRow rowA in datosA.Tables[0].Rows)
                            {
                                System.Diagnostics.Debug.WriteLine("leeeeeeeer aprendi");

                                var prodDataA = rowA;

                                Enum.TryParse(prodDataA["estado"].ToString(), out EnumEstado EEstado);
                                var aprendizaje = new Aprendizaje()
                                {
                                    Codigo = Convert.ToString(prodData["codigo"]),
                                    Categoria = prodData["categoria"].ToString(),
                                    SubCategoria = prodData["subCategoria"].ToString(),
                                    Descripcion = prodData["descripcion"].ToString(),
                                    PorcentajeLogro = Convert.ToInt32(prodData["porcentajeLogro"]),
                                    Estado = EEstado
                                };

                                //componentes.Add(aprendizaje);

                                var commandS = new MySqlCommand() { CommandText = "sp_saber_logrado_leertodo", CommandType = System.Data.CommandType.StoredProcedure };
                                commandA.Parameters.Add(new MySqlParameter() { ParameterName = "in_codigo", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.Codigo });
                                var datosS = DataSource.GetDataSet(commandA);

                                List<int> porcentajesS = new List<int>();

                                int nSaberes = 0;
                                List<Saber> saberes = new List<Saber>();
                                foreach (System.Data.DataRow rowS in datosS.Tables[0].Rows)
                                {
                                    System.Diagnostics.Debug.WriteLine("leeeeeeeer saberes");

                                    var prodDataS = rowS;

                                    Enum.TryParse(prodDataS["nivelLogro"].ToString(), out EnumLogro ELogro);
                                    Enum.TryParse(prodDataS["estado"].ToString(), out EnumEstado EEEstado);
                                    var saber = new Saber()
                                    {
                                        Codigo = Convert.ToString(prodData["codigo"]),
                                        Descripcion = prodData["descripcion"].ToString(),
                                        Logro = ELogro,
                                        Estado = EEEstado,
                                        PorcentajeLogro = prodData["porcentajeLogro"].ToString(),
                                        Id = Convert.ToInt32(prodData["id"])
                                    };

                                    porcentajesS.Add(Convert.ToInt32(saber.PorcentajeLogro));
                                    nSaberes++;

                                    //agregar saber a componentes
                                    componentes.Add("Saber");
                                    componentes.Add(saber.Codigo);
                                    componentes.Add(saber.Descripcion);
                                    componentes.Add(saber.PorcentajeLogro);

                                }
                                //calculo de porcentaje del aprendizaje actual
                                int porcentajeAprendizaje = calcularPorcentaje(porcentajesS);

                                porcentajesA.Add(aprendizaje.PorcentajeLogro);
                                nAprendizajes++;

                                //se agregan los aprendizajes a los componentes
                                componentes.Add("Aprendizaje");
                                componentes.Add(Convert.ToString(nSaberes));
                                componentes.Add(aprendizaje.Codigo);
                                componentes.Add(aprendizaje.Descripcion);
                                componentes.Add(Convert.ToString(porcentajeAprendizaje));

                            }
                        }

                        //calculo de porcentaje de la competencia actual
                        int porcentajeCompetencia = calcularPorcentaje(porcentajesA);

                        componentes.Add("Competencia");
                        componentes.Add(Convert.ToString(nAprendizajes));
                        componentes.Add(competencia.Nombre);
                        componentes.Add(competencia.Descripcion);
                        componentes.Add(Convert.ToString(porcentajeCompetencia));

                        //se agrega la competencia FALTA UPDATE BD!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1


                    }
                }

                /*
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

                        }
                        comps.Add(sabe);
                    }
                }
                return comps;*/
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

        /*private static string obtenerTipo(Competencia competencia)
        {
            String tipo;
            if (competencia.GetType() == typeof(Competencia))
            {
                tipo = "Competencia";
                return tipo;
            }
        }*/

        public static int calcularPorcentaje(List<int> porcentajes)
        {
            int resultado = 0;
            int tamano = 0;
            foreach (var item in porcentajes)
            {
                resultado += item;
                tamano++;
            }
            resultado = resultado / tamano;
            System.Diagnostics.Debug.WriteLine("resultado: " + resultado);
            Console.WriteLine("resultado: " + resultado);
            return resultado;
        }
    }
}