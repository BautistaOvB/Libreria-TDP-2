using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class AddProveedor : Form
    {
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
            // Podés dejar esto vacío o cargar algo inicial
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

            // Cuando tengas ProveedorDatos:
            // try
            // {
            //     Proveedor nuevo = new Proveedor
            //     {
            //         cuit = txtCuit.Text.Trim(),
            //         descripcion = txtNombre.Text.Trim(),
            //         direccion = txtDireccion.Text.Trim(),
            //         telefono = txtTelefono.Text.Trim()
            //     };
            //     ProveedorDatos datos = new ProveedorDatos();
            //     datos.Agregar(nuevo);
            //     CargarProveedores();
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show("Error al registrar: " + ex.Message);
            // }
        }

        // ============================================================
        // BOTÓN ACTUALIZAR
        // ============================================================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            // ✅ Validaciones pasadas. Acá iría el UPDATE cuando lo tengas listo.
            MessageBox.Show("¡Proveedor actualizado correctamente!\n\n" +
                            "(Nota: la actualización en base de datos se habilitará próximamente.)",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
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

        }
    }
}