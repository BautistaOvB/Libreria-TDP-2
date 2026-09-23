using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.administrador
{
    public partial class Admin_Base : Form
    {
        public Admin_Base()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit(); // Cierra la app al cerrar esta ventana
        }

        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
