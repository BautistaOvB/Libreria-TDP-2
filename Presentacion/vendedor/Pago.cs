using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class Pago : Form
    {
        private List<Libro> carrito;
        private decimal total;

        // ============================================================
        // CONSTRUCTOR: recibe el carrito
        // ============================================================
        public Pago(List<Libro> carritoRecibido)
        {
            InitializeComponent();

            carrito = carritoRecibido;

            // Calculamos el total
            total = 0;
            foreach (Libro l in carrito)
                total += l.Precio;

            // Suscribimos eventos
            this.Load += Pago_Load;
            this.cmbMetodo.SelectedIndexChanged += cmbMetodo_SelectedIndexChanged;
            //this.btnPagar.Click += btnPagar_Click;
            this.btnCancelar.Click += btnCancelar_Click;
        }

        // ============================================================
        // AL ABRIR EL FORMULARIO
        // ============================================================
        private void Pago_Load(object sender, EventArgs e)
        {
            ConfigurarGrillaCarrito();
            CargarCarrito();
            CargarMetodosPago();
            CargarClientes();

            // Al principio, los campos de tarjeta están deshabilitados
            HabilitarCamposTarjeta(false);

            // Mostramos el total
            
        }

        // ============================================================
        // CONFIGURAMOS LAS COLUMNAS DE dgvCarrito
        // ============================================================
        private void ConfigurarGrillaCarrito()
        {
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.ReadOnly = true;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCarrito.Columns.Clear();

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Libro",
                DataPropertyName = "Nombre",
                FillWeight = 45
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBN",
                FillWeight = 25
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCantidad",
                HeaderText = "Cant.",
                DataPropertyName = "cantidad",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                FillWeight = 10
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecio",
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 20
            });
        }

        // ============================================================
        // CARGAMOS EL CARRITO EN LA GRILLA
        // ============================================================
        private void CargarCarrito()
        {
            // ⚠️ Como tu clase Libro no tiene la propiedad "cantidad" (siempre es 1),
            // usamos una lista anónima para agregar ese campo
            var listaParaMostrar = new List<object>();
            foreach (Libro l in carrito)
            {
                listaParaMostrar.Add(new
                {
                    Nombre = l.Nombre,
                    ISBN = l.ISBN,
                    cantidad = 1,
                    Precio = l.Precio
                });
            }

            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = listaParaMostrar;
        }

        // ============================================================
        // CARGAMOS LOS MÉTODOS DE PAGO
        // ============================================================
        private void CargarMetodosPago()
        {
            try
            {
                VentaDatos datos = new VentaDatos();
                List<MetodoPago> metodos = datos.ObtenerMetodosPago();

                cmbMetodo.DataSource = metodos;
                cmbMetodo.DisplayMember = "nombre";
                cmbMetodo.ValueMember = "id_metodo";
                cmbMetodo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar métodos de pago: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // CARGAMOS LOS CLIENTES
        // ============================================================
        private void CargarClientes()
        {
            try
            {
                // ⚠️ Si todavía no tenés ClienteDatos, cargamos opciones manuales
                cmbCliente.Items.Clear();
                cmbCliente.Items.Add("Consumidor Final");
                cmbCliente.SelectedIndex = 0;

                // Cuando tengas ClienteDatos:
                // ClienteDatos datos = new ClienteDatos();
                // List<Cliente> clientes = datos.ObtenerTodos();
                // cmbCliente.DataSource = clientes;
                // cmbCliente.DisplayMember = "nombre";
                // cmbCliente.ValueMember = "id_cliente";
                // cmbCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        // ============================================================
        // CAMBIO DE MÉTODO DE PAGO
        // ============================================================
        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedItem == null) return;

            MetodoPago metodo = (MetodoPago)cmbMetodo.SelectedItem;
            string nombre = metodo.nombre.ToLower();

            bool esTarjeta = nombre.Contains("tarjeta") ||
                             nombre.Contains("credito") ||
                             nombre.Contains("crédito") ||
                             nombre.Contains("debito") ||
                             nombre.Contains("débito");

            HabilitarCamposTarjeta(esTarjeta);
        }

        private void HabilitarCamposTarjeta(bool habilitar)
        {
            txtNtarjeta.Enabled = habilitar;
            txtTitular.Enabled = habilitar;
            txtCvv.Enabled = habilitar;

            if (!habilitar)
            {
                txtNtarjeta.Clear();
                txtTitular.Clear();
                txtCvv.Clear();
            }
        }

        // ============================================================
        // CONFIRMAR PAGO
        // ============================================================
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedIndex < 0)
            {
                MessageBox.Show("Debés seleccionar un método de pago.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMetodo.Focus();
                return;
            }

            if (cmbCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Debés seleccionar un cliente.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCliente.Focus();
                return;
            }

            MetodoPago metodo = (MetodoPago)cmbMetodo.SelectedItem;
            string nombre = metodo.nombre.ToLower();

            bool esTarjeta = nombre.Contains("tarjeta") ||
                             nombre.Contains("credito") ||
                             nombre.Contains("crédito") ||
                             nombre.Contains("debito") ||
                             nombre.Contains("débito");

            if (esTarjeta)
            {
                if (string.IsNullOrWhiteSpace(txtNtarjeta.Text) ||
                    string.IsNullOrWhiteSpace(txtTitular.Text) ||
                    string.IsNullOrWhiteSpace(txtCvv.Text))
                {
                    MessageBox.Show("Completá todos los datos de la tarjeta.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                int idUsuario = 1; // ⚠️ Cambiar por el usuario logueado
                int idMetodo = (int)cmbMetodo.SelectedValue;

                VentaDatos datos = new VentaDatos();
                int idVenta = datos.RegistrarVenta(idUsuario, idMetodo, carrito);

                MessageBox.Show($"¡Venta #{idVenta} registrada con éxito!\n" +
                                $"Total: ${total:N2}",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // CANCELAR
        // ============================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}