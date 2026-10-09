using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class FormProductos : Form
    {
        private LibroDatos libroDatos = new LibroDatos();
        private ProdDetalles detalleProducto;

        // 🔑 Libro que se va a devolver a RegistroVta
        private Libro libroSeleccionado;

        public FormProductos()
        {
            InitializeComponent();
            this.dgvProductos.CellClick += dgvProductos_CellClick;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            detalleProducto = new ProdDetalles();
            detalleProducto.TopLevel = false;
            detalleProducto.FormBorderStyle = FormBorderStyle.None;
            detalleProducto.Dock = DockStyle.Fill;

            detalleProducto.AgregarAlCarrito += Detalle_AgregarAlCarrito;
            detalleProducto.Salir += Detalle_Salir;

            pDetalle.Controls.Clear();
            pDetalle.Controls.Add(detalleProducto);
            detalleProducto.Show();

            CargarLibros("");
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Libro libro = (Libro)dgvProductos.Rows[e.RowIndex].DataBoundItem;
                if (libro != null && detalleProducto != null)
                    detalleProducto.CargarLibro(libro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar detalle: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarLibros(txtBuscar.Text.Trim());
        }

        private void CargarLibros(string filtro)
        {
            try
            {
                List<Libro> lista = string.IsNullOrWhiteSpace(filtro)
                    ? libroDatos.ObtenerTodos()
                    : libroDatos.BuscarPorNombre(filtro);

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
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // ============================================================
        // EVENTO: ProdDetalles dice "agregar" → guardamos el libro y
        // cerramos FormProductos devolviendo OK
        // ============================================================
        private void Detalle_AgregarAlCarrito(object sender, Libro libro)
        {
            if (libro == null) return;

            if (libro.Stock <= 0)
            {
                MessageBox.Show("No hay stock disponible de este libro.",
                    "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            libroSeleccionado = libro;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ============================================================
        // EVENTO: ProdDetalles dice "salir" → cerramos con Cancel
        // ============================================================
        private void Detalle_Salir(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ============================================================
        // EXPONER EL LIBRO SELECCIONADO
        // ============================================================
        public Libro ObtenerLibroSeleccionado()
        {
            return libroSeleccionado;
        }
    }
}