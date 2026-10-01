using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.administrador
{
    public partial class rteInventario : Form
    {
        private List<Libro> listaLibros;

        public rteInventario()
        {
            InitializeComponent();
            this.Load += rteInventario_Load;
        }

        private void rteInventario_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarLibros();
        }

        private void ConfigurarGrilla()
        {
            dgvStock.AutoGenerateColumns = false;
            dgvStock.AllowUserToAddRows = false;
            dgvStock.ReadOnly = true;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.MultiSelect = false;
            dgvStock.RowHeadersVisible = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvStock.Columns["colPrecio"] != null)
                dgvStock.Columns["colPrecio"].DefaultCellStyle.Format = "C2";
        }

        private void CargarLibros()
        {
            try
            {
                LibroDatos datos = new LibroDatos();
                listaLibros = datos.ObtenerTodos();

                dgvStock.DataSource = null;
                dgvStock.DataSource = listaLibros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void rteInventario_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'punto_Barra_tdpDataSet1.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.punto_Barra_tdpDataSet1.libros);

        }
    }
}