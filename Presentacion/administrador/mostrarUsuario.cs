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
    public partial class mostrarUsuario : Form
    {
        public mostrarUsuario()
        {
            InitializeComponent();
        }

        private void mostrarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'punto_Barra_tdpDataSet2.roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.punto_Barra_tdpDataSet2.roles);
            // TODO: esta línea de código carga datos en la tabla 'punto_Barra_tdpDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.punto_Barra_tdpDataSet.usuarios);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
