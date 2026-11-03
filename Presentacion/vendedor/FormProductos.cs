using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class FormProductos : Form
    {
        // Lista temporal del carrito
        private List<Libro> carrito = new List<Libro>();

        private LibroDatos libroDatos = new LibroDatos();

        // ✅ Variable para el formulario de detalle embebido
        private ProdDetalles detalleProducto;

        public FormProductos()
        {
            InitializeComponent();

            // ✅ Suscribimos el evento para mostrar el detalle al hacer clic
            this.dgvProductos.CellClick += dgvProductos_CellClick;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // ✅ Creamos el detalle y lo metemos dentro del panel pDetalle
            detalleProducto = new ProdDetalles();
            detalleProducto.TopLevel = false;
            detalleProducto.FormBorderStyle = FormBorderStyle.None;
            detalleProducto.Dock = DockStyle.Fill;

            pDetalle.Controls.Clear();
            pDetalle.Controls.Add(detalleProducto);
            detalleProducto.Show();

            // Cargar todos los libros al abrir el form
            CargarLibros("");
        }

        // ============================================================
        // EVENTO: Al hacer clic en una fila, mostrar detalle a la derecha
        // ============================================================
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Libro libroSeleccionado = (Libro)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                if (libroSeleccionado != null && detalleProducto != null)
                {
                    detalleProducto.CargarLibro(libroSeleccionado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar detalle: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BOTÓN BUSCAR
        // ============================================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarLibros(txtBuscar.Text.Trim());
        }

        // ============================================================
        // Cargar libros en el DataGridView
        // ============================================================
        private void CargarLibros(string filtro)
        {
            try
            {
                List<Libro> lista;

                if (string.IsNullOrWhiteSpace(filtro))
                    lista = libroDatos.ObtenerTodos();
                else
                    lista = libroDatos.BuscarPorNombre(filtro);

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lista;

                if (dgvProductos.Columns["cod_genero"] != null)
                    dgvProductos.Columns["cod_genero"].Visible = false;
                if (dgvProductos.Columns["Descripcion"] != null)
                    dgvProductos.Columns["Descripcion"].Visible = false;

                if (dgvProductos.Columns["id_libro"] != null)
                    dgvProductos.Columns["id_libro"].HeaderText = "ID";
                if (dgvProductos.Columns["nombre"] != null)
                    dgvProductos.Columns["nombre"].HeaderText = "Nombre";
                if (dgvProductos.Columns["nombre_genero"] != null)
                    dgvProductos.Columns["nombre_genero"].HeaderText = "Género";
                if (dgvProductos.Columns["Precio"] != null)
                    dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BOTÓN AGREGAR AL CARRITO
        // ============================================================
        private void AddCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un libro de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Libro libroSeleccionado = (Libro)dgvProductos.CurrentRow.DataBoundItem;

            if (libroSeleccionado.Stock <= 0)
            {
                MessageBox.Show("No hay stock disponible de este libro.",
                    "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (carrito.Exists(l => l.id_libro == libroSeleccionado.id_libro))
            {
                MessageBox.Show("Este libro ya está en el carrito.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            carrito.Add(libroSeleccionado);

            MessageBox.Show($"Libro agregado: {libroSeleccionado.Nombre}\n" +
                            $"Total en carrito: {carrito.Count}",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============================================================
        // BOTÓN CANCELAR
        // ============================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============================================================
        // Método público para que otro form obtenga el carrito
        // ============================================================
        public List<Libro> ObtenerCarrito()
        {
            return carrito;
        }
    }
}