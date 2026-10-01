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
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Determinar el ID del Rol según el RadioButton seleccionado
            int idRolSeleccionado = 0;

            if (RBadmin.Checked)
            {
                idRolSeleccionado = 1; // Reemplaza 1 por el ID real de Administrador en tu BD
            }
            else if (RBvendedor.Checked)
            {
                idRolSeleccionado = 2; // Reemplaza 2 por el ID real de Vendedor en tu BD
            }
            else if (RBrepositor.Checked)
            {
                idRolSeleccionado = 3; // Reemplaza 3 por el ID real de Repositor en tu BD
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Rol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Crear el objeto Usuario (Entidad)
            Usuario nuevoUser = new Usuario
            {
                nombre = TBnombre.Text,
                apellido = TBapellido.Text,
                mail = TBmail.Text,
                password_hash = TBpass.Text, // Recuerda: en producción esto debe ir encriptado
                username = TBusername.Text,
                id_rol = idRolSeleccionado
            };

            // 4. Enviar a la capa de Datos para guardar en SQL
            try
            {
                UsuarioDatos datos = new UsuarioDatos();
                bool exito = datos.Agregar(nuevoUser);

                if (exito)
                {
                    MessageBox.Show("Usuario guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de guardar
                    TBnombre.Clear();
                    TBapellido.Clear();
                    TBmail.Clear();
                    TBpass.Clear();
                    TBusername.Clear();

                    // Desmarcar los RadioButtons (opcional, pero buena práctica)
                    RBadmin.Checked = false;
                    RBvendedor.Checked = false;
                    RBrepositor.Checked = false;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            this.Close(); // O Application.Exit() si quieres cerrar todo
        }
        private void Lemail_Click(object sender, EventArgs e)
        {

        }
    }
}

