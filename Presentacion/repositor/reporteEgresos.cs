using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class reporteEgresos : Form
    {
        private List<Venta> listaVentas;

        public reporteEgresos()
        {
            InitializeComponent();

            // Suscribimos el evento Load y el CellClick
            this.Load += reporteEgresos_Load;
            this.dgvEgresos.CellClick += dgvEgresos_CellClick;
        }

        private void reporteEgresos_Load(object sender, EventArgs e)
        {
            ConfigurarGrillaEgresos();
            ConfigurarGrillaDetalle();
            CargarEgresos();
        }

        // ============================================================
        // CONFIGURAMOS LA GRILLA DE EGRESOS (dgvEgresos)
        // ============================================================
        private void ConfigurarGrillaEgresos()
        {
            dgvEgresos.AutoGenerateColumns = false;
            dgvEgresos.AllowUserToAddRows = false;
            dgvEgresos.ReadOnly = true;
            dgvEgresos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEgresos.MultiSelect = false;
            dgvEgresos.RowHeadersVisible = false;
            dgvEgresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEgresos.Columns.Clear();

            dgvEgresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID",
                HeaderText = "ID",
                DataPropertyName = "id_venta",
                FillWeight = 10
            });

            dgvEgresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFecha",
                HeaderText = "Fecha",
                DataPropertyName = "fecha_venta",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                FillWeight = 25
            });

            dgvEgresos.Columns.Add(new DataGridViewTextBoxColumn
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

            dgvEgresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMetodo",
                HeaderText = "Método",
                DataPropertyName = "nombre_metodo",
                FillWeight = 20
            });

            dgvEgresos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colVendedor",
                HeaderText = "Vendedor",
                DataPropertyName = "nombre_usuario",
                FillWeight = 20
            });
        }

        // ============================================================
        // CONFIGURAMOS LA GRILLA DE DETALLE (dgvDetalleEgreso)
        // ============================================================
        private void ConfigurarGrillaDetalle()
        {
            dgvDetalleEgreso.AutoGenerateColumns = false;
            dgvDetalleEgreso.AllowUserToAddRows = false;
            dgvDetalleEgreso.ReadOnly = true;
            dgvDetalleEgreso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleEgreso.MultiSelect = false;
            dgvDetalleEgreso.RowHeadersVisible = false;
            dgvDetalleEgreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalleEgreso.Columns.Clear();

            dgvDetalleEgreso.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBN",
                FillWeight = 30
            });

            dgvDetalleEgreso.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombreLibro",
                HeaderText = "Libro",
                DataPropertyName = "nombre_libro",
                FillWeight = 35
            });

            dgvDetalleEgreso.Columns.Add(new DataGridViewTextBoxColumn
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

            dgvDetalleEgreso.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecioUnitario",
                HeaderText = "Precio Unit.",
                DataPropertyName = "precio_unitario",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 15
            });

            dgvDetalleEgreso.Columns.Add(new DataGridViewTextBoxColumn
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
        // CARGAR TODOS LOS EGRESOS (VENTAS)
        // ============================================================
        private void CargarEgresos()
        {
            try
            {
                VentaDatos datos = new VentaDatos();
                listaVentas = datos.ObtenerTodas();

                dgvEgresos.DataSource = null;
                dgvEgresos.DataSource = listaVentas;

                dgvDetalleEgreso.DataSource = null;
                //LimpiarCabecera();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar egresos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // AL HACER CLIC EN UN EGRESO, CARGAR CABECERA + DETALLE
        // ============================================================
        private void dgvEgresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Venta ventaSeleccionada = (Venta)dgvEgresos.Rows[e.RowIndex].DataBoundItem;
                if (ventaSeleccionada == null) return;

                // Llenamos la cabecera
                /*txtNVenta.Text = ventaSeleccionada.id_venta.ToString();
                txtVendedor.Text = ventaSeleccionada.nombre_usuario;
                txtTotal.Text = ventaSeleccionada.total_venta.ToString("C2");
                txtMetodoPago.Text = ventaSeleccionada.nombre_metodo;
                */
                // Cargamos el detalle
                VentaDatos datos = new VentaDatos();
                List<VentaDetalle> detalles = datos.ObtenerDetalles(ventaSeleccionada.id_venta);

                dgvDetalleEgreso.DataSource = null;
                dgvDetalleEgreso.DataSource = detalles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // LIMPIAR CABECERA
        // ============================================================
        /*private void LimpiarCabecera()
        {
            txtNVenta.Clear();
            txtVendedor.Clear();
            txtTotal.Clear();
            txtMetodoPago.Clear();
        }*/

        // ============================================================
        // BOTÓN FILTRAR POR FECHA
        // ============================================================
        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDesde.Value.Date > dtpHasta.Value.Date)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                VentaDatos datos = new VentaDatos();
                listaVentas = datos.ObtenerPorFecha(dtpDesde.Value, dtpHasta.Value);

                dgvEgresos.DataSource = null;
                dgvEgresos.DataSource = listaVentas;

                dgvDetalleEgreso.DataSource = null;
                //LimpiarCabecera();

                if (listaVentas.Count == 0)
                {
                    MessageBox.Show("No se encontraron egresos en ese rango de fechas.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fecha: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}