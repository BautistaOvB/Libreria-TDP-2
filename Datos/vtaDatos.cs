using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Gestion_Libreria.Datos
{
    public class VentaDatos
    {
        private string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=Punto_Barra_tdp;Integrated Security=True;";

        // ============================================================
        // Obtener TODAS las ventas
        // ============================================================
        public List<Venta> ObtenerTodas()
        {
            List<Venta> lista = new List<Venta>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT v.id_venta, v.fecha_venta, v.total_venta, 
                                            v.id_metodo, v.id_usuario,
                                            m.nombre   AS nombre_metodo,
                                            u.nombre + ' ' + u.apellido AS nombre_usuario
                                     FROM ventas v
                                     INNER JOIN metodos_pago m ON v.id_metodo  = m.id_metodo
                                     INNER JOIN usuarios u     ON v.id_usuario = u.id_usuario
                                     ORDER BY v.fecha_venta DESC";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Venta
                                {
                                    id_venta = Convert.ToInt32(reader["id_venta"]),
                                    fecha_venta = Convert.ToDateTime(reader["fecha_venta"]),
                                    total_venta = Convert.ToDecimal(reader["total_venta"]),
                                    id_metodo = Convert.ToInt32(reader["id_metodo"]),
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    nombre_metodo = reader["nombre_metodo"].ToString(),
                                    nombre_usuario = reader["nombre_usuario"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener ventas: " + ex.Message);
            }

            return lista;
        }

        // ============================================================
        // Obtener UNA venta por ID (para la cabecera del detalle)
        // ============================================================
        public Venta ObtenerPorId(int idVenta)
        {
            Venta venta = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT v.id_venta, v.fecha_venta, v.total_venta, 
                                            v.id_metodo, v.id_usuario,
                                            m.nombre   AS nombre_metodo,
                                            u.nombre + ' ' + u.apellido AS nombre_usuario
                                     FROM ventas v
                                     INNER JOIN metodos_pago m ON v.id_metodo  = m.id_metodo
                                     INNER JOIN usuarios u     ON v.id_usuario = u.id_usuario
                                     WHERE v.id_venta = @id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idVenta);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                venta = new Venta
                                {
                                    id_venta = Convert.ToInt32(reader["id_venta"]),
                                    fecha_venta = Convert.ToDateTime(reader["fecha_venta"]),
                                    total_venta = Convert.ToDecimal(reader["total_venta"]),
                                    id_metodo = Convert.ToInt32(reader["id_metodo"]),
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    nombre_metodo = reader["nombre_metodo"].ToString(),
                                    nombre_usuario = reader["nombre_usuario"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener venta: " + ex.Message);
            }

            return venta;
        }

        // ============================================================
        // Obtener los DETALLES (libros) de una venta
        // ============================================================
        public List<VentaDetalle> ObtenerDetalles(int idVenta)
        {
            List<VentaDetalle> lista = new List<VentaDetalle>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT dv.id_detalle_venta, dv.id_venta, dv.id_libro,
                                            dv.cantidad, dv.precio_unitario, dv.subtotal,
                                            l.ISBN, l.nombre AS nombre_libro
                                     FROM venta_detalles dv
                                     INNER JOIN libros l ON dv.id_libro = l.id_libro
                                     WHERE dv.id_venta = @id
                                     ORDER BY dv.id_detalle_venta";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idVenta);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new VentaDetalle
                                {
                                    id_detalle_venta = Convert.ToInt32(reader["id_detalle_venta"]),
                                    id_venta = Convert.ToInt32(reader["id_venta"]),
                                    id_libro = Convert.ToInt32(reader["id_libro"]),
                                    cantidad = Convert.ToInt32(reader["cantidad"]),
                                    precio_unitario = Convert.ToDecimal(reader["precio_unitario"]),
                                    subtotal = Convert.ToDecimal(reader["subtotal"]),
                                    ISBN = reader["ISBN"].ToString(),
                                    nombre_libro = reader["nombre_libro"].ToString()
                                });
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
        // ============================================================
        // Registrar una venta completa (cabecera + detalle + descuento stock)
        // ============================================================
        public int RegistrarVenta(int idUsuario, int idMetodo, List<Libro> carrito)
        {
            int idVentaGenerado = 0;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        // 1) Validar stock y calcular total
                        decimal total = 0;

                        foreach (Libro l in carrito)
                        {
                            // Verificar stock actual
                            string queryCheck = "SELECT stock FROM libros WHERE id_libro = @idLibro";
                            using (SqlCommand cmd = new SqlCommand(queryCheck, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idLibro", l.id_libro);
                                object result = cmd.ExecuteScalar();

                                if (result == null)
                                    throw new Exception($"El libro '{l.Nombre}' no existe.");

                                int stockActual = Convert.ToInt32(result);

                                if (stockActual <= 0)
                                    throw new Exception($"No hay stock del libro '{l.Nombre}'.");
                            }

                            total += l.Precio;
                        }

                        // 2) Insertar cabecera
                        string queryVenta = @"INSERT INTO ventas (fecha_venta, total_venta, id_metodo, id_usuario)
                                      VALUES (GETDATE(), @total, @idMetodo, @idUsuario);
                                      SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(queryVenta, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.Parameters.AddWithValue("@idMetodo", idMetodo);
                            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                            idVentaGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 3) Insertar detalle + descontar stock
                        foreach (Libro l in carrito)
                        {
                            string queryDetalle = @"INSERT INTO venta_detalles
                        (id_venta, id_libro, cantidad, precio_unitario, subtotal)
                        VALUES (@idVenta, @idLibro, 1, @precio, @subtotal)";

                            using (SqlCommand cmd = new SqlCommand(queryDetalle, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idVenta", idVentaGenerado);
                                cmd.Parameters.AddWithValue("@idLibro", l.id_libro);
                                cmd.Parameters.AddWithValue("@precio", l.Precio);
                                cmd.Parameters.AddWithValue("@subtotal", l.Precio);
                                cmd.ExecuteNonQuery();
                            }

                            string queryStock = @"UPDATE libros
                                          SET stock = stock - 1
                                          WHERE id_libro = @idLibro";

                            using (SqlCommand cmd = new SqlCommand(queryStock, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idLibro", l.id_libro);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }

            return idVentaGenerado;
        }
        public List<MetodoPago> ObtenerMetodosPago()
        {
            List<MetodoPago> lista = new List<MetodoPago>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT id_metodo, nombre FROM metodos_pago ORDER BY nombre";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new MetodoPago
                        {
                            id_metodo = Convert.ToInt32(reader["id_metodo"]),
                            nombre = reader["nombre"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
        // ============================================================
        // Filtrar ventas por rango de fechas
        // ============================================================
        public List<Venta> ObtenerPorFecha(DateTime desde, DateTime hasta)
        {
            List<Venta> lista = new List<Venta>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Importante: sumamos 1 día al "hasta" para incluir todo ese día completo
                    DateTime hastaFinDia = hasta.Date.AddDays(1);

                    string query = @"SELECT v.id_venta, v.fecha_venta, v.total_venta, 
                                    v.id_metodo, v.id_usuario,
                                    m.nombre   AS nombre_metodo,
                                    u.nombre + ' ' + u.apellido AS nombre_usuario
                             FROM ventas v
                             INNER JOIN metodos_pago m ON v.id_metodo  = m.id_metodo
                             INNER JOIN usuarios u     ON v.id_usuario = u.id_usuario
                             WHERE v.fecha_venta >= @desde AND v.fecha_venta < @hasta
                             ORDER BY v.fecha_venta DESC";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@desde", desde.Date);
                        comando.Parameters.AddWithValue("@hasta", hastaFinDia);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Venta
                                {
                                    id_venta = Convert.ToInt32(reader["id_venta"]),
                                    fecha_venta = Convert.ToDateTime(reader["fecha_venta"]),
                                    total_venta = Convert.ToDecimal(reader["total_venta"]),
                                    id_metodo = Convert.ToInt32(reader["id_metodo"]),
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    nombre_metodo = reader["nombre_metodo"].ToString(),
                                    nombre_usuario = reader["nombre_usuario"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar por fecha: " + ex.Message);
            }

            return lista;
        }

        // ============================================================
        // Filtrar ventas por nombre de vendedor (busca en nombre, apellido o username)
        // ============================================================
        public List<Venta> ObtenerPorVendedor(string filtro)
        {
            List<Venta> lista = new List<Venta>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT v.id_venta, v.fecha_venta, v.total_venta, 
                                    v.id_metodo, v.id_usuario,
                                    m.nombre   AS nombre_metodo,
                                    u.nombre + ' ' + u.apellido AS nombre_usuario
                             FROM ventas v
                             INNER JOIN metodos_pago m ON v.id_metodo  = m.id_metodo
                             INNER JOIN usuarios u     ON v.id_usuario = u.id_usuario
                             WHERE u.nombre LIKE @filtro 
                                OR u.apellido LIKE @filtro 
                                OR u.username LIKE @filtro
                             ORDER BY v.fecha_venta DESC";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Venta
                                {
                                    id_venta = Convert.ToInt32(reader["id_venta"]),
                                    fecha_venta = Convert.ToDateTime(reader["fecha_venta"]),
                                    total_venta = Convert.ToDecimal(reader["total_venta"]),
                                    id_metodo = Convert.ToInt32(reader["id_metodo"]),
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    nombre_metodo = reader["nombre_metodo"].ToString(),
                                    nombre_usuario = reader["nombre_usuario"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar por vendedor: " + ex.Message);
            }

            return lista;
        }
        // ============================================================
        // Obtener SOLO las ventas de un usuario específico (para reporte del vendedor)
        // ============================================================
        public List<Venta> ObtenerPorUsuario(int idUsuario)
        {
            List<Venta> lista = new List<Venta>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = @"SELECT v.id_venta, v.fecha_venta, v.total_venta, 
                                    v.id_metodo, v.id_usuario,
                                    m.nombre   AS nombre_metodo,
                                    u.nombre + ' ' + u.apellido AS nombre_usuario
                             FROM ventas v
                             INNER JOIN metodos_pago m ON v.id_metodo  = m.id_metodo
                             INNER JOIN usuarios u     ON v.id_usuario = u.id_usuario
                             WHERE v.id_usuario = @idUsuario
                             ORDER BY v.fecha_venta DESC";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Venta
                                {
                                    id_venta = Convert.ToInt32(reader["id_venta"]),
                                    fecha_venta = Convert.ToDateTime(reader["fecha_venta"]),
                                    total_venta = Convert.ToDecimal(reader["total_venta"]),
                                    id_metodo = Convert.ToInt32(reader["id_metodo"]),
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    nombre_metodo = reader["nombre_metodo"].ToString(),
                                    nombre_usuario = reader["nombre_usuario"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener ventas del usuario: " + ex.Message);
            }

            return lista;
        }

        // ============================================================
        // Obtener ventas de un usuario en un rango de fechas
        // ============================================================
        public List<Venta> ObtenerPorUsuarioYFecha(int idUsuario, DateTime desde, DateTime hasta)
        {
            List<Venta> lista = new List<Venta>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    DateTime hastaFinDia = hasta.Date.AddDays(1);

                    string query = @"SELECT v.id_venta, v.fecha_venta, v.total_venta, 
                                    v.id_metodo, v.id_usuario,
                                    m.nombre   AS nombre_metodo,
                                    u.nombre + ' ' + u.apellido AS nombre_usuario
                             FROM ventas v
                             INNER JOIN metodos_pago m ON v.id_metodo  = m.id_metodo
                             INNER JOIN usuarios u     ON v.id_usuario = u.id_usuario
                             WHERE v.id_usuario = @idUsuario
                               AND v.fecha_venta >= @desde 
                               AND v.fecha_venta < @hasta
                             ORDER BY v.fecha_venta DESC";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                        comando.Parameters.AddWithValue("@desde", desde.Date);
                        comando.Parameters.AddWithValue("@hasta", hastaFinDia);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Venta
                                {
                                    id_venta = Convert.ToInt32(reader["id_venta"]),
                                    fecha_venta = Convert.ToDateTime(reader["fecha_venta"]),
                                    total_venta = Convert.ToDecimal(reader["total_venta"]),
                                    id_metodo = Convert.ToInt32(reader["id_metodo"]),
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    nombre_metodo = reader["nombre_metodo"].ToString(),
                                    nombre_usuario = reader["nombre_usuario"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar ventas por fecha: " + ex.Message);
            }

            return lista;
        }
        public int RegistrarVentaConCantidades(int idUsuario, int idMetodo, List<ItemCarrito> carrito)
        {
            int idVentaGenerado = 0;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        // 1) Validar stock y calcular total
                        decimal total = 0;

                        foreach (ItemCarrito item in carrito)
                        {
                            string queryCheck = "SELECT stock FROM libros WHERE id_libro = @idLibro";
                            using (SqlCommand cmd = new SqlCommand(queryCheck, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idLibro", item.Libro.id_libro);
                                object result = cmd.ExecuteScalar();

                                if (result == null)
                                    throw new Exception($"El libro '{item.Libro.Nombre}' no existe.");

                                int stockActual = Convert.ToInt32(result);

                                if (stockActual < item.Cantidad)
                                    throw new Exception($"Stock insuficiente de '{item.Libro.Nombre}'. Disponible: {stockActual}, solicitado: {item.Cantidad}.");
                            }

                            total += item.Subtotal;
                        }

                        // 2) Insertar cabecera
                        string queryVenta = @"INSERT INTO ventas (fecha_venta, total_venta, id_metodo, id_usuario)
                                      VALUES (GETDATE(), @total, @idMetodo, @idUsuario);
                                      SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(queryVenta, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.Parameters.AddWithValue("@idMetodo", idMetodo);
                            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                            idVentaGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 3) Insertar detalle + descontar stock
                        foreach (ItemCarrito item in carrito)
                        {
                            string queryDetalle = @"INSERT INTO venta_detalles
                        (id_venta, id_libro, cantidad, precio_unitario, subtotal)
                        VALUES (@idVenta, @idLibro, @cantidad, @precio, @subtotal)";

                            using (SqlCommand cmd = new SqlCommand(queryDetalle, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idVenta", idVentaGenerado);
                                cmd.Parameters.AddWithValue("@idLibro", item.Libro.id_libro);
                                cmd.Parameters.AddWithValue("@cantidad", item.Cantidad);
                                cmd.Parameters.AddWithValue("@precio", item.Libro.Precio);
                                cmd.Parameters.AddWithValue("@subtotal", item.Subtotal);
                                cmd.ExecuteNonQuery();
                            }

                            string queryStock = @"UPDATE libros
                                          SET stock = stock - @cantidad
                                          WHERE id_libro = @idLibro";

                            using (SqlCommand cmd = new SqlCommand(queryStock, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@idLibro", item.Libro.id_libro);
                                cmd.Parameters.AddWithValue("@cantidad", item.Cantidad);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }

            return idVentaGenerado;
        }
    }
}