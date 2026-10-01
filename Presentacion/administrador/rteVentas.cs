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
        }

        private void rteVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
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

        // 🖱️ Doble clic para abrir el detalle
        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Venta ventaSeleccionada = (Venta)dgvVentas.Rows[e.RowIndex].DataBoundItem;

                if (ventaSeleccionada == null) return;

                DetalleVenta frmDetalle = new DetalleVenta(ventaSeleccionada.id_venta);
                frmDetalle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el detalle: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Venta ventaSeleccionada = (Venta)dgvVentas.Rows[e.RowIndex].DataBoundItem;

                if (ventaSeleccionada == null) return;

                DetalleVenta frmDetalle = new DetalleVenta(ventaSeleccionada.id_venta);
                frmDetalle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el detalle: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}