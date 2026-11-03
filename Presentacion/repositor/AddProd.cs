using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Gestion_Libreria.Entidad;
using Gestion_Libreria.Datos;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class AddProd : Form
    {
        private LibroDatos libroDatos = new LibroDatos();
        private int idSeleccionado = 0;
        private proveedorDatos provDatos = new proveedorDatos();

        public AddProd()
        {
            InitializeComponent();

            this.Load += AddProd_Load;
            this.dgvLibros.CellClick += dgvLibros_CellClick;
            this.btnGuardar.Click += btnGuardar_Click;

            // Validaciones de teclado
            this.txtISBN.KeyPress += SoloNumerosYGuiones_KeyPress;
            this.txtStock.KeyPress += SoloNumeros_KeyPress;
            this.txtStockMin.KeyPress += SoloNumeros_KeyPress;
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

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock_min",
                HeaderText = "Stock_min",
                DataPropertyName = "Stock_min",
                FillWeight = 10
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAutor",
                HeaderText = "Autor",
                DataPropertyName = "Autor",
                FillWeight = 35
            });
        }

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


        private void CargarGeneros()
        {
            try
            {
                List<generos> lista = libroDatos.ObtenerGeneros();

                cmbGenero.DataSource = lista;
                cmbGenero.DisplayMember = "descripcion";
                cmbGenero.ValueMember = "cod_genero";
                cmbGenero.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar géneros: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Libro libroSeleccionado = (Libro)dgvLibros.Rows[e.RowIndex].DataBoundItem;
                if (libroSeleccionado == null) return;
                idSeleccionado = libroSeleccionado.id_libro;

                txtNombre.Text = libroSeleccionado.Nombre;
                txtISBN.Text = libroSeleccionado.ISBN;
                txtStock.Text = libroSeleccionado.Stock.ToString();
                txtStockMin.Text = libroSeleccionado.Stock_minimo.ToString();
                txtPrecio.Text = libroSeleccionado.Precio.ToString("N2");
                txtAutor.Text = libroSeleccionado.Autor;

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

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El campo 'Precio' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (cmbGenero.SelectedIndex < 0)
            {
                MessageBox.Show("Debés seleccionar al menos un 'Género'.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGenero.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El campo 'Autor' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
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
            int stock_min;
            if (!int.TryParse(txtStock.Text, out stock_min) || stock_min < 0)
            {
                MessageBox.Show("El stock minimo debe ser un número entero mayor o igual a 0.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStockMin.Focus();
                txtStockMin.SelectAll();
                return;
            }

            int stock;
            if (!int.TryParse(txtStock.Text, out stock) || stock < stock_min)
            {
                MessageBox.Show("La 'Cantidad' debe ser un número entero mayor o igual al stock minimo.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                txtStock.SelectAll();
                return;
            }
            try
            {
                Libro nuevo = new Libro
                {
                    Nombre = txtNombre.Text.Trim(),
                    ISBN = isbn,
                    Stock = stock,
                    Precio = precio,
                    Autor = txtAutor.Text.Trim(),
                    Stock_minimo = stock_min,
                    cod_genero = cmbGenero.SelectedIndex + 1 
                };

                // Guardar en Base de Datos
                libroDatos.Agregar(nuevo);

                MessageBox.Show("¡Libro agregado correctamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarLibros(); // Refrescar la grilla con el nuevo registro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtISBN.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            cmbGenero.SelectedIndex = -1;
            txtAutor.Clear();
            txtStockMin.Clear();
            txtNombre.Focus();
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

        private void LStock_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStockMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Debes seleccionar un libro de la tabla para modificar.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // [Realizar aquí las mismas validaciones de campos vacíos/formato que tienes en btnGuardar]

            try
            {
                Libro libroEditado = new Libro
                {
                    id_libro = idSeleccionado,
                    Nombre = txtNombre.Text.Trim(),
                    ISBN = txtISBN.Text.Replace("-", "").Replace(" ", "").Trim(),
                    Stock = Convert.ToInt32(txtStock.Text),
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Autor = txtAutor.Text.Trim(),
                    Stock_minimo = Convert.ToInt32(txtStockMin.Text),
                    cod_genero = Convert.ToInt32(cmbGenero.SelectedValue)
                };

                libroDatos.Modificar(libroEditado);

                MessageBox.Show("¡Libro actualizado con éxito!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarLibros(); // Refrescar grilla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Debes seleccionar un libro de la tabla para eliminar.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas eliminar este libro?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    libroDatos.Eliminar(idSeleccionado);

                    MessageBox.Show("¡Libro eliminado correctamente!", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarLibros(); // Refrescar grilla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}