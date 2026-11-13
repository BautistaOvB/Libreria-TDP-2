using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class AddLibro : Form
    {
        private LibroDatos libroDatos = new LibroDatos();
        private List<ItemCarrito> carrito = new List<ItemCarrito>();
        private decimal totalCompra = 0;
        private int idProveedorSeleccionado = 0;
        public AddLibro()
        {
            InitializeComponent();

            this.Load += AddProd_Load;
            this.dgvLibros.CellClick += dgvLibros_CellClick;
            

            // Validaciones de teclado
            this.txtISBN.KeyPress += SoloNumerosYGuiones_KeyPress;
            this.txtCantidad.KeyPress += SoloNumeros_KeyPress;
            this.txtPrecio.KeyPress += SoloNumerosYComa_KeyPress;
            this.dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
        }

        // ============================================================
        // AL ABRIR EL FORMULARIO
        // ============================================================
        private void AddProd_Load(object sender, EventArgs e)
        {
            ConfigurarGrillaLibros();
            ConfigurarGrillaCarrito();
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
        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya hecho clic en la columna "Quitar" y no en el encabezado
            if (e.RowIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "colQuitar")
            {
                // Confirmación opcional (por si se equivocan)
                DialogResult result = MessageBox.Show("¿Seguro que querés quitar este libro del carrito?",
                                                      "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Eliminamos el ítem de la lista usando el índice de la fila
                    carrito.RemoveAt(e.RowIndex);

                    // Refrescamos la grilla y el total
                    ActualizarCarrito();
                }
            }
        }
        // ============================================================
        // CARGAMOS LOS GÉNEROS EN EL COMBOBOX
        // ============================================================
        private void CargarGeneros()
        {
            try
            {
                LibroDatos datos = new LibroDatos();
                List<generos> lista = datos.ObtenerGeneros(); // 👈 List<generos>

                cmbGenero.DataSource = lista;
                cmbGenero.DisplayMember = "descripcion";
                cmbGenero.ValueMember = "cod_genero";
                cmbGenero.SelectedIndex = -1;
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
                txtCantidad.Text = libroSeleccionado.Stock.ToString();
                txtPrecio.Text = libroSeleccionado.Precio.ToString("N2");


                // Seleccionar el género en el ComboBox
                if (libroSeleccionado.cod_genero > 0)
                {
                    cmbGenero.SelectedValue = libroSeleccionado.cod_genero;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar libro: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

            
        private void ConfigurarGrillaCarrito()
        {
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.ReadOnly = true;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCarrito.Columns.Clear();

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Libro",
                DataPropertyName = "Libro.Nombre",
                FillWeight = 50
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCantidad",
                HeaderText = "Cant.",
                DataPropertyName = "Cantidad",
                FillWeight = 20
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecio",
                HeaderText = "Precio",
                DataPropertyName = "PrecioUnitario",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" },
                FillWeight = 15
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" },
                FillWeight = 15
            });
            dgvCarrito.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colQuitar",
                HeaderText = "",
                Text = "Quitar",
                UseColumnTextForButtonValue = true, // Para que todos los botones digan "Quitar"
                FillWeight = 20,
                FlatStyle = FlatStyle.Flat
            });
        }
        private void ActualizarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;

            totalCompra = carrito.Sum(item => item.Subtotal);
            lTotal.Text = "Total de la compra: " + totalCompra.ToString("C2");
        }
        // ============================================================
        // LIMPIAR CAMPOS
        // ============================================================
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtISBN.Clear();
            txtCantidad.Clear();
            txtAutor.Clear();
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

        private void btnAddCarrito_Click(object sender, EventArgs e)
        {
            // 1. Validaciones: Si falta ALGÚN campo, avisamos y cortamos la ejecución
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, completá el Nombre, ISBN, Cantidad y Precio.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 👈 Esto es clave: si falta algo, sale del método y NO ejecuta el try
            }

            try
            {
                // 2. Extraemos los datos (ya sabemos que están llenos)
                string isbn = txtISBN.Text.Trim();
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                string nombreLibro = txtNombre.Text.Trim();
                string autorLibro = txtAutor.Text.Trim();

                // Validamos que haya elegido un género
                if (cmbGenero.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccioná un género.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idGenero = Convert.ToInt32(cmbGenero.SelectedValue);

                // 3. Creamos el ítem para el carrito
                ItemCarrito nuevoItem = new ItemCarrito
                {
                    Cantidad = cantidad,
                    Libro = new Libro
                    {
                        ISBN = isbn,
                        Nombre = nombreLibro,
                        Stock = cantidad,
                        Precio = precio,
                        cod_genero = idGenero,
                        autor = autorLibro
                    }
                };

                // 4. Lo agregamos a la lista y actualizamos la vista
                carrito.Add(nuevoItem);
                ActualizarCarrito();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar al carrito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validamos que haya seleccionado un proveedor
            if (string.IsNullOrWhiteSpace(txtProveedor.Text) || idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un proveedor antes de confirmar la compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CompraDatos datos = new CompraDatos();

                // Usamos la variable global idProveedorSeleccionado
                bool exito = datos.RegistrarCompraCompleta(idProveedorSeleccionado, totalCompra, carrito);

                if (exito)
                {
                    MessageBox.Show("¡Compra registrada con éxito y stock actualizado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiamos el carrito y refrescamos la grilla de la izquierda
                    carrito.Clear();
                    ActualizarCarrito();
                    CargarLibros();

                    // Limpiamos el proveedor y el ID para la próxima compra
                    txtProveedor.Clear();
                    idProveedorSeleccionado = 0;
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (AddProveedor frmProv = new AddProveedor())
            {
                // Lo abrimos de forma modal para que bloquee el fondo
                if (frmProv.ShowDialog() == DialogResult.OK)
                {
                    Proveedor provElegido = frmProv.ProveedorSeleccionado;

                    if (provElegido != null)
                    {
                        // Llenamos el textbox con el nombre
                        txtProveedor.Text = provElegido.nombre;
                        txtMostrarEditorial.Text = provElegido.nombre;

                        // 🔑 ACÁ GUARDAMOS EL ID EN LA VARIABLE GLOBALcar
                        idProveedorSeleccionado = provElegido.id_proveedor;
                    }
                }
            }
        }
        

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}