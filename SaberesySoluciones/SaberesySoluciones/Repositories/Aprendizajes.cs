using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using MySql.Data.MySqlClient;
using SaberesSyllabus.Models;
using SaberesySoluciones.Repositories;
using SaberesySoluciones.Models;

namespace SaberesSyllabus.Repositories
{
    public class Aprendizajes
    {
        public static Aprendizaje Crear(Aprendizaje aprendizaje, int subcategoria)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_crear", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_subcategoria", Direction = System.Data.ParameterDirection.Input, Value = subcategoria });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_descripcion", Direction = System.Data.ParameterDirection.Input, Value = aprendizaje.Descripcion });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_porcentajeLogro", Direction = System.Data.ParameterDirection.Input, Value = 0 });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_estado", Direction = System.Data.ParameterDirection.Input, Value = "Habilitado" });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "out_codigo", Direction = System.Data.ParameterDirection.Output, Value = -1 });
                var datos = DataSource.ExecuteProcedure(command);

                aprendizaje.Codigo = Convert.ToInt32(datos.Parameters["out_codigo"].Value);

                return aprendizaje;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static Categoria CrearCategoria(Categoria categoria)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_crearcategoria", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_categoria", Direction = System.Data.ParameterDirection.Input, Value = categoria.Nombre });
                DataSource.ExecuteProcedure(command);

                return categoria;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static Subcategoria CrearSubcategoria(Subcategoria subcategoria, string categoria)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_crearsubcategoria", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_subcategoria", Direction = System.Data.ParameterDirection.Input, Value = subcategoria.Nombre });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_categoria", Direction = System.Data.ParameterDirection.Input, Value = categoria });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "out_subcategoriaid", Direction = System.Data.ParameterDirection.Input, Value = -1 });
                var datos = DataSource.ExecuteProcedure(command);
                subcategoria.Id = Convert.ToInt32(datos.Parameters["out_subcategoriaid"].Value);

                return subcategoria;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static bool Editar(Aprendizaje aprendizaje, int subcategoria, int aprendizajeanterior)
        {
            Boolean estadoConsulta;
            int codigoAnterior;

            try
            {
                codigoAnterior = aprendizajeanterior;

                aprendizaje = Crear(aprendizaje, subcategoria);
                if (aprendizaje.Codigo != -1)
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

        public static bool EditarCategoria(Categoria categoria, string categoriaprev)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_editarcategoria", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_categoria", Direction = System.Data.ParameterDirection.Input, Value = categoria.Nombre });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_categoriaprev", Direction = System.Data.ParameterDirection.Input, Value = categoriaprev });
                DataSource.ExecuteProcedure(command);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool EditarSubcategoria(Subcategoria subcategoria, int subcategoriaid)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_editarsubcategoria", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_subcategoria", Direction = System.Data.ParameterDirection.Input, Value = subcategoria.Nombre });
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_subcategoriaid", Direction = System.Data.ParameterDirection.Input, Value = subcategoriaid });
                DataSource.ExecuteProcedure(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool Habilitar(int codigo)
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

        public static bool Deshabilitar(int codigo)
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

        public static List<Categoria> LeerCategorias()
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_leercategorias", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Categoria> categorias = new List<Categoria>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var categoria = new Categoria()
                        {
                            Nombre = Convert.ToString(prodData["categoria"]),
                            Subcategorias = new List<Subcategoria>()
                        };
                        categorias.Add(categoria);
                    }
                }
                return categorias;
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

        public static List<Subcategoria> LeerSubCategorias(string categoria)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_leersubcategorias", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_categoria", Direction = System.Data.ParameterDirection.Input, Value = categoria });
                var datos = DataSource.GetDataSet(command);

                List<Subcategoria> subcategorias = new List<Subcategoria>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        var subcategoria = new Subcategoria()
                        {
                            Id = Convert.ToInt32(prodData["id"]),
                            Nombre = Convert.ToString(prodData["subCategoria"]),
                            Codigo = Convert.ToInt32(prodData["codigo"]),
                            Aprendizajes = new List<Aprendizaje>()
                        };
                        subcategorias.Add(subcategoria);
                    }
                }
                return subcategorias;
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


        public static List<Aprendizaje> LeerAprendizajes(int subcategoria)
        {
            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_leeraprendizajes", CommandType = System.Data.CommandType.StoredProcedure };
                command.Parameters.Add(new MySqlParameter() { ParameterName = "in_subcategoria", Direction = System.Data.ParameterDirection.Input, Value = subcategoria });
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
                            Codigo = Convert.ToInt32(prodData["codigo"]),
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

        public static List<Aprendizaje> LeerHabilitados() {

            try
            {
                var command = new MySqlCommand() { CommandText = "sp_aprendizajes_leerHabilitados", CommandType = System.Data.CommandType.StoredProcedure };
                var datos = DataSource.GetDataSet(command);

                List<Aprendizaje> apr = new List<Aprendizaje>();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in datos.Tables[0].Rows)
                    {
                        var prodData = row;
                        Enum.TryParse("Habilitado", out EnumEstado EEstado);
                        var appr = new Aprendizaje()
                        {
                            Codigo = Convert.ToInt32(prodData["codigo"]),
                            Descripcion = prodData["descripcion"].ToString(),
                            PorcentajeLogro = Convert.ToInt32(prodData["porcentajeLogro"]),
                            Estado = EEstado
                        };

                        apr.Add(appr);
                    }
                }
                return apr;
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