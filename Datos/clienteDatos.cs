using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Libreria.Entidad;
using System.Data.SqlClient;

namespace Gestion_Libreria.Datos
{
    internal class ClienteDatos
    {
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=Punto_Barra_tdp;Integrated Security=True;";

        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT * FROM clientes";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Cliente
                                {
                                    id_cliente = Convert.ToInt32(reader["id_cliente"]),
                                    dni = reader["dni"].ToString(),
                                    nombre = reader["nombre"].ToString(),
                                    apellido = reader["apellido"].ToString(),
                                    mail = reader["mail"].ToString(),
                                    direccion = reader["direccion"].ToString(),
                                    numero_telefono = reader["numero_telefono"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }
            return lista;
        }

        public List<Cliente> BuscarPorDni(string dni)
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT id_cliente, dni, nombre, apellido,
                                            mail, direccion, numero_telefono
                                     FROM clientes
                                     WHERE dni LIKE @dni
                                     ORDER BY apellido, nombre";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@dni", "%" + dni + "%");

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                                lista.Add(MapearCliente(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar por DNI: " + ex.Message);
            }

            return lista;
        }
        public List<Cliente> BuscarPorApellido(string apellido)
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT id_cliente, dni, nombre, apellido,
                                            mail, direccion, numero_telefono
                                     FROM clientes
                                     WHERE apellido LIKE @apellido
                                     ORDER BY apellido, nombre";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@apellido", "%" + apellido + "%");

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                                lista.Add(MapearCliente(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar por apellido: " + ex.Message);
            }

            return lista;
        }

        // ============================================================
        // Insertar nuevo cliente
        // ============================================================
        public void Insertar(Cliente c)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"INSERT INTO clientes
                                        (dni, nombre, apellido, mail, direccion, numero_telefono)
                                     VALUES
                                        (@dni, @nombre, @apellido, @mail, @direccion, @telefono)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@dni", c.dni);
                        comando.Parameters.AddWithValue("@nombre", c.nombre);
                        comando.Parameters.AddWithValue("@apellido", c.apellido);
                        comando.Parameters.AddWithValue("@mail", c.mail);
                        comando.Parameters.AddWithValue("@direccion", c.direccion);
                        comando.Parameters.AddWithValue("@telefono", c.numero_telefono);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }
        }

        // ============================================================
        // Actualizar cliente existente (por id_cliente)
        // ============================================================
        public void Actualizar(Cliente c)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"UPDATE clientes
                                     SET dni = @dni,
                                         nombre = @nombre,
                                         apellido = @apellido,
                                         mail = @mail,
                                         direccion = @direccion,
                                         numero_telefono = @telefono
                                     WHERE id_cliente = @id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", c.id_cliente);
                        comando.Parameters.AddWithValue("@dni", c.dni);
                        comando.Parameters.AddWithValue("@nombre", c.nombre);
                        comando.Parameters.AddWithValue("@apellido", c.apellido);
                        comando.Parameters.AddWithValue("@mail", c.mail);
                        comando.Parameters.AddWithValue("@direccion", c.direccion);
                        comando.Parameters.AddWithValue("@telefono", c.numero_telefono);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }

        public bool ExisteDni(string dni)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM clientes WHERE dni = @dni";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@dni", dni);

                        int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                        return cantidad > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar DNI: " + ex.Message);
            }
        }

        private Cliente MapearCliente(SqlDataReader reader)
        {
            return new Cliente
            {
                id_cliente = Convert.ToInt32(reader["id_cliente"]),
                dni = reader["dni"].ToString(),
                nombre = reader["nombre"].ToString(),
                apellido = reader["apellido"].ToString(),
                mail = reader["mail"].ToString(),
                direccion = reader["direccion"].ToString(),
                numero_telefono = reader["numero_telefono"].ToString()
            };
        }
    }
}
