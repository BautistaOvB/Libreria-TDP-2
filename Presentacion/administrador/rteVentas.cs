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
    public partial class rteVentas : Form
    {
        public rteVentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'punto_Barra_pruebaDataSet1.Compra' Puede moverla o quitarla según sea necesario.
            this.compraTableAdapter.Fill(this.punto_Barra_pruebaDataSet1.Compra);

        }
    }
}
