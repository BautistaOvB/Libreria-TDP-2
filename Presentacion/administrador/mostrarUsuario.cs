using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.administrador
{
    public partial class mostrarUsuario : Form
    {
        private int idUsuario;
        private Usuario usuarioActual;

        // Constructor que recibe el ID desde VerUsuarios
        public mostrarUsuario(int id)
        {
            InitializeComponent();
            this.idUsuario = id;
        }

        private void mostrarUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarDatosUsuario();
            BloquearCampos(); // Al abrir, todos los campos bloqueados
        }

        // Cargar los roles en el ComboBox
        private void CargarRoles()
        {
            try
            {
                UsuarioDatos datos = new UsuarioDatos();
                List<Rol> roles = datos.ObtenerRoles();

                cmbRol.DataSource = roles;
                cmbRol.DisplayMember = "nombre_rol";
                cmbRol.ValueMember = "id_rol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cargar los datos del usuario
        private void CargarDatosUsuario()
        {
            try
            {
                UsuarioDatos datos = new UsuarioDatos();
                usuarioActual = datos.ObtenerPorId(idUsuario);

                if (usuarioActual != null)
                {
                    // Si tienes un solo TextBox para nombre y apellido:
                    txtNombreCompleto.Text = usuarioActual.nombre + " " + usuarioActual.apellido;

                    // Si tienes dos TextBox separados, usa esto en su lugar:
                    // txtNombre.Text = usuarioActual.nombre;
                    // txtApellido.Text = usuarioActual.apellido;

                    txtEmail.Text = usuarioActual.mail;
                    txtUsername.Text = usuarioActual.username;
                    cmbRol.SelectedValue = usuarioActual.id_rol;

                    this.Text = "Usuario: " + usuarioActual.username;
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Bloquear campos (modo lectura)
        private void BloquearCampos()
        {
            txtNombreCompleto.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtUsername.ReadOnly = true;
            cmbRol.Enabled = false;

            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
        }

        // Desbloquear campos (modo edición)
        private void DesbloquearCampos()
        {
            txtNombreCompleto.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtUsername.ReadOnly = false;
            cmbRol.Enabled = true;

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;

            txtNombreCompleto.Focus();
        }

        // Botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            DesbloquearCampos();
        }

        // Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                cmbRol.SelectedValue == null)
            {
                MessageBox.Show("Complete todos los campos.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación
            DialogResult respuesta = MessageBox.Show(
                "¿Guardar los cambios?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                // Separar el nombre completo en nombre y apellido
                string nombreCompleto = txtNombreCompleto.Text.Trim();
                int primerEspacio = nombreCompleto.IndexOf(' ');

                if (primerEspacio > 0)
                {
                    usuarioActual.nombre = nombreCompleto.Substring(0, primerEspacio);
                    usuarioActual.apellido = nombreCompleto.Substring(primerEspacio + 1).Trim();
                }
                else
                {
                    usuarioActual.nombre = nombreCompleto;
                    usuarioActual.apellido = "";
                }

                usuarioActual.mail = txtEmail.Text.Trim();
                usuarioActual.username = txtUsername.Text.Trim();
                usuarioActual.id_rol = Convert.ToInt32(cmbRol.SelectedValue);

                // Guardar en BD
                UsuarioDatos datos = new UsuarioDatos();
                bool exito = datos.Actualizar(usuarioActual);

                if (exito)
                {
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BloquearCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Cerrar (si lo tienes)
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
