using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class addCliente : Form
    {
        public addCliente()
        {
            InitializeComponent();

            // --- Suscripción de eventos ---
            this.txtDNI.KeyPress += txtDNI_KeyPress;
            this.txtDNI.TextChanged += txtDNI_TextChanged;
            this.btnGuardar.Click += btnGuardar_Click;
            this.btnActualizar.Click += btnActualizar_Click;
            this.btnCancelar.Click += btnCancelar_Click;

            // Opcional: forzar que el teléfono también sea numérico
            this.txtTelefono.KeyPress += txtTelefono_KeyPress;
        }

        // ============================================================
        // VALIDACIÓN: Solo números en el DNI (bloquea letras al escribir)
        // ============================================================
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos (0-9) y teclas de control (Backspace, Delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea el carácter
            }
        }

        // ============================================================
        // VALIDACIÓN: Limitar el DNI a un máximo de 8 dígitos
        // ============================================================
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length > 8)
            {
                txtDNI.Text = txtDNI.Text.Substring(0, 8);
                txtDNI.SelectionStart = txtDNI.Text.Length;
            }
        }

        // ============================================================
        // VALIDACIÓN: Teléfono (números y guiones)
        // ============================================================
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, guiones y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        // ============================================================
        // VALIDACIÓN GENERAL: Todos los campos completos + Email válido
        // ============================================================
        private bool ValidarCampos()
        {
            // 1. Verificar que ningún campo esté vacío
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

            // 2. Validación específica del Email (debe contener @ y dominio)
            if (!ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("El Email no tiene un formato válido.\nEjemplo: usuario@dominio.com",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return false;
            }

            // 3. Validación del DNI (al menos 6 dígitos)
            if (txtDNI.Text.Length < 6)
            {
                MessageBox.Show("El DNI debe tener al menos 6 dígitos.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            // 4. Validación del Teléfono (solo números y guiones)
            if (!Regex.IsMatch(txtTelefono.Text, @"^[0-9\-]+$"))
            {
                MessageBox.Show("El Teléfono solo puede contener números y guiones.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            return true;
        }

        // ============================================================
        // VALIDACIÓN: Formato de Email con expresión regular
        // ============================================================
        private bool ValidarEmail(string email)
        {
            // Requiere: algo@algo.algo (con texto antes y después del @ y un punto)
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }

        // ============================================================
        // BOTÓN GUARDAR
        // ============================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Ejecutamos todas las validaciones
            if (!ValidarCampos())
                return;

            try
            {
                // Aquí va tu código para guardar el cliente
                // Ejemplo:
                // Cliente nuevo = new Cliente
                // {
                //     nombre = txtNombre.Text.Trim(),
                //     apellido = txtApellido.Text.Trim(),
                //     dni = txtDNI.Text.Trim(),
                //     direccion = txtDireccion.Text.Trim(),
                //     telefono = txtTelefono.Text.Trim(),
                //     email = txtEmail.Text.Trim()
                // };
                // ClienteDatos datos = new ClienteDatos();
                // datos.Agregar(nuevo);

                MessageBox.Show("Cliente guardado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BOTÓN ACTUALIZAR
        // ============================================================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Las mismas validaciones aplican
            if (!ValidarCampos())
                return;

            try
            {
                // Tu código para actualizar
                MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
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
        // Limpiar todos los campos
        // ============================================================
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {

        }
    }
}
