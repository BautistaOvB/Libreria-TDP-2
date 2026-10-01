using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.administrador
{
    public partial class DetalleVenta : Form
    {
        private int idVenta;

        // Constructor que recibe el ID de la venta
        public DetalleVenta(int id)
        {
            InitializeComponent();
            this.idVenta = id;
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            CargarCabecera();
            CargarDetalles();
        }

        // Cargar los datos generales de la venta
        private void CargarCabecera()
        {
            try
            {
                VentaDatos datos = new VentaDatos();
                Venta venta = datos.ObtenerPorId(idVenta);

                if (venta != null)
                {
                    txtIdVenta.Text = venta.id_venta.ToString();
                    txtFecha.Text = venta.fecha_venta.ToString("dd/MM/yyyy");
                    txtVendedor.Text = venta.nombre_usuario;
                    txtMetodo.Text = venta.nombre_metodo;
                    txtTotal.Text = venta.total_venta.ToString("C2");

                    this.Text = "Venta #" + venta.id_venta;
                }
                else
                {
                    MessageBox.Show("No se encontró la venta.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cabecera: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Cargar los detalles (libros vendidos)
        private void CargarDetalles()
        {
            try
            {
                VentaDatos datos = new VentaDatos();
                List<VentaDetalle> detalles = datos.ObtenerDetalles(idVenta);

                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = detalles;
                PersonalizarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonalizarColumnas()
        {
            // Nombre del libro
            if (dgvDetalles.Columns["nombre_libro"] != null)
                dgvDetalles.Columns["nombre_libro"].HeaderText = "Título";

            if (dgvDetalles.Columns["ISBN"] != null)
                dgvDetalles.Columns["ISBN"].HeaderText = "ISBN";

            if (dgvDetalles.Columns["cantidad"] != null)
                dgvDetalles.Columns["cantidad"].HeaderText = "Cantidad";

            if (dgvDetalles.Columns["precio_unitario"] != null)
            {
                dgvDetalles.Columns["precio_unitario"].HeaderText = "Precio Unitario";
                dgvDetalles.Columns["precio_unitario"].DefaultCellStyle.Format = "C2";
            }

            if (dgvDetalles.Columns["subtotal"] != null)
            {
                dgvDetalles.Columns["subtotal"].HeaderText = "Subtotal";
                dgvDetalles.Columns["subtotal"].DefaultCellStyle.Format = "C2";
            }

            // Ocultar columnas internas
            string[] ocultar = { "id_detalle_venta", "id_venta", "id_libro" };
            foreach (string col in ocultar)
            {
                if (dgvDetalles.Columns[col] != null)
                    dgvDetalles.Columns[col].Visible = false;
            }

            // Reordenar
            if (dgvDetalles.Columns["nombre_libro"] != null)
                dgvDetalles.Columns["nombre_libro"].DisplayIndex = 0;
            if (dgvDetalles.Columns["ISBN"] != null)
                dgvDetalles.Columns["ISBN"].DisplayIndex = 1;
            if (dgvDetalles.Columns["cantidad"] != null)
                dgvDetalles.Columns["cantidad"].DisplayIndex = 2;
            if (dgvDetalles.Columns["precio_unitario"] != null)
                dgvDetalles.Columns["precio_unitario"].DisplayIndex = 3;
            if (dgvDetalles.Columns["subtotal"] != null)
                dgvDetalles.Columns["subtotal"].DisplayIndex = 4;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}