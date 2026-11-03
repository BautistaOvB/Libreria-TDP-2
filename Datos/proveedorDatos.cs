using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Gestion_Libreria.Datos
{
    public class proveedorDatos
    {
        private string cadenaConexion = "Server=.;Database=Punto_Barra_tdp;Integrated Security=True;";
        public List<Proveedor> ObtenerTodos()
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT * FROM proveedores";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Proveedor
                                {
                                    idProveedor = Convert.ToInt32(reader["id_proveedor"]),
                                    Cuit = reader["cuit"].ToString(),
                                    nombre = reader["descripcion"].ToString(),
                                    Direccion = reader["direccion"].ToString(),
                                    telefono = reader["telfono"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener proveedores: " + ex.Message);
            }

            return lista;
        }

        public List<Proveedor> BuscarPorNombre(string filtro)
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT id_proveedor, cuit, descripcion,
                                    direccion, telefono
                             FROM proveedores
                             WHERE descripcion LIKE @filtro
                             ORDER BY descripcion";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Proveedor
                                {
                                    idProveedor = Convert.ToInt32(reader["id_proveedor"]),
                                    Cuit = reader["cuit"].ToString(),
                                    nombre = reader["descipcion"].ToString(),
                                    Direccion = reader["direccion"].ToString(),
                                    telefono = reader["telefono"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar proveedor: " + ex.Message);
            }

            return lista;
        }
        public void Agregar(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"INSERT INTO proveedores (cuit, descripcion, direccion, telefono)
                            VALUES (@cuit, @descripcion, @direccion, @telefono)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@cuit", proveedor.Cuit);
                        comando.Parameters.AddWithValue("@descripcion", proveedor.nombre);
                        comando.Parameters.AddWithValue("@stock", proveedor.Direccion);
                        comando.Parameters.AddWithValue("@precio", proveedor.telefono);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el proveedor: " + ex.Message);
            }
        }
        public void Modificar(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = @"UPDATE proveedores 
                            SET cuit = @cuit, descripcion = @decripcion, direccion = @direccion, 
                                telefono = @telefono 
                            WHERE id_proveedor = @id_proveedor";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_proveedor", proveedor.idProveedor);
                        comando.Parameters.AddWithValue("@cuit", proveedor.Cuit);
                        comando.Parameters.AddWithValue("@descripcion", proveedor.nombre);
                        comando.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                        comando.Parameters.AddWithValue("@telefono", proveedor.telefono);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el proveedor: " + ex.Message);
            }
        }
        public void Eliminar(int idProveedor)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "DELETE FROM proveedores WHERE id_proveedor = @id_proveedor";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_proveedor", idProveedor);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el proveedor: " + ex.Message);
            }
        }
    }
}
