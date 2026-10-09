using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Gestion_Libreria.Datos
{
    public class LibroDatos
    {
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=Punto_Barra_tdp;Integrated Security=True;";

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
                        l.stock, l.precio, l.cod_genero,
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
                                    l.stock, l.precio, l.cod_genero,
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
        public Libro ObtenerPorId(int idLibro)
        {
            Libro libro = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT l.id_libro, l.ISBN, l.nombre, l.descripcion,
                                    l.stock, l.precio, l.cod_genero,
                                    g.descripcion AS nombre_genero
                             FROM libros l
                             INNER JOIN generos g ON l.cod_genero = g.cod_genero
                             WHERE l.id_libro = @id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idLibro);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                libro = new Libro
                                {
                                    id_libro = Convert.ToInt32(reader["id_libro"]),
                                    ISBN = reader["ISBN"].ToString(),
                                    Nombre = reader["nombre"].ToString(),
                                    Descripcion = reader["descripcion"].ToString(),
                                    Stock = Convert.ToInt32(reader["stock"]),
                                    Precio = Convert.ToDecimal(reader["precio"]),
                                    cod_genero = Convert.ToInt32(reader["cod_genero"]),
                                    nombre_genero = reader["nombre_genero"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener libro: " + ex.Message);
            }

            return libro;
        }

    }     
}