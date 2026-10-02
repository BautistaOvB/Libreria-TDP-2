using System;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class Repositor_base : Form
    {
        private Form formularioActivo = null;

        public Repositor_base()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        // ============================================================
        // AL ABRIR EL FORMULARIO
        // ============================================================
        private void Repositor_base_Load(object sender, EventArgs e)
        {
            
        }

        // ============================================================
        // MÉTODO REUTILIZABLE PARA EMBEBER FORMULARIOS EN EL PANEL
        // ============================================================
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

        // ============================================================
        // BOTONES DEL MENÚ LATERAL
        // ============================================================
        private void BtnAddProd_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new AddProd());
        }

        // Si tenés un botón para ver las ventas, descomentá esto:
        // private void BtnVentas_Click(object sender, EventArgs e)
        // {
        //     AbrirFormularioEnPanel(new reporteIngresos());
        // }

        // ============================================================
        // EVENTOS RESIDUALES DEL DISEÑADOR (no hacen nada)
        // ============================================================
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint_1(object sender, PaintEventArgs e) { }

        private void BtnVerStock_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new rteInventario());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RIngresos());
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new AddProveedor());
        }

        private void BtnEgresos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new reporteEgresos());
        }
    }
}