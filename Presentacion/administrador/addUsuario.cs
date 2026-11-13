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
        private List<Usuario> listaUsuarios;
        private List<Usuario> usuariosMostrados;
        public addUsuario()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar que TODOS los campos de texto no estén vacíos (incluyendo los que faltaban)
            if (string.IsNullOrWhiteSpace(TBnombre.Text) ||
                string.IsNullOrWhiteSpace(TBapellido.Text) ||
                string.IsNullOrWhiteSpace(TBmail.Text) ||
                string.IsNullOrWhiteSpace(TBpass.Text) ||
                string.IsNullOrWhiteSpace(TBusername.Text) ||
                string.IsNullOrWhiteSpace(TBDni.Text) ||      // <--- Agregado
                string.IsNullOrWhiteSpace(TBtelefono.Text) || // <--- Agregado (asumiendo nombre TBtelefono)
                string.IsNullOrWhiteSpace(TBdireccion.Text))  // <--- Agregado (asumiendo nombre TBdireccion)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que el DNI tenga la longitud correcta (ejemplo: 8 dígitos)
            if (TBDni.Text.Length < 7 || TBDni.Text.Length > 8)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 números.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBDni.Focus();
                return;
            }

            // 3. Validar el formato del email
            if (!EsEmailValido(TBmail.Text))
            {
                MessageBox.Show("Ingrese un email válido (debe contener '@' y '.').",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBmail.Focus();
                return;
            }

            // 4. Validar que la contraseña tenga al menos 8 caracteres
            if (TBpass.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBpass.Focus();
                return;
            }

            // 5. Determinar el ID del Rol
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

            // 6. Crear el objeto Usuario
            // NOTA: Asegúrate de que tu clase 'Usuario' tenga las propiedades para DNI, Telefono y Direccion.
            // Si tu base de datos no tiene estos campos, deberías agregarlos.
            Usuario nuevoUser = new Usuario
            {
                nombre = TBnombre.Text.Trim(),
                apellido = TBapellido.Text.Trim(),
                mail = TBmail.Text.Trim(),
                password_hash = TBpass.Text,
                username = TBusername.Text.Trim(),
                id_rol = idRolSeleccionado,
                // Descomenta y asigna estas líneas si tu entidad Usuario las tiene:
                // dni = TBDni.Text.Trim(),
                // telefono = TBtelefono.Text.Trim(),
                // direccion = TBdireccion.Text.Trim()
            };

            // 7. Guardar
            try
            {
                UsuarioDatos datos = new UsuarioDatos();
                // Aquí asumo que tu método Agregar recibe el objeto y lo inserta.
                bool exito = datos.Agregar(nuevoUser);

                if (exito)
                {
                    MessageBox.Show("Usuario guardado exitosamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    TBnombre.Clear();
                    TBapellido.Clear();
                    TBmail.Clear();
                    TBpass.Clear();
                    TBusername.Clear();
                    TBDni.Clear();       // <--- Limpiar
                    TBtelefono.Clear();  // <--- Limpiar
                    TBdireccion.Clear(); // <--- Limpiar

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

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos (0-9) y la tecla Backspace (para borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                MessageBox.Show("Solo se permiten números en el DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                UsuarioDatos datos = new UsuarioDatos();
                listaUsuarios = datos.ObtenerTodos();
                usuariosMostrados = listaUsuarios;

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = usuariosMostrados;
                PersonalizarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonalizarColumnas()
        {
            // Ajusta el ancho de todas las columnas para que entren en el espacio disponible
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ocultar columnas que no queremos mostrar
            if (dgvUsuarios.Columns["id_usuario"] != null)
                dgvUsuarios.Columns["id_usuario"].Visible = false;

            if (dgvUsuarios.Columns["password_hash"] != null)
                dgvUsuarios.Columns["password_hash"].Visible = false;

            if (dgvUsuarios.Columns["id_rol"] != null)
                dgvUsuarios.Columns["id_rol"].Visible = false;

            // Encabezados amigables
            if (dgvUsuarios.Columns["nombre"] != null)
                dgvUsuarios.Columns["nombre"].HeaderText = "Nombre";

            if (dgvUsuarios.Columns["apellido"] != null)
                dgvUsuarios.Columns["apellido"].HeaderText = "Apellido";

            if (dgvUsuarios.Columns["mail"] != null)
                dgvUsuarios.Columns["mail"].HeaderText = "Email";

            if (dgvUsuarios.Columns["username"] != null)
                dgvUsuarios.Columns["username"].HeaderText = "Usuario";

            // ⚠️ El nombre de la columna auto-generada es "nombre_rol", NO "colRol"
            if (dgvUsuarios.Columns["nombre_rol"] != null)
                dgvUsuarios.Columns["nombre_rol"].HeaderText = "Rol";

            if (dgvUsuarios.Columns["dni"] != null)
            {
                dgvUsuarios.Columns["dni"].HeaderText = "DNI";
                dgvUsuarios.Columns["dni"].Visible = true; // Aseguramos que se vea
            }

            if (dgvUsuarios.Columns["direccion"] != null)
                dgvUsuarios.Columns["direccion"].HeaderText = "Dirección";

            if (dgvUsuarios.Columns["numero_telefono"] != null)
                dgvUsuarios.Columns["numero_telefono"].HeaderText = "Teléfono";

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

        private void addUsuario_Load(object sender, EventArgs e)
        {

        }

        private void lTelefono_Click(object sender, EventArgs e)
        {

        }
    }
}

