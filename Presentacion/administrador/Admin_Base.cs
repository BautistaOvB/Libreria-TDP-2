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
        private Form formularioActivo = null;

        public Admin_Base()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        // 👇 Se ejecuta al abrir el form → muestra adminInicio embebido
        private void Admin_Base_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new adminInicio());
        }

        // 👇 Método reutilizable para embeber forms en el panel
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formHijo;

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.StartPosition = FormStartPosition.Manual;

            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        // 👇 Botones del menú lateral
        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new addUsuario());
        }

        private void VerUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new VerUsuarios());
        }

        private void BtnRptVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new rteVentas());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new rteInventario());
        }
    }
}