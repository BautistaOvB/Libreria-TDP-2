using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class addCliente : Form
    {
        private ClienteDatos clienteDatos = new ClienteDatos();

        // 0 = insertando, >0 = editando ese cliente
        private int idClienteActual = 0;
        private Cliente clienteActual;
        private string dniOriginalAlSeleccionar = ""; // 🔑 Para validar cambios de DNI

        public bool ModoBusqueda { get; set; } = false;

        public Cliente ClienteSeleccionado { get; private set; }

        public addCliente()
        {
            InitializeComponent();

            this.txtTelefono.KeyPress += txtTelefono_KeyPress;

            // 🔑 Enganchamos el click de la grilla
            this.dgvClientes.CellClick += dgvClientes_CellClick;
        }

        private void addCliente_Load(object sender, EventArgs e)
        {
            if (ModoBusqueda)
            {
                pDatos.Visible = false;
            }

            CargarClientes();
        }

        // ============================================================
        // CARGA DE GRILLA
        // ============================================================
        private void CargarClientes()
        {
            try
            {
                List<Cliente> lista = clienteDatos.ObtenerTodos();

                dgvClientes.AutoGenerateColumns = true;
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = lista;

                if (dgvClientes.Columns["id_cliente"] != null)
                    dgvClientes.Columns["id_cliente"].Visible = false;
                if (dgvClientes.Columns["mail"] != null)
                    dgvClientes.Columns["mail"].HeaderText = "Correo";
                if (dgvClientes.Columns["numero_telefono"] != null)
                    dgvClientes.Columns["numero_telefono"].HeaderText = "Teléfono";
                if (dgvClientes.Columns["dni"] != null)
                    dgvClientes.Columns["dni"].HeaderText = "DNI";
                if (dgvClientes.Columns["nombre"] != null)
                    dgvClientes.Columns["nombre"].HeaderText = "Nombre";
                if (dgvClientes.Columns["apellido"] != null)
                    dgvClientes.Columns["apellido"].HeaderText = "Apellido";
                if (dgvClientes.Columns["direccion"] != null)
                    dgvClientes.Columns["direccion"].HeaderText = "Dirección";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // ============================================================
        // CLICK EN LA GRILLA → carga los datos en los textbox
        // ============================================================
        // 🔑 Agregar una variable para guardar el cliente seleccionado

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Cliente c = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;
                if (c == null) return;

                clienteActual = c;
                idClienteActual = c.id_cliente;
                dniOriginalAlSeleccionar = c.dni; // 🔑 Guardamos el DNI original

                txtNombre.Text = c.nombre;
                txtApellido.Text = c.apellido;
                txtDNI.Text = c.dni;
                txtDireccion.Text = c.direccion;
                txtTelefono.Text = c.numero_telefono;
                txtEmail.Text = c.mail;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar cliente: " + ex.Message);
            }
        }

        // 🔑 MÉTODO PARA EL BOTÓN SELECCIONAR
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (clienteActual == null)
            {
                MessageBox.Show("Primero seleccioná un cliente de la grilla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClienteSeleccionado = clienteActual;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ============================================================
        // VALIDACIONES
        // ============================================================
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length > 8)
            {
                txtDNI.Text = txtDNI.Text.Substring(0, 8);
                txtDNI.SelectionStart = txtDNI.Text.Length;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo 'Apellido' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El campo 'DNI' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo 'Dirección' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo 'Teléfono' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El campo 'Email' es obligatorio.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("El Email no tiene un formato válido.\nEjemplo: usuario@dominio.com",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return false;
            }

            if (txtDNI.Text.Length < 6)
            {
                MessageBox.Show("El DNI debe tener al menos 6 dígitos.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtTelefono.Text, @"^[0-9\-]+$"))
            {
                MessageBox.Show("El Teléfono solo puede contener números y guiones.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarEmail(string email)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }

        // ============================================================
        // GUARDAR (INSERT)
        // ============================================================
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            // 🔑 Si hay un cliente seleccionado, avisarle que use Actualizar
            if (idClienteActual > 0)
            {
                MessageBox.Show("Estás modificando un cliente existente. Usá el botón 'Actualizar' para guardar los cambios.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validar DNI duplicado (solo para nuevos)
                if (clienteDatos.ExisteDni(txtDNI.Text.Trim()))
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI.", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDNI.Focus();
                    return;
                }

                Cliente nuevo = new Cliente
                {
                    dni = txtDNI.Text.Trim(),
                    nombre = txtNombre.Text.Trim(),
                    apellido = txtApellido.Text.Trim(),
                    mail = txtEmail.Text.Trim(),
                    direccion = txtDireccion.Text.Trim(),
                    numero_telefono = txtTelefono.Text.Trim()
                };

                clienteDatos.Insertar(nuevo);

                MessageBox.Show("Cliente guardado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // ACTUALIZAR (UPDATE)
        // ============================================================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (idClienteActual == 0 || clienteActual == null)
            {
                MessageBox.Show("Seleccioná un cliente de la grilla para actualizar.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 🔑 VALIDACIÓN CLAVE: Si cambió el DNI, verificar que el nuevo no esté en uso
                string nuevoDni = txtDNI.Text.Trim();

                if (nuevoDni != dniOriginalAlSeleccionar && clienteDatos.ExisteDni(nuevoDni))
                {
                    MessageBox.Show("Ya existe otro cliente registrado con ese DNI.", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDNI.Focus();
                    return;
                }

                Cliente c = new Cliente
                {
                    id_cliente = idClienteActual,
                    dni = nuevoDni,
                    nombre = txtNombre.Text.Trim(),
                    apellido = txtApellido.Text.Trim(),
                    mail = txtEmail.Text.Trim(),
                    direccion = txtDireccion.Text.Trim(),
                    numero_telefono = txtTelefono.Text.Trim()
                };

                clienteDatos.Actualizar(c);

                MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔑 Limpiamos pero NO recargamos el idClienteActual a 0 hasta el final
                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // CANCELAR
        // ============================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ============================================================
        // LIMPIAR
        // ============================================================
        private void LimpiarCampos()
        {
            idClienteActual = 0;
            clienteActual = null;                  // 🔑 Limpiamos el objeto
            dniOriginalAlSeleccionar = "";         // 🔑 Limpiamos el DNI original

            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }

        // ============================================================
        // BUSCAR POR DNI
        // ============================================================
        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtBuscarDNI.Text.Trim();   // 👈 CAMBIAR SI SE LLAMA DISTINTO

                List<Cliente> lista = string.IsNullOrWhiteSpace(dni)
                    ? clienteDatos.ObtenerTodos()
                    : clienteDatos.BuscarPorDni(dni);

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // ============================================================
        // BUSCAR POR APELLIDO
        // ============================================================
        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            try
            {
                string apellido = txtBuscarApellido.Text.Trim();  // 👈 CAMBIAR SI SE LLAMA DISTINTO

                List<Cliente> lista = string.IsNullOrWhiteSpace(apellido)
                    ? clienteDatos.ObtenerTodos()
                    : clienteDatos.BuscarPorApellido(apellido);

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}