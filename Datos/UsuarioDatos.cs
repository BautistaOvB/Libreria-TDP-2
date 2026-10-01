using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Datos
{
    public class UsuarioDatos
    {
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=Punto_Barra_tdp;Integrated Security=True;";

        // ✅ 1. LOGIN
        public Usuario Loguear(string username, string password)
        {
            Usuario user = null;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT u.id_usuario, u.nombre, u.apellido, u.mail, u.username, u.id_rol, r.nombre_rol 
                                     FROM usuarios u 
                                     INNER JOIN roles r ON u.id_rol = r.id_rol 
                                     WHERE u.username = @user AND u.password_hash = @pass";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@user", username);
                        comando.Parameters.AddWithValue("@pass", password);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new Usuario
                                {
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    nombre = reader["nombre"].ToString(),
                                    apellido = reader["apellido"].ToString(),
                                    mail = reader["mail"].ToString(),
                                    username = reader["username"].ToString(),
                                    id_rol = Convert.ToInt32(reader["id_rol"]),
                                    nombre_rol = reader["nombre_rol"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar: " + ex.Message);
            }
            return user;
        }

        // ✅ 2. AGREGAR
        public bool Agregar(Usuario user)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO usuarios (nombre, apellido, mail, password_hash, username, id_rol) VALUES (@nom, @ape, @mail, @pass, @user, @rol)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nom", user.nombre);
                        comando.Parameters.AddWithValue("@ape", user.apellido);
                        comando.Parameters.AddWithValue("@mail", user.mail);
                        comando.Parameters.AddWithValue("@pass", user.password_hash);
                        comando.Parameters.AddWithValue("@user", user.username);
                        comando.Parameters.AddWithValue("@rol", user.id_rol);

                        int filas = comando.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar: " + ex.Message);
            }
        }

        // ✅ 3. OBTENER TODOS (para VerUsuarios)
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT u.id_usuario, u.nombre, u.apellido, u.mail, 
                                            u.username, u.id_rol, r.nombre_rol 
                                     FROM usuarios u 
                                     INNER JOIN roles r ON u.id_rol = r.id_rol
                                     ORDER BY u.id_usuario";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Usuario
                                {
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    nombre = reader["nombre"].ToString(),
                                    apellido = reader["apellido"].ToString(),
                                    mail = reader["mail"].ToString(),
                                    username = reader["username"].ToString(),
                                    id_rol = Convert.ToInt32(reader["id_rol"]),
                                    nombre_rol = reader["nombre_rol"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuarios: " + ex.Message);
            }

            return lista;
        }

        // ✅ 4. OBTENER POR ID (para mostrarUsuario)
        public Usuario ObtenerPorId(int idUsuario)
        {
            Usuario user = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT u.id_usuario, u.nombre, u.apellido, u.mail, 
                                            u.username, u.id_rol, r.nombre_rol 
                                     FROM usuarios u 
                                     INNER JOIN roles r ON u.id_rol = r.id_rol
                                     WHERE u.id_usuario = @id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idUsuario);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new Usuario
                                {
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    nombre = reader["nombre"].ToString(),
                                    apellido = reader["apellido"].ToString(),
                                    mail = reader["mail"].ToString(),
                                    username = reader["username"].ToString(),
                                    id_rol = Convert.ToInt32(reader["id_rol"]),
                                    nombre_rol = reader["nombre_rol"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuario: " + ex.Message);
            }

            return user;
        }

        // ✅ 5. ACTUALIZAR (para mostrarUsuario)
        public bool Actualizar(Usuario user)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"UPDATE usuarios 
                                     SET nombre = @nom, 
                                         apellido = @ape, 
                                         mail = @mail, 
                                         username = @user, 
                                         id_rol = @rol 
                                     WHERE id_usuario = @id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", user.id_usuario);
                        comando.Parameters.AddWithValue("@nom", user.nombre);
                        comando.Parameters.AddWithValue("@ape", user.apellido);
                        comando.Parameters.AddWithValue("@mail", user.mail);
                        comando.Parameters.AddWithValue("@user", user.username);
                        comando.Parameters.AddWithValue("@rol", user.id_rol);

                        int filas = comando.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar: " + ex.Message);
            }
        }

        // ✅ 6. OBTENER ROLES (para el ComboBox de mostrarUsuario)
        public List<Rol> ObtenerRoles()
        {
            List<Rol> lista = new List<Rol>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = "SELECT id_rol, nombre_rol FROM roles ORDER BY id_rol";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Rol
                                {
                                    id_rol = Convert.ToInt32(reader["id_rol"]),
                                    nombre_rol = reader["nombre_rol"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener roles: " + ex.Message);
            }

            return lista;
        }
    }
}