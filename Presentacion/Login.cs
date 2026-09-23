using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using Gestion_Libreria.Presentacion;
using Gestion_Libreria.Presentacion.administrador;
using Gestion_Libreria.Presentacion.vendedor;
using Gestion_Libreria.Presentacion.repositor;
using System;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // 1. Validar campos vacíos
            if (string.IsNullOrWhiteSpace(usernameText.Text) ||
                string.IsNullOrWhiteSpace(PassText.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Llamar a la capa de Datos
                UsuarioDatos datos = new UsuarioDatos();
                Usuario userLogueado = datos.Loguear(usernameText.Text.Trim(),
                                                     PassText.Text.Trim());

                // 3. Verificar si el usuario existe
                if (userLogueado != null)
                {
                    // 4. Guardar datos en la Sesión
                    Sesion.IdUsuario = userLogueado.id_usuario;
                    Sesion.NombreUsuario = userLogueado.username;
                    Sesion.NombreRol = userLogueado.nombre_rol;
                    Sesion.IdRol = userLogueado.id_rol;

                    // 5. Redirigir según el Rol
                    AbrirVentanaPorRol(Sesion.NombreRol);

                    // 6. Ocultar el login
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                                    "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PassText.Clear();
                    PassText.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Crítico",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirVentanaPorRol(string rol)
        {
            // ⚠ Ajusta los nombres de los formularios a los tuyos reales
            switch (rol)
            {
                case "Administrador":
                    Admin_Base frmAdmin = new Admin_Base();
                    frmAdmin.Show();
                    break;

                case "Vendedor":
                    VendedorBase frmVentas = new VendedorBase();
                    frmVentas.Show();
                    break;

                case "Repositor":
                    Repositor_base frmRepo = new Repositor_base();
                    frmRepo.Show();
                    break;

                default:
                    MessageBox.Show("Rol no reconocido: " + rol, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir de la aplicación?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Presionar ENTER en el campo contraseña para ingresar
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnIngresar_Click(sender, e);
            }
        }
    }
}