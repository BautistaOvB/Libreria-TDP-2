using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.administrador
{
    public partial class VerUsuarios : Form
    {
        private List<Usuario> listaUsuarios;
        private List<Usuario> usuariosMostrados; // Lista actual visible (con filtro aplicado)
        private Form formularioActivo = null;
        public VerUsuarios()
        {
            InitializeComponent();
        }

        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
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
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void FiltrarUsuarios()
        {
            if (listaUsuarios == null) return;

            string filtro = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                usuariosMostrados = listaUsuarios;
            }
            else
            {
                usuariosMostrados = listaUsuarios.Where(u =>
                    (u.nombre ?? "").ToLower().Contains(filtro) ||
                    (u.apellido ?? "").ToLower().Contains(filtro) ||
                    (u.username ?? "").ToLower().Contains(filtro)
                ).ToList();
            }

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuariosMostrados;
            PersonalizarColumnas();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignorar clic en encabezado

            // ✅ Usar la lista de objetos, no las columnas del grid

            Usuario usuarioSeleccionado = usuariosMostrados[e.RowIndex];
            AbrirFormularioEnPanel(new mostrarUsuario(usuarioSeleccionado.id_usuario));

            CargarUsuarios();
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formHijo;

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.StartPosition = FormStartPosition.Manual;

            pContenedor.Controls.Clear();
            pContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignorar clic en encabezado

            // ✅ Usar la lista de objetos, no las columnas del grid
            Usuario usuarioSeleccionado = usuariosMostrados[e.RowIndex];
            AbrirFormularioEnPanel(new mostrarUsuario(usuarioSeleccionado.id_usuario));

            CargarUsuarios();
        }
    }
}