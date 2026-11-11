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
                        l.stock, l.precio, l.cod_genero, l.autor,
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
                                    nombre_genero = reader["nombre_genero"].ToString(),
                                    autor = reader["autor"] == DBNull.Value ? "" : reader["autor"].ToString()
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
        public List<Libro> Buscar(string filtro)
        {
            List<Libro> lista = new List<Libro>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT l.id_libro, l.ISBN, l.nombre,
                                            l.stock, l.precio, l.cod_genero, l.autor,
                                            g.descripcion AS nombre_genero
                                     FROM libros l
                                     INNER JOIN generos g ON l.cod_genero = g.cod_genero
                                     WHERE l.nombre LIKE @filtro
                                        OR l.ISBN   LIKE @filtro
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
                                    nombre_genero = reader["nombre_genero"].ToString(),
                                    autor = reader["autor"] == DBNull.Value ? "" : reader["autor"].ToString()
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
                                    l.stock, l.precio, l.cod_genero, l.autor,
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
                                    nombre_genero = reader["nombre_genero"].ToString(),
                                    autor = reader["autor"] == DBNull.Value ? "" : reader["autor"].ToString()
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
        public Libro ObtenerPorISBN(string isbn)
        {
            Libro libro = null;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    // Asegurate de que la columna 'autor' exista en tu tabla SQL
                    string query = "SELECT id_libro, ISBN, nombre, stock, precio, cod_genero, autor FROM libros WHERE ISBN = @isbn";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@isbn", isbn);
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                libro = new Libro
                                {
                                    id_libro = Convert.ToInt32(reader["id_libro"]),
                                    ISBN = reader["ISBN"].ToString(),
                                    Nombre = reader["nombre"].ToString(),
                                    Stock = Convert.ToInt32(reader["stock"]),
                                    Precio = Convert.ToDecimal(reader["precio"]),
                                    cod_genero = Convert.ToInt32(reader["cod_genero"]),
                                    autor = reader["autor"] == DBNull.Value ? "" : reader["autor"].ToString()
                                    // Agregá el mapeo del autor si lo tenés en la entidad
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar libro por ISBN: " + ex.Message);
            }
            return libro;
        }
        public int ObtenerOCrearGenero(string descripcionGenero)
        {
            int idGenero = 0;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // 1. Buscamos si el género ya existe
                    string queryBuscar = "SELECT cod_genero FROM generos WHERE descripcion = @desc";

                    using (SqlCommand cmdBuscar = new SqlCommand(queryBuscar, conexion))
                    {
                        cmdBuscar.Parameters.AddWithValue("@desc", descripcionGenero);

                        object resultado = cmdBuscar.ExecuteScalar();

                        if (resultado != null)
                        {
                            // Si existe, devolvemos el ID
                            idGenero = Convert.ToInt32(resultado);
                        }
                        else
                        {
                            // 2. Si no existe, lo creamos y obtenemos el ID generado
                            string queryInsert = @"INSERT INTO generos (descripcion) 
                                           OUTPUT INSERTED.cod_genero 
                                           VALUES (@desc)";

                            using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conexion))
                            {
                                cmdInsert.Parameters.AddWithValue("@desc", descripcionGenero);
                                idGenero = Convert.ToInt32(cmdInsert.ExecuteScalar());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar/crear el género: " + ex.Message);
            }

            return idGenero;
        }
        public List<Libro> ObtenerMasVendidos()
        {
            List<Libro> lista = new List<Libro>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Hacemos un JOIN con venta_detalles y sumamos las cantidades
                    string query = @"
                SELECT l.id_libro, l.ISBN, l.nombre, l.stock, l.precio, l.cod_genero, l.autor,
                       g.descripcion AS nombre_genero,
                       ISNULL(SUM(vd.cantidad), 0) AS cantidad_vendida
                FROM libros l
                INNER JOIN generos g ON l.cod_genero = g.cod_genero
                LEFT JOIN venta_detalles vd ON l.id_libro = vd.id_libro
                GROUP BY l.id_libro, l.ISBN, l.nombre, l.stock, l.precio, l.cod_genero, l.autor, g.descripcion
                ORDER BY cantidad_vendida DESC";

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
                                    nombre_genero = reader["nombre_genero"].ToString(),
                                    autor = reader["autor"] == DBNull.Value ? "" : reader["autor"].ToString(),
                                    cantidad_vendida = Convert.ToInt32(reader["cantidad_vendida"]) // 👈 Guardamos las ventas
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener libros más vendidos: " + ex.Message);
            }

            return lista;
        }
        public bool Actualizar(Libro libro)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = @"UPDATE libros 
                             SET ISBN = @isbn, 
                                 nombre = @nom, 
                                 stock = @stock, 
                                 precio = @precio, 
                                 cod_genero = @genero,
                                    autor = @autor
                             WHERE id_libro = @id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", libro.id_libro);
                        comando.Parameters.AddWithValue("@isbn", libro.ISBN);
                        comando.Parameters.AddWithValue("@nom", libro.Nombre);
                        comando.Parameters.AddWithValue("@stock", libro.Stock);
                        comando.Parameters.AddWithValue("@precio", libro.Precio);
                        comando.Parameters.AddWithValue("@genero", libro.cod_genero);
                        comando.Parameters.AddWithValue("@autor", libro.autor ?? (object)DBNull.Value);
                        int filas = comando.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar libro: " + ex.Message);
            }
        }
        public bool AgregarLibro(Libro libro)
        {
            // Hacés el INSERT INTO libros (...) VALUES (...)
            return true;
        }

        public bool SumarStock(int idLibro, int cantidadASumar)
        {
            // Hacés un UPDATE libros SET stock = stock + @cantidad WHERE id_libro = @id
            return true;
        }
        public List<generos> ObtenerGeneros()
        {
            List<generos> lista = new List<generos>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Ajustá el nombre de la tabla y columnas según tu base de datos
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

        /** Metodos para armar los gráficos */

        // 1. Vendedores con más ventas
        public List<VentaPorVendedor> ObtenerVentasPorVendedor()
        {
            List<VentaPorVendedor> lista = new List<VentaPorVendedor>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = @"
            SELECT u.username AS Vendedor, SUM(v.total_venta) AS Total
            FROM ventas v
            INNER JOIN usuarios u ON v.id_usuario = u.id_usuario
            GROUP BY u.username
            ORDER BY Total DESC";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new VentaPorVendedor
                        {
                            NombreVendedor = reader["Vendedor"].ToString(),
                            TotalVendido = Convert.ToDecimal(reader["Total"])
                        });
                    }
                }
            }
            return lista;
        }

        // 2. Total vendido por categoría
        public List<VentaPorCategoria> ObtenerVentasPorCategoria()
        {
            List<VentaPorCategoria> lista = new List<VentaPorCategoria>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                // Asumiendo que en venta_detalles tenés el id_libro y en libros el cod_genero
                string query = @"
            SELECT g.descripcion AS Categoria, SUM(vd.subtotal) AS Total
            FROM venta_detalles vd
            INNER JOIN libros l ON vd.id_libro = l.id_libro
            INNER JOIN generos g ON l.cod_genero = g.cod_genero
            GROUP BY g.descripcion
            ORDER BY Total DESC";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new VentaPorCategoria
                        {
                            Categoria = reader["Categoria"].ToString(),
                            TotalVendido = Convert.ToDecimal(reader["Total"])
                        });
                    }
                }
            }
            return lista;
        }

        // 3. Producto más vendido por categoría
        public List<ProductoMasVendido> ObtenerProductosMasVendidosPorCategoria()
        {
            List<ProductoMasVendido> lista = new List<ProductoMasVendido>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                // Usamos ROW_NUMBER() para rankear los libros dentro de cada categoría y quedarnos con el N°1
                string query = @"
            WITH RankedBooks AS (
                SELECT g.descripcion AS Categoria, 
                       l.nombre AS Libro, 
                       SUM(vd.cantidad) AS CantidadVendida,
                       ROW_NUMBER() OVER (PARTITION BY g.cod_genero ORDER BY SUM(vd.cantidad) DESC) AS RowNum
                FROM venta_detalles vd
                INNER JOIN libros l ON vd.id_libro = l.id_libro
                INNER JOIN generos g ON l.cod_genero = g.cod_genero
                GROUP BY g.descripcion, g.cod_genero, l.nombre
            )
            SELECT Categoria, Libro, CantidadVendida
            FROM RankedBooks
            WHERE RowNum = 1
            ORDER BY Categoria";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new ProductoMasVendido
                        {
                            Categoria = reader["Categoria"].ToString(),
                            NombreLibro = reader["Libro"].ToString(),
                            CantidadVendida = Convert.ToInt32(reader["CantidadVendida"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}