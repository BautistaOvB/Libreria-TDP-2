using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Gestion_Libreria.Datos
{
    public class LibroDatos
    {
        private string cadenaConexion = "Server=.;Database=Punto_Barra_tdp;Integrated Security=True;";

        public List<generos> ObtenerGeneros()
        {
            List<generos> lista = new List<generos>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT cod_genero, descripcion FROM generos ORDER BY descripcion";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new generos
                                {
                                    cod_genero = Convert.ToInt32(reader["cod_genero"]),
                                    descripcion = reader["descripcion"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener géneros: " + ex.Message);
            }

            return lista;
        }

        // ============================================================
        // Obtener todos los libros con el nombre del género (JOIN)
        // ============================================================
        public List<Libro> ObtenerTodos()
        {
            List<Libro> lista = new List<Libro>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT l.id_libro, l.ISBN, l.nombre,
                        l.stock, l.precio, l.cod_genero, l.autor, l.stock_minimo,
                        g.descripcion AS nombre_genero
                 FROM libros l
                 INNER JOIN generos g ON l.cod_genero = g.cod_genero
                 ORDER BY l.nombre";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Libro
                                {
                                    id_libro = Convert.ToInt32(reader["id_libro"]),
                                    ISBN = reader["ISBN"].ToString(),
                                    Nombre = reader["nombre"].ToString(),

                                    Stock = Convert.ToInt32(reader["stock"]),
                                    Precio = Convert.ToDecimal(reader["precio"]),
                                    cod_genero = Convert.ToInt32(reader["cod_genero"]),
                                    Autor = reader["autor"].ToString(),
                                    Stock_minimo = Convert.ToInt32(reader["stock_minimo"]),
                                    nombre_genero = reader["nombre_genero"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener libros: " + ex.Message);
            }

            return lista;
        }
        // ============================================================
        // Buscar libros por nombre (LIKE)
        // ============================================================
        public List<Libro> BuscarPorNombre(string filtro)
        {
            List<Libro> lista = new List<Libro>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT l.id_libro, l.ISBN, l.nombre,
                                    l.stock, l.precio, l.autor, l.stock_minimo, l.cod_genero,
                                    g.descripcion AS nombre_genero
                             FROM libros l
                             INNER JOIN generos g ON l.cod_genero = g.cod_genero
                             WHERE l.nombre LIKE @filtro
                             ORDER BY l.nombre";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Libro
                                {
                                    id_libro = Convert.ToInt32(reader["id_libro"]),
                                    ISBN = reader["ISBN"].ToString(),
                                    Nombre = reader["nombre"].ToString(),
                                    Stock = Convert.ToInt32(reader["stock"]),
                                    Precio = Convert.ToDecimal(reader["precio"]),
                                    Autor = reader["autor"].ToString(),
                                    Stock_minimo = Convert.ToInt32(reader["stock_minimo"]),
                                    cod_genero = Convert.ToInt32(reader["cod_genero"]),
                                    nombre_genero = reader["nombre_genero"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar libros: " + ex.Message);
            }

            return lista;
        }
        public void Agregar(Libro libro)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"INSERT INTO libros (ISBN, nombre, stock, precio, cod_genero, autor, stock_minimo)
                            VALUES (@ISBN, @nombre, @stock, @precio, @cod_genero, @autor, @stock_minimo)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@ISBN", libro.ISBN);
                        comando.Parameters.AddWithValue("@nombre", libro.Nombre);
                        comando.Parameters.AddWithValue("@stock", libro.Stock);
                        comando.Parameters.AddWithValue("@precio", libro.Precio);
                        comando.Parameters.AddWithValue("@cod_genero", libro.cod_genero);
                        comando.Parameters.AddWithValue("@autor", libro.Autor);
                        comando.Parameters.AddWithValue("@stock_minimo", libro.Stock_minimo);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el libro: " + ex.Message);
            }
        }
        public void Modificar(Libro libro)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = @"UPDATE libros 
                            SET ISBN = @ISBN, nombre = @nombre, stock = @stock, 
                                precio = @precio, cod_genero = @cod_genero, 
                                autor = @autor, stock_minimo = @stock_minimo
                            WHERE id_libro = @id_libro";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_libro", libro.id_libro);
                        comando.Parameters.AddWithValue("@ISBN", libro.ISBN);
                        comando.Parameters.AddWithValue("@nombre", libro.Nombre);
                        comando.Parameters.AddWithValue("@stock", libro.Stock);
                        comando.Parameters.AddWithValue("@precio", libro.Precio);
                        comando.Parameters.AddWithValue("@cod_genero", libro.cod_genero);
                        comando.Parameters.AddWithValue("@autor", libro.Autor);
                        comando.Parameters.AddWithValue("@stock_minimo", libro.Stock_minimo);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el libro: " + ex.Message);
            }
        }
        public void Eliminar(int idLibro)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "DELETE FROM libros WHERE id_libro = @id_libro";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_libro", idLibro);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el libro: " + ex.Message);
            }
        }

    }     
}