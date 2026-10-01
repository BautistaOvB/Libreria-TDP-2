using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class Repositor_base : Form
    {
        public Repositor_base()
        {
            InitializeComponent();
        }

        private void Repositor_base_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnVerStock_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddProd_Click(object sender, EventArgs e)
        {
            AddProd formAgregar = new AddProd();
            formAgregar.ShowDialog();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            RIngresos formReporte = new RIngresos();
            formReporte.ShowDialog();
        }

        private void BtnNingreso_Click(object sender, EventArgs e)
        {
            compraLibro formReporte = new compraLibro();
            formReporte.ShowDialog();
        }
    }
}
