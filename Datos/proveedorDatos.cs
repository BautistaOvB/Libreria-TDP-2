using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Gestion_Libreria.Datos
{
    public class ProveedorDatos
    {
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=Punto_Barra_tdp;Integrated Security=True;";

        // ✅ 1. INSERTAR
        public bool Agregar(Proveedor prov)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // ⚠️ OJO: Acá van los nombres TAL CUAL están en tu base de datos SQL
                    string query = @"INSERT INTO proveedores (cuit, nombre, razon_social, direccion, telefono, mail) 
                                    VALUES (@cuit, @nom, @razon, @dir, @tel, @mail)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@cuit", prov.cuit);
                        comando.Parameters.AddWithValue("@nom", prov.nombre);
                        comando.Parameters.AddWithValue("@razon", prov.razon_social);
                        comando.Parameters.AddWithValue("@dir", prov.direccion);
                        comando.Parameters.AddWithValue("@tel", prov.telefono);

                        // Validamos si el mail viene vacío para guardar un NULL en SQL
                        comando.Parameters.AddWithValue("@mail", string.IsNullOrWhiteSpace(prov.mail) ? (object)DBNull.Value : prov.mail);

                        int filas = comando.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si hay un error de SQL (ej: columna no existe), saltará acá
                throw new Exception("Error al insertar proveedor: " + ex.Message);
            }
        }

        // ✅ 2. OBTENER TODOS (Para la grilla)
        public List<Proveedor> ObtenerTodos()
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT id_proveedor, cuit, nombre, razon_social, direccion, telefono, mail 
                                    FROM proveedores 
                                    ORDER BY id_proveedor";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Proveedor
                                {
                                    id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                                    cuit = reader["cuit"].ToString(),
                                    nombre = reader["nombre"].ToString(),
                                    razon_social = reader["razon_social"].ToString(),
                                    direccion = reader["direccion"].ToString(),
                                    telefono = reader["telefono"].ToString(),
                                    mail = reader["mail"] == DBNull.Value ? "" : reader["mail"].ToString()
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

        // ✅ 3. ACTUALIZAR
        public bool Actualizar(Proveedor prov)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"UPDATE proveedores 
                             SET cuit = @cuit, 
                                 nombre = @nom, 
                                 razon_social = @razon, 
                                 direccion = @dir, 
                                 telefono = @tel, 
                                 mail = @mail
                             WHERE id_proveedor = @id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", prov.id_proveedor);
                        comando.Parameters.AddWithValue("@cuit", prov.cuit);
                        comando.Parameters.AddWithValue("@nom", prov.nombre);
                        comando.Parameters.AddWithValue("@razon", prov.razon_social);
                        comando.Parameters.AddWithValue("@dir", prov.direccion);
                        comando.Parameters.AddWithValue("@tel", prov.telefono);
                        comando.Parameters.AddWithValue("@mail", string.IsNullOrWhiteSpace(prov.mail) ? (object)DBNull.Value : prov.mail);

                        int filas = comando.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar proveedor: " + ex.Message);
            }
        }

        public List<Proveedor> Buscar(string filtro)
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT id_proveedor, cuit, nombre, razon_social, direccion, telefono, mail 
                             FROM proveedores 
                             WHERE cuit LIKE @filtro 
                                OR nombre LIKE @filtro 
                                OR razon_social LIKE @filtro
                             ORDER BY nombre";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Proveedor
                                {
                                    id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                                    cuit = reader["cuit"].ToString(),
                                    nombre = reader["nombre"].ToString(),
                                    razon_social = reader["razon_social"].ToString(),
                                    direccion = reader["direccion"].ToString(),
                                    telefono = reader["telefono"].ToString(),
                                    mail = reader["mail"] == DBNull.Value ? "" : reader["mail"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar proveedores: " + ex.Message);
            }

            return lista;
        }

    }
}