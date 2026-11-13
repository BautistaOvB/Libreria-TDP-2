using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class rteInventario : Form
    {
        private List<Libro> listaLibros;
        private int idLibroSeleccionado = 0;

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
            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAutor",
                HeaderText = "Autor",
                DataPropertyName = "autor"
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
                lTotalLibros.Text = listaLibros.Count.ToString();

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
                idLibroSeleccionado = libroSeleccionado.id_libro;
                txtISBN.Text = libroSeleccionado.ISBN;
                txtNombre.Text = libroSeleccionado.Nombre;
                txtStock.Text = libroSeleccionado.Stock.ToString();
                txtPrecio.Text = libroSeleccionado.Precio.ToString("N2");
                txtGenero.Text = libroSeleccionado.nombre_genero;
                txtAutor.Text = libroSeleccionado.autor;
            }
        }

        private void LimpiarCampos()
        {
            txtISBN.Clear();
            txtNombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtGenero.Clear();
            txtAutor.Clear();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (listaLibros == null) return;

            string filtro = txtBuscar.Text.Trim().ToLower();

            // Si el campo está vacío, mostramos todos los libros
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvStock.DataSource = null;
                dgvStock.DataSource = listaLibros;
            }
            else
            {
                // Filtramos por Nombre, ISBN o Autor
                var resultados = listaLibros.Where(l =>
                    (l.Nombre != null && l.Nombre.ToLower().Contains(filtro)) ||
                    (l.ISBN != null && l.ISBN.ToLower().Contains(filtro)) ||
                    (l.autor != null && l.autor.ToLower().Contains(filtro))
                ).ToList();

                dgvStock.DataSource = null;
                dgvStock.DataSource = resultados;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                MessageBox.Show("El nombre y el género son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validamos que haya seleccionado un libro
            if (idLibroSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccioná un libro de la grilla antes de actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Capturamos el texto del TextBox
                string nombreGenero = txtGenero.Text.Trim();

                // 4. Buscamos o creamos el género, y nos devuelve el ID
                LibroDatos libroDatos = new LibroDatos();
                int idGeneroFinal = libroDatos.ObtenerOCrearGenero(nombreGenero);

                // 5. Armamos el objeto Libro con el ID del género obtenido
                Libro libroEditado = new Libro
                {
                    id_libro = idLibroSeleccionado, // 👈 ACÁ USAMOS LA VARIABLE GLOBAL
                    ISBN = txtISBN.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Stock = Convert.ToInt32(txtStock.Text),
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    cod_genero = idGeneroFinal, // 👈 Usamos el ID (existente o nuevo)
                    autor = txtAutor.Text.Trim()
                };

                // 6. Mandamos a actualizar a la base de datos
                bool exito = libroDatos.Actualizar(libroEditado);

                if (exito)
                {
                    MessageBox.Show("¡Libro actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLibros(); // Recargamos la grilla

                    // Limpiamos el ID para evitar actualizaciones accidentales
                    idLibroSeleccionado = 0;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMasVendidos_Click(object sender, EventArgs e)
        {
            try
            {
                LibroDatos datos = new LibroDatos();
                // Traemos la lista ya ordenada desde SQL
                listaLibros = datos.ObtenerMasVendidos();

                dgvStock.DataSource = null;
                dgvStock.DataSource = listaLibros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar más vendidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMasCantidad_Click(object sender, EventArgs e)
        {
            if (listaLibros == null) return;

            // Ordenamos por Stock descendente (de mayor a menor)
            var librosOrdenados = listaLibros.OrderByDescending(l => l.Stock).ToList();

            dgvStock.DataSource = null;
            dgvStock.DataSource = librosOrdenados;
        
        }
    }
}