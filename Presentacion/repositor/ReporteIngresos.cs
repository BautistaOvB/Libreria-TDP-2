using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class RIngresos : Form
    {
        public RIngresos()
        {
            InitializeComponent();

            // Suscribimos los eventos
            this.Load += RIngresos_Load;
            this.dgvCompras.CellClick += dgvCompras_CellClick;
        }

        private void RIngresos_Load(object sender, EventArgs e)
        {
            ConfigurarGrillas();
            CargarCompras();
        }

        private void ConfigurarGrillas()
        {
            // --- Configuración Grilla de Compras (Izquierda) ---
            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.ReadOnly = true;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCompras.Columns.Clear();
            dgvCompras.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "N° Compra", DataPropertyName = "id_compra", FillWeight = 20 });
            dgvCompras.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFecha", HeaderText = "Fecha", DataPropertyName = "fecha_compra", DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }, FillWeight = 30 });
            dgvCompras.Columns.Add(new DataGridViewTextBoxColumn { Name = "colProveedor", HeaderText = "Proveedor", DataPropertyName = "nombre_proveedor", FillWeight = 30 });
            dgvCompras.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total", DataPropertyName = "total_compra", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }, FillWeight = 20 });

            // --- Configuración Grilla de Detalles (Derecha) ---
            dgvDetalles.AutoGenerateColumns = false;
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.ReadOnly = true;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalles.Columns.Clear();
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colISBN", HeaderText = "ISBN", DataPropertyName = "isbn_libro", FillWeight = 25 });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colLibro", HeaderText = "Libro", DataPropertyName = "nombre_libro", FillWeight = 45 });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCant", HeaderText = "Cant.", DataPropertyName = "cantidad", FillWeight = 10 });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPrecio", HeaderText = "P. Unit", DataPropertyName = "precio_unitario", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }, FillWeight = 10 });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubtotal", HeaderText = "Subtotal", DataPropertyName = "subtotal", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }, FillWeight = 10 });
        }

        private void CargarCompras()
        {
            try
            {
                CompraDatos datos = new CompraDatos();
                dgvCompras.DataSource = null;
                dgvCompras.DataSource = datos.ObtenerTodasLasCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // Obtenemos la compra seleccionada
                Compra compraSeleccionada = (Compra)dgvCompras.Rows[e.RowIndex].DataBoundItem;
                if (compraSeleccionada == null) return;

                // Llenamos los TextBox de la cabecera
                txtFecha.Text = compraSeleccionada.fecha_compra.ToString("dd/MM/yyyy HH:mm");
                txtProveedor.Text = compraSeleccionada.nombre_proveedor;
                txtTotal.Text = compraSeleccionada.total_compra.ToString("C2");

                // Buscamos y mostramos los detalles
                CompraDatos datos = new CompraDatos();
                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = datos.ObtenerDetallesPorCompra(compraSeleccionada.id_compra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}