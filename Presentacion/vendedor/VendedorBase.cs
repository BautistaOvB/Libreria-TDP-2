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
            this.FormClosed += (s, e) => Application.Exit();

        }

        private void abrirFormularioEnPanel(Form formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(formHijo);
            this.PanelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void BtnRegistroVta_Click(object sender, EventArgs e)
        {
            abrirFormularioEnPanel(new RegistroVta());
        }

        private void BtnCajeroProductos_Click(object sender, EventArgs e)
        {
            abrirFormularioEnPanel(new FormProductos());
        }

        private void PanelBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRteVtaCajero_Click(object sender, EventArgs e)
        {
            abrirFormularioEnPanel(new reporteVentas());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            abrirFormularioEnPanel(new addCliente());
        }
    }
}
