using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class rteInventario : Form
    {
        private List<Libro> listaLibros;

        public rteInventario()
        {
            InitializeComponent();

            // Suscribimos el evento Load manualmente
            this.Load += rteInventario_Load;

            // Suscribimos el evento para detectar cuando se hace clic en una fila
            this.dgvStock.SelectionChanged += dgvStock_SelectionChanged;
        }

        private void rteInventario_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarLibros();
        }

        // ============================================================
        // CONFIGURAMOS LA GRILLA QUE YA EXISTE EN EL DISEÑADOR
        // ============================================================
        private void ConfigurarGrilla()
        {
            // Desactivamos la generación automática para definir columnas nosotros
            dgvStock.AutoGenerateColumns = false;
            dgvStock.AllowUserToAddRows = false;
            dgvStock.ReadOnly = true;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.MultiSelect = false;
            dgvStock.RowHeadersVisible = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Limpiamos columnas previas (por si acaso)
            dgvStock.Columns.Clear();

            // --- Definimos las columnas manualmente ---
            // El DataPropertyName DEBE coincidir con las propiedades de tu clase Libro

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBN"
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                HeaderText = "Stock",
                DataPropertyName = "Stock"
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecio",
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGenero",
                HeaderText = "Género",
                DataPropertyName = "nombre_genero"
            });
        }

        private void CargarLibros()
        {
            try
            {
                LibroDatos datos = new LibroDatos();
                listaLibros = datos.ObtenerTodos();

                dgvStock.DataSource = null;
                dgvStock.DataSource = listaLibros;

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // EVENTO: Al seleccionar una fila, llenar los TextBox
        // ============================================================
        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow != null && dgvStock.CurrentRow.DataBoundItem is Libro)
            {
                Libro libroSeleccionado = (Libro)dgvStock.CurrentRow.DataBoundItem;

                txtISBN.Text = libroSeleccionado.ISBN;
                txtNombre.Text = libroSeleccionado.Nombre;
                txtStock.Text = libroSeleccionado.Stock.ToString();
                txtPrecio.Text = libroSeleccionado.Precio.ToString("N2");
                txtGenero.Text = libroSeleccionado.nombre_genero;
            }
        }

        private void LimpiarCampos()
        {
            txtISBN.Clear();
            txtNombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtGenero.Clear();
        }

        // Botones (si tienes más, agrégalos aquí)
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}