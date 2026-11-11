using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class AddProveedor : Form
    {
        private List<Proveedor> listaProveedores = new List<Proveedor>();
        private int idProveedorSeleccionado = 0;
        public Proveedor ProveedorSeleccionado { get; private set; } = null;
        public AddProveedor()
        {
            InitializeComponent();

            // Suscribimos los eventos
            this.Load += AddProveedor_Load;
            this.btnRegistrar.Click += btnRegistrar_Click;
            this.btnActualizar.Click += btnActualizar_Click;
            this.btnCancelar.Click += btnCancelar_Click;
            this.btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            

            // Validaciones de teclado
            this.txtCuit.KeyPress += SoloNumerosYGuiones_KeyPress;
            this.txtTelefono.KeyPress += SoloNumerosYGuiones_KeyPress;
        }

        // ============================================================
        // AL ABRIR EL FORMULARIO
        // ============================================================
        private void AddProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        // ============================================================
        // VALIDACIONES DE TECLADO
        // ============================================================
        // CUIT y Teléfono: solo números y guiones
        private void SoloNumerosYGuiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        // ============================================================
        // CARGAR GRILLA DE PROVEEDORES
        // ============================================================
        private void CargarProveedores()
        {
            try
            {
                ProveedorDatos datos = new ProveedorDatos();

                // Limpiamos el origen de datos anterior y le pasamos la lista nueva
                dgvProveedor.DataSource = null;
                dgvProveedor.DataSource = datos.ObtenerTodos();

                // Personalizamos las columnas para que se vean lindas
                if (dgvProveedor.Columns["id_proveedor"] != null)
                    dgvProveedor.Columns["id_proveedor"].Visible = false; // Ocultamos el ID

                if (dgvProveedor.Columns["cuit"] != null)
                    dgvProveedor.Columns["cuit"].HeaderText = "CUIT";

                if (dgvProveedor.Columns["nombre"] != null)
                    dgvProveedor.Columns["nombre"].HeaderText = "Nombre";

                if (dgvProveedor.Columns["razon_social"] != null)
                    dgvProveedor.Columns["razon_social"].HeaderText = "Razón Social";

                if (dgvProveedor.Columns["direccion"] != null)
                    dgvProveedor.Columns["direccion"].HeaderText = "Dirección";

                if (dgvProveedor.Columns["telefono"] != null)
                    dgvProveedor.Columns["telefono"].HeaderText = "Teléfono";

                if (dgvProveedor.Columns["mail"] != null)
                    dgvProveedor.Columns["mail"].HeaderText = "Email";

                // Ajustamos el ancho de las columnas para que ocupen todo el espacio
                dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // VALIDACIÓN GENERAL DE CAMPOS
        // ============================================================
        private bool ValidarCampos()
        {
            // 1. CUIT
            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("El campo 'CUIT' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuit.Focus();
                return false;
            }

            // Validación del CUIT: 11 dígitos (con o sin guiones)
            string cuit = txtCuit.Text.Replace("-", "").Replace(" ", "").Trim();

            if (!Regex.IsMatch(cuit, @"^\d{11}$"))
            {
                MessageBox.Show("El CUIT debe tener 11 dígitos (puede incluir guiones).\n" +
                                "Ejemplo: 20-12345678-9 o 20123456789",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuit.Focus();
                txtCuit.SelectAll();
                return false;
            }

            // 2. Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            // 3. Dirección
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo 'Dirección' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }

            // 4. Teléfono
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo 'Teléfono' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            // Validación del Teléfono: solo números y guiones, al menos 6 dígitos
            string telefono = txtTelefono.Text.Replace("-", "").Replace(" ", "").Trim();

            if (!Regex.IsMatch(telefono, @"^\d{6,}$"))
            {
                MessageBox.Show("El Teléfono debe tener al menos 6 dígitos (puede incluir guiones).",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                txtTelefono.SelectAll();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            // 2.1 Razón Social (NUEVO)
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("El campo 'Razón Social' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRazonSocial.Focus();
                return false;
            }

            return true;
        }

        // ============================================================
        // BOTÓN REGISTRAR
        // ============================================================
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que los campos estén completos y correctos
            if (!ValidarCampos())
                return;

            try
            {
                // 2. Armamos el objeto Proveedor con los datos de la pantalla
                Proveedor nuevo = new Proveedor
                {
                    cuit = txtCuit.Text.Trim(),
                    nombre = txtNombre.Text.Trim(),
                    razon_social = txtRazonSocial.Text.Trim(), // Asegurate de que el textbox se llame así
                    direccion = txtDireccion.Text.Trim(),
                    telefono = txtTelefono.Text.Trim(),
                    mail = txtMail.Text.Trim()                // Asegurate de que el textbox se llame así
                };

                // 3. Mandamos a guardar a la base de datos
                ProveedorDatos datos = new ProveedorDatos();
                bool exito = datos.Agregar(nuevo);

                // 4. Evaluamos el resultado
                if (exito)
                {
                    MessageBox.Show("¡Proveedor registrado correctamente!", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos(); // Vaciamos los textbox para el próximo registro
                    CargarProveedores(); // (Opcional) Si tenés el método para llenar la grilla, llamalo acá
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el proveedor en la base de datos.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Si SQL tira un error (ej: la columna no existe o hay un dato mal), cae acá
                MessageBox.Show("Error al registrar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BOTÓN ACTUALIZAR
        // ============================================================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que no haya campos vacíos
            if (!ValidarCampos())
                return;

            // 2. Verificamos que realmente haya seleccionado un proveedor de la grilla
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccioná un proveedor de la grilla (doble clic) antes de actualizar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Armamos el objeto con los datos modificados y el ID
                Proveedor provEditado = new Proveedor
                {
                    id_proveedor = idProveedorSeleccionado, // 👈 Asignamos el ID
                    cuit = txtCuit.Text.Trim(),
                    nombre = txtNombre.Text.Trim(),
                    razon_social = txtRazonSocial.Text.Trim(),
                    direccion = txtDireccion.Text.Trim(),
                    telefono = txtTelefono.Text.Trim(),
                    mail = txtMail.Text.Trim()
                };

                // 4. Mandamos a actualizar
                ProveedorDatos datos = new ProveedorDatos();
                bool exito = datos.Actualizar(provEditado);

                if (exito)
                {
                    MessageBox.Show("¡Proveedor actualizado correctamente!", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarProveedores(); // Refrescamos la grilla

                    idProveedorSeleccionado = 0; // Reseteamos el ID porque ya terminamos
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el proveedor.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BOTÓN CANCELAR
        // ============================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ============================================================
        // BOTÓN BUSCAR PROVEEDOR
        // ============================================================
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            try
            {
                ProveedorDatos datos = new ProveedorDatos();

                if (string.IsNullOrWhiteSpace(filtro))
                {
                    // Si está vacío, trae todos de nuevo
                    dgvProveedor.DataSource = datos.ObtenerTodos();
                }
                else
                {
                    // Si hay texto, busca en la base de datos
                    dgvProveedor.DataSource = datos.Buscar(filtro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProveedor.Rows[e.RowIndex];

            // Pasamos los datos a los TextBox para editar
            idProveedorSeleccionado = Convert.ToInt32(fila.Cells["id_proveedor"].Value);
            txtCuit.Text = fila.Cells["cuit"].Value.ToString();
            txtNombre.Text = fila.Cells["nombre"].Value.ToString();
            txtRazonSocial.Text = fila.Cells["razon_social"].Value.ToString();
            txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
            txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
            txtMail.Text = fila.Cells["mail"].Value.ToString();

            // (Opcional) Habilitar actualizar y deshabilitar registrar
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;

        }

        // ============================================================
        // LIMPIAR CAMPOS
        // ============================================================
        private void LimpiarCampos()
        {
            txtCuit.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtBuscar.Clear();
            txtMail.Clear();
            txtRazonSocial.Clear();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada
            if (dgvProveedor.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccioná un proveedor de la grilla primero.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Armamos el objeto con los datos del proveedor seleccionado
            DataGridViewRow fila = dgvProveedor.CurrentRow;

            ProveedorSeleccionado = new Proveedor
            {
                id_proveedor = Convert.ToInt32(fila.Cells["id_proveedor"].Value),
                cuit = fila.Cells["cuit"].Value?.ToString(),
                nombre = fila.Cells["nombre"].Value?.ToString(),
                razon_social = fila.Cells["razon_social"].Value?.ToString(),
                direccion = fila.Cells["direccion"].Value?.ToString(),
                telefono = fila.Cells["telefono"].Value?.ToString(),
                mail = fila.Cells["mail"].Value?.ToString()
            };

            // Cerramos el formulario avisando que todo salió bien
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}