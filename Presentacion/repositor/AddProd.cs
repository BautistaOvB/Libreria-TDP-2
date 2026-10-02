using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class AddProd : Form
    {
        private LibroDatos libroDatos = new LibroDatos();

        public AddProd()
        {
            InitializeComponent();

            this.Load += AddProd_Load;
            this.dgvLibros.CellClick += dgvLibros_CellClick;
            this.btnGuardar.Click += btnGuardar_Click;
            this.btnSalir.Click += btnSalir_Click;

            // Validaciones de teclado
            this.txtISBN.KeyPress += SoloNumerosYGuiones_KeyPress;
            this.txtStock.KeyPress += SoloNumeros_KeyPress;
            this.txtPrecio.KeyPress += SoloNumerosYComa_KeyPress;
        }

        // ============================================================
        // AL ABRIR EL FORMULARIO
        // ============================================================
        private void AddProd_Load(object sender, EventArgs e)
        {
            ConfigurarGrillaLibros();
            CargarLibros();
            CargarGeneros();
        }

        // ============================================================
        // CONFIGURAMOS LAS COLUMNAS DE dgvLibros
        // ============================================================
        private void ConfigurarGrillaLibros()
        {
            dgvLibros.AutoGenerateColumns = false;
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.ReadOnly = true;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.MultiSelect = false;
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvLibros.Columns.Clear();

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID",
                HeaderText = "ID",
                DataPropertyName = "id_libro",
                FillWeight = 10
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBN",
                FillWeight = 25
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                FillWeight = 35
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGenero",
                HeaderText = "Género",
                DataPropertyName = "nombre_genero",
                FillWeight = 20
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                FillWeight = 10
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecio",
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 15
            });
        }

        // ============================================================
        // CARGAMOS LOS LIBROS DESDE LA BASE DE DATOS
        // ============================================================
        private void CargarLibros()
        {
            try
            {
                List<Libro> lista = libroDatos.ObtenerTodos();

                dgvLibros.DataSource = null;
                dgvLibros.DataSource = lista;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No hay libros registrados en la base de datos.",
                                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // CARGAMOS LOS GÉNEROS EN EL COMBOBOX
        // ============================================================
        private void CargarGeneros()
        {
            try
            {
                cmbGenero.Items.Clear();
                cmbGenero.Items.Add("Ficción");
                cmbGenero.Items.Add("Ciencia");
                cmbGenero.Items.Add("Historia");
                cmbGenero.Items.Add("Infantil");
                cmbGenero.Items.Add("Novela");
                cmbGenero.Items.Add("Poesía");
                cmbGenero.SelectedIndex = -1;

                // Cuando tengas ObtenerGeneros() en LibroDatos, reemplazá lo de arriba por:
                // List<generos> lista = libroDatos.ObtenerGeneros();
                // cmbGenero.DataSource = lista;
                // cmbGenero.DisplayMember = "descripcion";
                // cmbGenero.ValueMember = "cod_genero";
                // cmbGenero.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar géneros: " + ex.Message);
            }
        }

        // ============================================================
        // AL HACER CLIC EN UNA FILA, CARGAR LOS DATOS EN LOS TEXTBOX
        // ============================================================
        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Libro libroSeleccionado = (Libro)dgvLibros.Rows[e.RowIndex].DataBoundItem;
                if (libroSeleccionado == null) return;

                txtNombre.Text = libroSeleccionado.Nombre;
                txtISBN.Text = libroSeleccionado.ISBN;
                txtStock.Text = libroSeleccionado.Stock.ToString();
                txtPrecio.Text = libroSeleccionado.Precio.ToString("N2");
                txtEditorial.Text = ""; // Todavía no hay campo editorial en la BD

                // Seleccionar el género en el ComboBox
                if (!string.IsNullOrEmpty(libroSeleccionado.nombre_genero))
                {
                    int index = cmbGenero.FindStringExact(libroSeleccionado.nombre_genero);
                    if (index >= 0)
                        cmbGenero.SelectedIndex = index;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar libro: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // VALIDACIONES AL GUARDAR (sin insertar en BD todavía)
        // ============================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Verificar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("El campo 'Código / ISBN' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("El campo 'Cantidad' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEditorial.Text))
            {
                MessageBox.Show("El campo 'Editorial' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditorial.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El campo 'Precio' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (cmbGenero.SelectedIndex < 0)
            {
                MessageBox.Show("Debés seleccionar un 'Género'.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGenero.Focus();
                return;
            }

            // 2. Validación del formato del ISBN (10 o 13 dígitos)
            string isbn = txtISBN.Text.Replace("-", "").Replace(" ", "").Trim();

            if (!Regex.IsMatch(isbn, @"^\d{10}$") && !Regex.IsMatch(isbn, @"^\d{13}$"))
            {
                MessageBox.Show("El ISBN debe tener 10 o 13 dígitos (puede incluir guiones).\n" +
                                "Ejemplo: 978-3-16-148410-0 o 3161484100",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtISBN.Focus();
                txtISBN.SelectAll();
                return;
            }

            // 3. Validación del Precio
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("El 'Precio' debe ser un número mayor a 0.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                txtPrecio.SelectAll();
                return;
            }

            // 4. Validación de la Cantidad
            int stock;
            if (!int.TryParse(txtStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("La 'Cantidad' debe ser un número entero mayor o igual a 0.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                txtStock.SelectAll();
                return;
            }

            // ============================================================
            // ¡TODO OK! Mostramos el modal pero NO insertamos en BD todavía
            // ============================================================
            MessageBox.Show("¡Libro agregado correctamente!", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();

            // ⚠️ CUANDO TENGAS LA EDITORIAL EN LA BD, DESCOMENTÁ ESTO:
            //
            // try
            // {
            //     Libro nuevo = new Libro
            //     {
            //         Nombre = txtNombre.Text.Trim(),
            //         ISBN = isbn,
            //         Stock = stock,
            //         Precio = precio,
            //         cod_genero = cmbGenero.SelectedIndex + 1 // Ajustar según tu BD
            //     };
            //
            //     libroDatos.Agregar(nuevo);
            //     CargarLibros(); // Refrescamos la grilla
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show("Error al guardar: " + ex.Message);
            // }
        }

        // ============================================================
        // LIMPIAR CAMPOS
        // ============================================================
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtISBN.Clear();
            txtStock.Clear();
            txtEditorial.Clear();
            txtPrecio.Clear();
            cmbGenero.SelectedIndex = -1;
            txtNombre.Focus();
        }

        // ============================================================
        // BOTÓN SALIR
        // ============================================================
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============================================================
        // VALIDACIONES DE TECLADO
        // ============================================================
        private void SoloNumerosYGuiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void SoloNumerosYComa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
                e.Handled = true;

            if ((e.KeyChar == ',' || e.KeyChar == '.') &&
                (txtPrecio.Text.Contains(",") || txtPrecio.Text.Contains(".")))
                e.Handled = true;
        }

        private void Lnombre_prod_Click(object sender, EventArgs e)
        {
            // Evento residual del diseñador, no hace nada
        }
    }
}