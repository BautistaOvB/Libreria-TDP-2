using Gestion_Libreria.Entidad;
using System;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class ProdDetalles : Form
    {
        private Libro libroActual;

        public event EventHandler<Libro> AgregarAlCarrito;
        public event EventHandler Salir;

        public ProdDetalles()
        {
            InitializeComponent();
        }

        public void CargarLibro(Libro libro)
        {
            if (libro == null) return;

            libroActual = libro;
            txtISBN.Text = libro.ISBN;
            txtTitulo.Text = libro.Nombre;
            txtGenero.Text = libro.nombre_genero;
            txtStock.Text = libro.Stock.ToString();
            txtPrecio.Text = libro.Precio.ToString("C2");
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (libroActual == null)
            {
                MessageBox.Show("Primero seleccioná un libro de la lista.");
                return;
            }

            AgregarAlCarrito?.Invoke(this, libroActual);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir?.Invoke(this, EventArgs.Empty);
        }
    }
}