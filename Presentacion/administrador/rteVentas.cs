using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.administrador
{
    public partial class rteVentas : Form
    {
        private List<Venta> listaVentas;

        public rteVentas()
        {
            InitializeComponent();

            // Suscribimos el evento para detectar clics en la grilla de ventas
            this.dgvVentas.CellClick += dgvVentas_CellClick;
        }

        private void rteVentas_Load(object sender, EventArgs e)
        {
            ConfigurarGrillaDetalles();
            CargarVentas();
        }

        // ============================================================
        // CONFIGURAMOS LA GRILLA DE DETALLES (dgvDetalles)
        // ============================================================
        private void ConfigurarGrillaDetalles()
        {
            dgvDetalles.AutoGenerateColumns = false;
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.ReadOnly = true;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.MultiSelect = false;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalles.Columns.Clear();

            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBN"
            });

            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombreLibro",
                HeaderText = "Libro",
                DataPropertyName = "nombre_libro"
            });

            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCantidad",
                HeaderText = "Cant.",
                DataPropertyName = "cantidad",
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecioUnitario",
                HeaderText = "Precio Unit.",
                DataPropertyName = "precio_unitario",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "subtotal",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
        }

        private void CargarVentas()
        {
            try
            {
                VentaDatos datos = new VentaDatos();
                listaVentas = datos.ObtenerTodas();

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = listaVentas;
                PersonalizarColumnas();

                // Limpiamos detalle y cabecera
                dgvDetalles.DataSource = null;
                LimpiarCabecera();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonalizarColumnas()
        {
            if (dgvVentas.Columns["id_venta"] != null)
                dgvVentas.Columns["id_venta"].HeaderText = "ID";

            if (dgvVentas.Columns["fecha_venta"] != null)
            {
                dgvVentas.Columns["fecha_venta"].HeaderText = "Fecha";
                dgvVentas.Columns["fecha_venta"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvVentas.Columns["total_venta"] != null)
            {
                dgvVentas.Columns["total_venta"].HeaderText = "Total";
                dgvVentas.Columns["total_venta"].DefaultCellStyle.Format = "C2";
            }

            if (dgvVentas.Columns["nombre_metodo"] != null)
                dgvVentas.Columns["nombre_metodo"].HeaderText = "Método de Pago";

            if (dgvVentas.Columns["nombre_usuario"] != null)
                dgvVentas.Columns["nombre_usuario"].HeaderText = "Vendedor";

            if (dgvVentas.Columns["id_metodo"] != null)
                dgvVentas.Columns["id_metodo"].Visible = false;

            if (dgvVentas.Columns["id_usuario"] != null)
                dgvVentas.Columns["id_usuario"].Visible = false;
        }

        // ============================================================
        // EVENTO: Al hacer clic en una venta, cargar cabecera + detalle
        // ============================================================
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // 1. Obtenemos la venta seleccionada
                Venta ventaSeleccionada = (Venta)dgvVentas.Rows[e.RowIndex].DataBoundItem;

                if (ventaSeleccionada == null) return;

                // ============================================================
                // 2. LLENAMOS LOS TEXTBOX DE LA CABECERA
                // ============================================================
                // ⚠️ IMPORTANTE: Cambia estos nombres si en tu diseñador se llaman diferente
                txtNventa.Text = ventaSeleccionada.id_venta.ToString();
                txtVendedor.Text = ventaSeleccionada.nombre_usuario;
                txtTotal.Text = ventaSeleccionada.total_venta.ToString("C2");

                // Como no tienes un campo "abonado" en tu clase Venta, 
                // mostramos el total como referencia. Si agregas el campo, cámbialo aquí.
                txtMetodoPago.Text = ventaSeleccionada.nombre_metodo;

                // ============================================================
                // 3. CARGAMOS EL DETALLE EN LA GRILLA DERECHA
                // ============================================================
                VentaDatos datos = new VentaDatos();
                List<VentaDetalle> detalles = datos.ObtenerDetalles(ventaSeleccionada.id_venta);

                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = detalles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método auxiliar para limpiar los TextBox de la cabecera
        private void LimpiarCabecera()
        {
            // ⚠️ Asegúrate de que estos nombres coincidan con tu diseñador
            txtNventa.Clear();
            txtFiltroVendedor.Clear();
            txtTotal.Clear();
            txtMetodoPago.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación: que la fecha "desde" no sea mayor que "hasta"
                if (dtpDesde.Value.Date > dtpHasta.Value.Date)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                VentaDatos datos = new VentaDatos();
                listaVentas = datos.ObtenerPorFecha(dtpDesde.Value, dtpHasta.Value);

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = listaVentas;
                PersonalizarColumnas();

                // Limpiamos el detalle y la cabecera
                dgvDetalles.DataSource = null;
                LimpiarCabecera();

                // Avisamos si no se encontraron resultados
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

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Si el TextBox está vacío, recargamos todas
                if (string.IsNullOrWhiteSpace(txtFiltroVendedor.Text))
                {
                    CargarVentas();
                    return;
                }

                VentaDatos datos = new VentaDatos();
                listaVentas = datos.ObtenerPorVendedor(txtFiltroVendedor.Text.Trim());

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = listaVentas;
                PersonalizarColumnas();

                // Limpiamos el detalle y la cabecera
                dgvDetalles.DataSource = null;
                LimpiarCabecera();

                if (listaVentas.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas para ese vendedor.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por vendedor: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}