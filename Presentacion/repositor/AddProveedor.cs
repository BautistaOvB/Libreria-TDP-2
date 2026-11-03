using Gestion_Libreria.Datos;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class AddProveedor : Form
    {

        private proveedorDatos provDatos = new proveedorDatos();
        private int idProveedorSeleccionado = 0;
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
            ConfigurarGrilla();
            CargarProveedores();
        }
        private void ConfigurarGrilla()
        {
            dgvProveedor.AutoGenerateColumns = false;
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.ReadOnly = true;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.MultiSelect = false;
            dgvProveedor.RowHeadersVisible = false;
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProveedor.Columns.Clear();

            dgvProveedor.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", DataPropertyName = "idProveedor", FillWeight = 10 });
            dgvProveedor.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCuit", HeaderText = "CUIT", DataPropertyName = "Cuit", FillWeight = 25 });
            dgvProveedor.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre", DataPropertyName = "nombre", FillWeight = 35 });
            dgvProveedor.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDireccion", HeaderText = "Dirección", DataPropertyName = "Direccion", FillWeight = 30 });
            dgvProveedor.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTelefono", HeaderText = "Teléfono", DataPropertyName = "telefono", FillWeight = 25 });
        }

        private void CargarProveedores()
        {
            try
            {
                List<Proveedor> lista = provDatos.ObtenerTodos();
                dgvProveedor.DataSource = null;
                dgvProveedor.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            return true;
        }

        // ============================================================
        // BOTÓN REGISTRAR
        // ============================================================
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            // ✅ Validaciones pasadas. Acá iría el INSERT cuando lo tengas listo.
            MessageBox.Show("¡Proveedor registrado correctamente!\n\n" +
                            "(Nota: la inserción en base de datos se habilitará próximamente.)",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
             try
            {
                 Proveedor nuevo = new Proveedor
                 {
                     Cuit = txtCuit.Text.Trim(),
                     nombre = txtNombre.Text.Trim(),
                     Direccion = txtDireccion.Text.Trim(),
                     telefono = txtTelefono.Text.Trim()
                 };
                provDatos.Agregar(nuevo);
                MessageBox.Show("¡Proveedor registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarProveedores();
            }
             catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BOTÓN ACTUALIZAR
        // ============================================================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un proveedor de la tabla para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCampos()) return;

            try
            {
                Proveedor editado = new Proveedor
                {
                    idProveedor = idProveedorSeleccionado,
                    Cuit = txtCuit.Text.Trim(),
                    nombre = txtNombre.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    telefono = txtTelefono.Text.Trim()
                };

                provDatos.Modificar(editado);
                MessageBox.Show("¡Proveedor actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // ⚠️ Acá podés implementar la búsqueda por CUIT o por nombre
            // Por ahora, solo mostramos un mensaje
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Ingresá un CUIT o nombre para buscar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Focus();
                return;
            }

            MessageBox.Show("Búsqueda de: " + txtBuscar.Text + "\n\n" +
                            "(La búsqueda en BD se habilitará próximamente.)",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtCuit.Focus();
        }

        private void btnBuscarProveedor_Click_1(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtBuscar.Text.Trim();
                List<Proveedor> lista = provDatos.BuscarPorNombre(filtro);
                dgvProveedor.DataSource = null;
                dgvProveedor.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Proveedor provSeleccionado = (Proveedor)dgvProveedor.Rows[e.RowIndex].DataBoundItem;
                if (provSeleccionado == null) return;

                idProveedorSeleccionado = provSeleccionado.idProveedor;
                txtCuit.Text = provSeleccionado.Cuit;
                txtNombre.Text = provSeleccionado.nombre;
                txtDireccion.Text = provSeleccionado.Direccion;
                txtTelefono.Text = provSeleccionado.telefono;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar proveedor: " + ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un proveedor de la tabla para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCampos()) return;

            try
            {
                Proveedor editado = new Proveedor
                {
                    idProveedor = idProveedorSeleccionado,
                    Cuit = txtCuit.Text.Trim(),
                    nombre = txtNombre.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    telefono = txtTelefono.Text.Trim()
                };

                provDatos.Modificar(editado);
                MessageBox.Show("¡Proveedor actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}