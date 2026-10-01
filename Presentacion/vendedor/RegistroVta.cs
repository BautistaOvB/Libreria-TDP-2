using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class RegistroVta : Form
    {
        private List<Libro> carrito = new List<Libro>();
        private VentaDatos vtaDatos = new VentaDatos();

        public RegistroVta()
        {
            InitializeComponent();
            ConfigurarGrilla();   // ← Se crea la grilla por código
        }

        // ============================================================
        // CONFIGURAR LA GRILLA POR CÓDIGO
        // ============================================================
        private void ConfigurarGrilla()
        {
            dgvCarrito = new DataGridView();

            // Propiedades generales
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Location = new Point(40, 130);      // Ajusta según tu form
            dgvCarrito.Size = new Size(600, 200);          // Ajusta según tu form
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.White;

            // ----- Columnas -----
            // 1. Libro
            DataGridViewTextBoxColumn colLibro = new DataGridViewTextBoxColumn();
            colLibro.Name = "colLibro";
            colLibro.HeaderText = "Libro";
            colLibro.FillWeight = 40;
            dgvCarrito.Columns.Add(colLibro);

            // 2. ISBN
            DataGridViewTextBoxColumn colISBN = new DataGridViewTextBoxColumn();
            colISBN.Name = "colISBN";
            colISBN.HeaderText = "ISBN";
            colISBN.FillWeight = 20;
            dgvCarrito.Columns.Add(colISBN);

            // 3. Cantidad
            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.Name = "colCantidad";
            colCantidad.HeaderText = "Cantidad";
            colCantidad.FillWeight = 10;
            colCantidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCarrito.Columns.Add(colCantidad);

            // 4. Precio
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "colPrecio";
            colPrecio.HeaderText = "Precio";
            colPrecio.FillWeight = 15;
            colPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCarrito.Columns.Add(colPrecio);

            // 5. Acción (botón "Quitar")
            DataGridViewButtonColumn colAccion = new DataGridViewButtonColumn();
            colAccion.Name = "colAccion";
            colAccion.HeaderText = "Acción";
            colAccion.Text = "Quitar";
            colAccion.UseColumnTextForButtonValue = true;
            colAccion.FillWeight = 15;
            colAccion.FlatStyle = FlatStyle.Flat;
            dgvCarrito.Columns.Add(colAccion);

            // ----- Evento de clic en celda -----
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;

            // 🔑 Agregamos la grilla al formulario
            this.Controls.Add(dgvCarrito);
        }

        // ============================================================
        // LOAD
        // ============================================================
        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            RefrescarCarrito();
        }

        // ============================================================
        // AGREGAR PRODUCTO
        // ============================================================
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormProductos frmBuscar = new FormProductos();

            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                List<Libro> seleccionados = frmBuscar.ObtenerCarrito();

                foreach (Libro l in seleccionados)
                {
                    if (carrito.Exists(x => x.id_libro == l.id_libro))
                    {
                        MessageBox.Show($"'{l.Nombre}' ya está en el carrito.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        carrito.Add(l);
                    }
                }

                RefrescarCarrito();
            }
        }

        // ============================================================
        // REFRESCAR GRILLA Y TOTALES
        // ============================================================
        private void RefrescarCarrito()
        {
            dgvCarrito.Rows.Clear();

            decimal subtotal = 0;

            foreach (Libro l in carrito)
            {
                dgvCarrito.Rows.Add(
                    l.Nombre,
                    l.ISBN,
                    1,
                    l.Precio.ToString("N2"),
                    "Quitar"
                );

                subtotal += l.Precio;
            }

            lblSubtotal.Text = "Subtotal: $" + subtotal.ToString("N2");
            lblTotal.Text = "Total a pagar: $" + subtotal.ToString("N2");
        }

        // ============================================================
        // CLIC EN BOTÓN "Quitar"
        // ============================================================
        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvCarrito.Columns[e.ColumnIndex].Name == "colAccion")
            {
                DialogResult r = MessageBox.Show(
                    "¿Quitar este libro del carrito?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    carrito.RemoveAt(e.RowIndex);
                    RefrescarCarrito();
                }
            }
        }

        // ============================================================
        // VACIAR CARRITO
        // ============================================================
        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito ya está vacío.");
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Vaciar todo el carrito?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                carrito.Clear();
                RefrescarCarrito();
            }
        }

        // ============================================================
        // CANCELAR
        // ============================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============================================================
        // IR AL PAGO
        // ============================================================
        private void btnIrAlPago_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = 1;
            int idMetodo = 1;

            try
            {
                int idVenta = vtaDatos.RegistrarVenta(idUsuario, idMetodo, carrito);

                MessageBox.Show($"¡Venta #{idVenta} registrada con éxito!",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carrito.Clear();
                RefrescarCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Libro> ObtenerCarrito()
        {
            return carrito;
        }

        private void pCabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Show();
        }
    }
}