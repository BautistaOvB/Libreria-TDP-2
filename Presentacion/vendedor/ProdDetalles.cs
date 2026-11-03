using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class ProdDetalles : Form
    {
        public ProdDetalles()
        {
            InitializeComponent();
        }
        public void CargarLibro(Libro libro)
        {
            if (libro == null) return;

            txtISBN.Text = libro.ISBN;
            txtTitulo.Text = libro.Nombre;
            txtGenero.Text = libro.nombre_genero;
            txtStock.Text = libro.Stock.ToString();
            txtPrecio.Text = libro.Precio.ToString("C2");
        }
    }
}
