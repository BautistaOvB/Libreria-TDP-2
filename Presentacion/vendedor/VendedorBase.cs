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
    public partial class VendedorBase : Form
    {
        public VendedorBase()
        {
            InitializeComponent();
        }

        private void BtnRegistroVta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistroVta());
        }

        private void BtnCajeroProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Show();
        }

        private void PanelBotones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
