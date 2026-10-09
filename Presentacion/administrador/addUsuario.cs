using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Libreria.Entidad; // Asegúrate de tener esta referencia
using Gestion_Libreria.Datos;   // Asegúrate de tener esta referencia

namespace Gestion_Libreria.Presentacion.administrador
{
    public partial class addUsuario : Form
    {
        public addUsuario()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos de texto no estén vacíos
            if (string.IsNullOrWhiteSpace(TBnombre.Text) ||
                string.IsNullOrWhiteSpace(TBapellido.Text) ||
                string.IsNullOrWhiteSpace(TBmail.Text) ||
                string.IsNullOrWhiteSpace(TBpass.Text) ||
                string.IsNullOrWhiteSpace(TBusername.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar el formato del email (debe tener @ y .)
            if (!EsEmailValido(TBmail.Text))
            {
                MessageBox.Show("Ingrese un email válido (debe contener '@' y '.').",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBmail.Focus();
                return;
            }

            // 3. Validar que la contraseña tenga al menos 8 caracteres
            if (TBpass.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBpass.Focus();
                return;
            }

            // 4. Determinar el ID del Rol según el RadioButton seleccionado
            int idRolSeleccionado = 0;

            if (RBadmin.Checked)
                idRolSeleccionado = 1;
            else if (RBvendedor.Checked)
                idRolSeleccionado = 2;
            else if (RBrepositor.Checked)
                idRolSeleccionado = 3;
            else
            {
                MessageBox.Show("Por favor, seleccione un Rol.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Crear el objeto Usuario
            Usuario nuevoUser = new Usuario
            {
                nombre = TBnombre.Text.Trim(),
                apellido = TBapellido.Text.Trim(),
                mail = TBmail.Text.Trim(),
                password_hash = TBpass.Text, // ⚠️ en producción: encriptar
                username = TBusername.Text.Trim(),
                id_rol = idRolSeleccionado
            };

            // 6. Guardar
            try
            {
                UsuarioDatos datos = new UsuarioDatos();
                bool exito = datos.Agregar(nuevoUser);

                if (exito)
                {
                    MessageBox.Show("Usuario guardado exitosamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TBnombre.Clear();
                    TBapellido.Clear();
                    TBmail.Clear();
                    TBpass.Clear();
                    TBusername.Clear();

                    RBadmin.Checked = false;
                    RBvendedor.Checked = false;
                    RBrepositor.Checked = false;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el usuario.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error Crítico",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            this.Close(); // O Application.Exit() si quieres cerrar todo
        }
        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            // Debe tener @ y al menos un . después del @
            int posArroba = email.IndexOf('@');
            if (posArroba <= 0) return false;                  // no hay @ o está al inicio
            if (posArroba == email.Length - 1) return false;   // @ al final

            string dominio = email.Substring(posArroba + 1);

            // El dominio debe tener al menos un punto y no estar al inicio/final
            if (!dominio.Contains(".")) return false;
            if (dominio.StartsWith(".") || dominio.EndsWith(".")) return false;

            return true;
        }
       
    }
}

