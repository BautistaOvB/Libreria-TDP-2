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

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // Cargar todos los libros al abrir el form
            CargarLibros("");
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

                // 🔑 Asignamos la lista como DataSource
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lista;

                // Ocultar columnas que no queremos mostrar
                if (dgvProductos.Columns["cod_genero"] != null)
                    dgvProductos.Columns["cod_genero"].Visible = false;
                if (dgvProductos.Columns["Descripcion"] != null)
                    dgvProductos.Columns["Descripcion"].Visible = false;

                // Renombrar encabezados (opcional, si no usas DataPropertyName)
                if (dgvProductos.Columns["id_libro"] != null)
                    dgvProductos.Columns["id_libro"].HeaderText = "ID";
                if (dgvProductos.Columns["nombre"] != null)
                    dgvProductos.Columns["nombre"].HeaderText = "Nombre";
                if (dgvProductos.Columns["nombre_genero"] != null)
                    dgvProductos.Columns["nombre_genero"].HeaderText = "Género";
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

            // Obtenemos el objeto Libro directamente de la fila
            Libro libroSeleccionado = (Libro)dgvProductos.CurrentRow.DataBoundItem;

            if (libroSeleccionado.Stock <= 0)
            {
                MessageBox.Show("No hay stock disponible de este libro.",
                    "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ¿Ya está en el carrito?
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