using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Datos
{
    public class CompraDatos // 👈 Lo cambié a public
    {
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=Punto_Barra_tdp;Integrated Security=True;";

        public bool RegistrarCompraCompleta(int idProveedor, decimal total, List<ItemCarrito> carrito)
        {
            SqlTransaction transaccion = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Iniciamos una transacción para que todo se guarde junto o no se guarde nada
                    transaccion = conexion.BeginTransaction();

                    // 1. INSERTAR LA COMPRA (Cabecera)
                    string queryCompra = @"INSERT INTO compras (fecha_compra, total_compra, id_proveedor) 
                                           OUTPUT INSERTED.id_compra 
                                           VALUES (@fecha, @total, @id_prov)";

                    int idCompraGenerado = 0;

                    using (SqlCommand cmdCompra = new SqlCommand(queryCompra, conexion, transaccion))
                    {
                        cmdCompra.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmdCompra.Parameters.AddWithValue("@total", total);
                        cmdCompra.Parameters.AddWithValue("@id_prov", idProveedor);

                        // ExecuteScalar nos devuelve el ID que se acaba de generar
                        idCompraGenerado = Convert.ToInt32(cmdCompra.ExecuteScalar());
                    }

                    // 2. RECORRER EL CARRITO
                    foreach (ItemCarrito item in carrito)
                    {
                        int idLibroFinal = 0;

                        // 2.1 Verificamos si el libro existe en la BD (por ISBN)
                        string queryBuscarLibro = "SELECT id_libro, stock FROM libros WHERE ISBN = @isbn";

                        using (SqlCommand cmdBuscar = new SqlCommand(queryBuscarLibro, conexion, transaccion))
                        {
                            cmdBuscar.Parameters.AddWithValue("@isbn", item.Libro.ISBN);

                            using (SqlDataReader reader = cmdBuscar.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // EL LIBRO YA EXISTE
                                    idLibroFinal = Convert.ToInt32(reader["id_libro"]);
                                    int stockActual = Convert.ToInt32(reader["stock"]);
                                    reader.Close(); // Importante cerrar el reader antes de hacer otro comando

                                    // Actualizamos el stock (sumamos lo que estamos comprando)
                                    string queryUpdateStock = "UPDATE libros SET stock = @nuevoStock, precio = @precio WHERE id_libro = @id";
                                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdateStock, conexion, transaccion))
                                    {
                                        cmdUpdate.Parameters.AddWithValue("@nuevoStock", stockActual + item.Cantidad);
                                        cmdUpdate.Parameters.AddWithValue("@precio", item.PrecioUnitario); // Actualizamos al precio de compra
                                        cmdUpdate.Parameters.AddWithValue("@id", idLibroFinal);
                                        cmdUpdate.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // EL LIBRO ES NUEVO
                                    reader.Close();
                                    string queryInsertLibro = @"INSERT INTO libros (ISBN, nombre, stock, precio, cod_genero, autor) 
                                                                OUTPUT INSERTED.id_libro
                                                                VALUES (@isbn, @nom, @stock, @precio, @genero, @autor)";

                                    using (SqlCommand cmdInsert = new SqlCommand(queryInsertLibro, conexion, transaccion))
                                    {
                                        cmdInsert.Parameters.AddWithValue("@isbn", item.Libro.ISBN);
                                        cmdInsert.Parameters.AddWithValue("@nom", item.Libro.Nombre);
                                        cmdInsert.Parameters.AddWithValue("@stock", item.Cantidad);
                                        cmdInsert.Parameters.AddWithValue("@precio", item.PrecioUnitario);
                                        cmdInsert.Parameters.AddWithValue("@genero", item.Libro.cod_genero);
                                        cmdInsert.Parameters.AddWithValue("@autor", string.IsNullOrEmpty(item.Libro.autor) ? (object)DBNull.Value : item.Libro.autor);

                                        idLibroFinal = Convert.ToInt32(cmdInsert.ExecuteScalar());
                                    }
                                }
                            }
                        }

                        // 2.2 INSERTAR EL DETALLE DE LA COMPRA
                        string queryDetalle = @"INSERT INTO compra_detalles (id_compra, id_libro, cantidad, precio_unitario, subtotal) 
                                                VALUES (@id_compra, @id_libro, @cant, @precio, @subtotal)";

                        using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, transaccion))
                        {
                            cmdDetalle.Parameters.AddWithValue("@id_compra", idCompraGenerado);
                            cmdDetalle.Parameters.AddWithValue("@id_libro", idLibroFinal);
                            cmdDetalle.Parameters.AddWithValue("@cant", item.Cantidad);
                            cmdDetalle.Parameters.AddWithValue("@precio", item.PrecioUnitario);
                            cmdDetalle.Parameters.AddWithValue("@subtotal", item.Subtotal);
                            cmdDetalle.ExecuteNonQuery();
                        }
                    }

                    // Si llegamos hasta acá sin errores, confirmamos la transacción en la BD
                    transaccion.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Si hubo cualquier error, deshacemos todo
                if (transaccion != null)
                    transaccion.Rollback();

                throw new Exception("Error al registrar la compra: " + ex.Message);
            }
        }

        // ✅ 1. OBTENER TODAS LAS COMPRAS (Para la grilla izquierda)
        public List<Compra> ObtenerTodasLasCompras()
        {
            List<Compra> lista = new List<Compra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Hacemos un JOIN con proveedores para traer el nombre
                    string query = @"SELECT c.id_compra, c.fecha_compra, c.total_compra, c.id_proveedor, p.nombre AS nombre_proveedor
                             FROM compras c
                             INNER JOIN proveedores p ON c.id_proveedor = p.id_proveedor
                             ORDER BY c.id_compra DESC"; // Las más nuevas primero

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Compra
                                {
                                    id_compra = Convert.ToInt32(reader["id_compra"]),
                                    fecha_compra = Convert.ToDateTime(reader["fecha_compra"]),
                                    total_compra = Convert.ToDecimal(reader["total_compra"]),
                                    id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                                    nombre_proveedor = reader["nombre_proveedor"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener compras: " + ex.Message);
            }
            return lista;
        }

        // ✅ 2. OBTENER EL DETALLE DE UNA COMPRA (Para la grilla derecha)
        public List<CompraDetalle> ObtenerDetallesPorCompra(int idCompra)
        {
            List<CompraDetalle> lista = new List<CompraDetalle>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // JOIN con libros para traer el nombre y el ISBN
                    string query = @"SELECT cd.id_detalle_compra, cd.id_compra, cd.id_libro, 
                                    cd.cantidad, cd.precio_unitario, cd.subtotal,
                                    l.nombre AS nombre_libro, l.ISBN AS isbn_libro
                             FROM compra_detalles cd
                             INNER JOIN libros l ON cd.id_libro = l.id_libro
                             WHERE cd.id_compra = @id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idCompra);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var detalle = new CompraDetalle
                                {
                                    id_detalle_compra = Convert.ToInt32(reader["id_detalle_compra"]),
                                    id_compra = Convert.ToInt32(reader["id_compra"]),
                                    id_libro = Convert.ToInt32(reader["id_libro"]),
                                    cantidad = Convert.ToInt32(reader["cantidad"]),
                                    precio_unitario = Convert.ToDecimal(reader["precio_unitario"]),
                                    subtotal = Convert.ToDecimal(reader["subtotal"])
                                };

                                // Como no tenemos el nombre del libro en la entidad CompraDetalle, 
                                // te recomiendo agregarle estas dos propiedades a CompraDetalle.cs:
                                // public string nombre_libro { get; set; }
                                // public string isbn_libro { get; set; }
                                detalle.nombre_libro = reader["nombre_libro"].ToString();
                                detalle.isbn_libro = reader["isbn_libro"].ToString();

                                lista.Add(detalle);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalles: " + ex.Message);
            }
            return lista;
        }
    }
}