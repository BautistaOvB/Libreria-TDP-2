using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class reporteVentas : Form
    {
        private Venta ventaSeleccionada;
        private List<VentaDetalle> detallesSeleccionados;

        private List<Venta> listaVentas;
        private int idUsuarioLogueado;
        private Venta ventaParaImprimir;
        private List<VentaDetalle> detallesParaImprimir;
        private int paginaActual = 1; // Por si la factura tiene muchos ítems y pasa a otra hoja

        // ============================================================
        // CONSTRUCTORES
        // ============================================================
        public reporteVentas()
        {
            InitializeComponent();

            // Suscribimos el evento para mostrar el detalle al hacer clic
            this.dgvVentas.CellClick += dgvVentas_CellClick;

            // ✅ AGREGAR ESTA LÍNEA: conectar el evento Load
            this.Load += reporteVentas_Load;
        }

        public reporteVentas(int idUsuario) : this()
        {
            idUsuarioLogueado = idUsuario;
        }

        private void reporteVentas_Load(object sender, EventArgs e)
        {
            ConfigurarGrillaVentas();
            ConfigurarGrillaDetalle();
            CargarVentas();
        }

        // ============================================================
        // CONFIGURAMOS LAS COLUMNAS DE dgvVentas (ya existe en el diseñador)
        // ============================================================
        private void ConfigurarGrillaVentas()
        {
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ReadOnly = true;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.MultiSelect = false;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVentas.Columns.Clear();

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdVenta",
                HeaderText = "ID",
                DataPropertyName = "id_venta",
                FillWeight = 7
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFecha",
                HeaderText = "Fecha",
                DataPropertyName = "fecha_venta",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                FillWeight = 30
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotal",
                HeaderText = "Total",
                DataPropertyName = "total_venta",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 25
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMetodo",
                HeaderText = "Método",
                DataPropertyName = "nombre_metodo",
                FillWeight = 30
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCliente",
                HeaderText = "Cliente",
                DataPropertyName = "nombre_cliente",
                FillWeight = 30
            });
        }

        // ============================================================
        // CONFIGURAMOS LAS COLUMNAS DE dgvDetalle (ya existe en el diseñador)
        // ============================================================
        private void ConfigurarGrillaDetalle()
        {
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.ReadOnly = true;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.MultiSelect = false;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalle.Columns.Clear();

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBN",
                FillWeight = 30
            });

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombreLibro",
                HeaderText = "Libro",
                DataPropertyName = "nombre_libro",
                FillWeight = 35
            });

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCantidad",
                HeaderText = "Cant.",
                DataPropertyName = "cantidad",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                FillWeight = 10
            });

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecioUnitario",
                HeaderText = "Precio Unit.",
                DataPropertyName = "precio_unitario",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 15
            });

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "subtotal",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 15
            });
        }

        // ============================================================
        // CARGAR LAS VENTAS DEL VENDEDOR LOGUEADO
        // ============================================================
        private void CargarVentas()
        {
            try
            {
                VentaDatos datos = new VentaDatos();

                if (idUsuarioLogueado > 0)
                    listaVentas = datos.ObtenerPorUsuario(idUsuarioLogueado);
                else
                    listaVentas = datos.ObtenerTodas();

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = listaVentas;

                dgvDetalle.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // AL HACER CLIC EN UNA VENTA, MOSTRAR EL DETALLE
        // ============================================================
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Venta ventaSeleccionada = (Venta)dgvVentas.Rows[e.RowIndex].DataBoundItem;
                if (ventaSeleccionada == null) return;

                VentaDatos datos = new VentaDatos();
                List<VentaDetalle> detalles = datos.ObtenerDetalles(ventaSeleccionada.id_venta);

                dgvDetalle.DataSource = null;
                dgvDetalle.DataSource = detalles;

                // 🔑 Guardar para la impresión
                ventaParaImprimir = ventaSeleccionada;
                detallesParaImprimir = detalles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BOTÓN FILTRAR POR FECHA
        // ⚠️ Asegurate de conectar tu botón "Buscar" a este método
        // ============================================================
        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde = dtpDesde.Value;
                DateTime hasta = dtpHasta.Value;

                if (desde.Date > hasta.Date)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                VentaDatos datos = new VentaDatos();

                if (idUsuarioLogueado > 0)
                    listaVentas = datos.ObtenerPorUsuarioYFecha(idUsuarioLogueado, desde, hasta);
                else
                    listaVentas = datos.ObtenerPorFecha(desde, hasta);

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = listaVentas;

                dgvDetalle.DataSource = null;

                if (listaVentas.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas en ese rango de fechas.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fecha: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if (ventaParaImprimir == null || detallesParaImprimir == null || detallesParaImprimir.Count == 0)
            {
                MessageBox.Show("Por favor, seleccioná una venta de la lista primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Reiniciar el contador de páginas
            paginaActual = 1;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirFactura_PrintPage);

            // Opcional: nombre del documento
            pd.DocumentName = $"Factura_{ventaParaImprimir.id_venta}";

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.Width = 800;
            preview.Height = 600;
            preview.ShowDialog();
        }
        private void ImprimirFactura_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fontSubtitulo = new Font("Arial", 11, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 10, FontStyle.Regular);
            Font fontPequena = new Font("Arial", 8, FontStyle.Italic);
            Brush brush = Brushes.Black;

            float yPos = 20;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float anchoPagina = rightMargin - leftMargin;

            // 1. Encabezado
            g.DrawString("PUNTO Y BARRA - LIBRERÍA", fontTitulo, brush, leftMargin, yPos);
            yPos += 25;
            g.DrawString("FACTURA DE VENTA", fontSubtitulo, brush, leftMargin, yPos);
            yPos += 30;

            // 2. Datos de la Venta
            g.DrawString($"N° Factura: {ventaParaImprimir.id_venta}", fontNormal, brush, leftMargin, yPos);
            g.DrawString($"Fecha: {ventaParaImprimir.fecha_venta:dd/MM/yyyy HH:mm}", fontNormal, brush, leftMargin + 250, yPos);
            yPos += 20;
            g.DrawString($"Vendedor: {ventaParaImprimir.nombre_usuario}", fontNormal, brush, leftMargin, yPos);
            g.DrawString($"Método de Pago: {ventaParaImprimir.nombre_metodo}", fontNormal, brush, leftMargin + 250, yPos);
            yPos += 30;

            // 3. Línea separadora
            g.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 10;

            // 4. Cabecera de la tabla de detalles
            g.DrawString("Cant.", fontSubtitulo, brush, leftMargin, yPos);
            g.DrawString("Descripción", fontSubtitulo, brush, leftMargin + 50, yPos);

            // Alinear a la derecha los montos
            SizeF sizeUnit = g.MeasureString("P. Unit.", fontSubtitulo);
            g.DrawString("P. Unit.", fontSubtitulo, brush, leftMargin + 380 - sizeUnit.Width, yPos);

            SizeF sizeSubtotal = g.MeasureString("Subtotal", fontSubtitulo);
            g.DrawString("Subtotal", fontSubtitulo, brush, rightMargin - sizeSubtotal.Width, yPos);

            yPos += 20;
            g.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 10;

            // 5. Filas de detalles
            foreach (VentaDetalle detalle in detallesParaImprimir)
            {
                // Si nos pasamos del margen inferior, cortamos (podés implementar e.HasMorePages = true para multipágina)
                if (yPos > e.MarginBounds.Bottom - 50) break;

                g.DrawString(detalle.cantidad.ToString(), fontNormal, brush, leftMargin, yPos);

                // Recortar nombre si es muy largo
                string nombreCorto = detalle.nombre_libro.Length > 50
                    ? detalle.nombre_libro.Substring(0, 47) + "..."
                    : detalle.nombre_libro;

                g.DrawString(nombreCorto, fontNormal, brush, leftMargin + 50, yPos);

                // Precio Unitario alineado a la derecha
                string precioUnitStr = detalle.precio_unitario.ToString("C2");
                SizeF sizePU = g.MeasureString(precioUnitStr, fontNormal);
                g.DrawString(precioUnitStr, fontNormal, brush, leftMargin + 380 - sizePU.Width, yPos);

                // Subtotal alineado a la derecha
                string subtotalStr = detalle.subtotal.ToString("C2");
                SizeF sizeSub = g.MeasureString(subtotalStr, fontNormal);
                g.DrawString(subtotalStr, fontNormal, brush, rightMargin - sizeSub.Width, yPos);

                yPos += 20;
            }

            // 6. Línea final de la tabla y Total
            yPos += 10;
            g.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 20;

            Font fontTotal = new Font("Arial", 14, FontStyle.Bold);
            string totalStr = $"TOTAL: {ventaParaImprimir.total_venta:C2}";
            SizeF sizeTotal = g.MeasureString(totalStr, fontTotal);
            g.DrawString(totalStr, fontTotal, brush, rightMargin - sizeTotal.Width, yPos);

            yPos += 50;

            // 7. Pie de página
            g.DrawString("¡Gracias por su compra!", fontPequena, brush, leftMargin, yPos);
            yPos += 15;
            g.DrawString("Punto y Barra | Librería", fontPequena, brush, leftMargin, yPos);
        }
    }
}