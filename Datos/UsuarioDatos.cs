using System;
using System.Data.SqlClient;
using Gestion_Libreria.Entidad;
using System.Windows.Forms;

namespace Gestion_Libreria.Datos
{
    public class UsuarioDatos
    {
        private string cadenaConexion = @"Server=localhost; Database=Punto_Barra_tdp; Integrated Security=True; TrustServerCertificate=True;";

        public Usuario Loguear(string username, string password)
        {
            Usuario user = null;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Hacemos un JOIN para traer el nombre del rol
                    string query = @"SELECT u.id_usuario, u.nombre, u.apellido, u.mail, u.username, u.id_rol, r.nombre_rol 
                                     FROM usuarios u 
                                     INNER JOIN roles r ON u.id_rol = r.id_rol 
                                     WHERE u.username = @user AND u.password_hash = @pass";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@user", username);
                        comando.Parameters.AddWithValue("@pass", password); // Si usas hash, aquí encriptas

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
                                    nombre_rol = reader["nombre_rol"].ToString() // Aquí obtenemos "Administrador", etc.
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
        public bool Agregar(Usuario user)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    // Insertamos el id_rol (que es un INT) en la tabla usuarios
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
    }
}