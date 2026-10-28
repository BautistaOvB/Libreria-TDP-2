using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using Gestion_Libreria.Presentacion; 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class RegistroVta : Form
    {
        private List<ItemCarrito> carrito = new List<ItemCarrito>();
        private VentaDatos vtaDatos = new VentaDatos();
        private Libro libroActual;
        private int idClienteSeleccionado = 0;

        public RegistroVta()
        {
            InitializeComponent();
        }

        // ============================================================
        // LOAD
        // ============================================================
        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            // 🔑 Inicializar NumericUpDown
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 1000;
            nudCantidad.Value = 1;
            txtNombreVendedor.Text = Sesion.Nombre + " " + Sesion.Apellido;
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // 🔑 Configurar grilla acá, ya con el panel con tamaño real
            ConfigurarGrilla();
            RefrescarCarrito();
        }

        // ============================================================
        // CONFIGURAR GRILLA DENTRO DE pDgvCarrito
        // ============================================================
        private void ConfigurarGrilla()
        {
            if (pDgvCarrito == null)
            {
                MessageBox.Show("❌ pDgvCarrito es null.");
                return;
            }

            // Limpiar el panel por si ya tiene algo
            pDgvCarrito.Controls.Clear();

            DataGridView dgv = new DataGridView();

            dgv.Name = "dgvCarrito";
            dgv.Dock = DockStyle.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;

            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colLibro", HeaderText = "Libro", FillWeight = 35 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colISBN", HeaderText = "ISBN", FillWeight = 20 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCantidad", HeaderText = "Cantidad", FillWeight = 10 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPrecio", HeaderText = "Precio", FillWeight = 15 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubtotal", HeaderText = "Subtotal", FillWeight = 15 });
            dgv.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colAccion",
                HeaderText = "Acción",
                Text = "Quitar",
                UseColumnTextForButtonValue = true,
                FillWeight = 15,
                FlatStyle = FlatStyle.Flat
            });

            dgv.CellContentClick += dgvCarrito_CellContentClick;

            pDgvCarrito.Controls.Add(dgv);
            dgv.BringToFront();
        }

        private DataGridView ObtenerGrilla()
        {
            foreach (Control c in pDgvCarrito.Controls)
            {
                if (c is DataGridView dgv && dgv.Name == "dgvCarrito")
                    return dgv;
            }
            return null;
        }

        // ============================================================
        // BUSCAR PRODUCTO
        // ============================================================
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (FormProductos frmProductos = new FormProductos())
            {
                frmProductos.ModoSeleccion = true;
                if (frmProductos.ShowDialog() == DialogResult.OK)
                {
                    libroActual = frmProductos.ObtenerLibroSeleccionado();

                    if (libroActual != null)
                    {
                        txtProducto.Text = libroActual.Nombre;
                        txtStock.Text = libroActual.Stock.ToString();
                        txtPrecio.Text = libroActual.Precio.ToString("N2");
                        nudCantidad.Value = 1;   // 🔑 resetear cantidad
                        nudCantidad.Focus();
                    }
                }
            }
        }

        // ============================================================
        // AGREGAR AL CARRITO
        // ============================================================
        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (libroActual == null)
            {
                MessageBox.Show("Primero buscá un producto.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ItemCarrito itemExistente = carrito.FirstOrDefault(i => i.Libro.id_libro == libroActual.id_libro);

            int cantidadYaEnCarrito = itemExistente?.Cantidad ?? 0;
            int cantidadTotal = cantidadYaEnCarrito + cantidad;

            if (cantidadTotal > libroActual.Stock)
            {
                int stockDisponible = libroActual.Stock - cantidadYaEnCarrito;
                MessageBox.Show($"Stock insuficiente. Disponible: {stockDisponible}.",
                    "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itemExistente != null)
            {
                itemExistente.Cantidad = cantidadTotal;
            }
            else
            {
                carrito.Add(new ItemCarrito
                {
                    Libro = libroActual,
                    Cantidad = cantidad
                });
            }

            RefrescarCarrito();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            libroActual = null;
            txtProducto.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            nudCantidad.Value = 1;
            txtDNIcliente.Text = "";
            txtApellidoNombre.Text = "";
        }

        // ============================================================
        // REFRESCAR CARRITO
        // ============================================================
        private void RefrescarCarrito()
        {
            DataGridView dgv = ObtenerGrilla();
            if (dgv == null) return;

            dgv.Rows.Clear();

            decimal subtotal = 0;

            foreach (ItemCarrito item in carrito)
            {
                dgv.Rows.Add(
                    item.Libro.Nombre,
                    item.Libro.ISBN,
                    item.Cantidad,
                    item.Libro.Precio.ToString("N2"),
                    item.Subtotal.ToString("N2"),
                    "Quitar"
                );

                subtotal += item.Subtotal;
            }

            lblSubtotal.Text = "Subtotal: $" + subtotal.ToString("N2");
            lblTotal.Text = "Total a pagar: $" + subtotal.ToString("N2");
        }

        // ============================================================
        // QUITAR LIBRO DEL CARRITO
        // ============================================================
        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dgv = ObtenerGrilla();
            if (dgv == null) return;

            if (dgv.Columns[e.ColumnIndex].Name == "colAccion")
            {
                DialogResult r = MessageBox.Show(
                    "¿Quitar este libro del carrito?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    carrito.RemoveAt(e.RowIndex);
                    RefrescarCarrito();
                }
            }
        }

        // ============================================================
        // CANCELAR
        // ============================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============================================================
        // IR AL PAGO
        // ============================================================
        private void btnIrAlPago_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccioná o creá un cliente antes de continuar con el pago.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNIcliente.Focus(); // Ponemos el foco en el DNI para que sea más rápido
                return;
            }
            string nombreCliente = txtApellidoNombre.Text; // "Apellido, Nombre"

            // Si pasa ambas validaciones, abre el formulario de Pago
            using (Pago frmPago = new Pago(carrito, idClienteSeleccionado, nombreCliente))
            {
                if (frmPago.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"¡Venta #{frmPago.IdVentaGenerado} registrada con éxito!",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carrito.Clear();
                    RefrescarCarrito();
                    LimpiarCampos();

                }

            }  
               
            
        }

        public List<ItemCarrito> ObtenerCarrito()
        {
            return carrito;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            using (addCliente frmNuevo = new addCliente())
            {
                frmNuevo.ModoBusqueda = false; // 🔑 Modo normal (muestra pDatos)

                if (frmNuevo.ShowDialog() == DialogResult.OK)
                {
                    // Si guardó un cliente nuevo, podés cargarlo automáticamente en la venta
                    Cliente cliente = frmNuevo.ClienteSeleccionado;
                    if (cliente != null)
                    {
                        idClienteSeleccionado = cliente.id_cliente; 
                        txtDNIcliente.Text = cliente.dni;
                        txtApellidoNombre.Text = cliente.apellido + ", " + cliente.nombre;
                    }
                }
            }
        }

    private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // Creamos el formulario en modo búsqueda
            using (addCliente frmBuscar = new addCliente())
            {
                frmBuscar.ModoBusqueda = true; // 🔑 Activamos el modo búsqueda (oculta pDatos)

                // Mostramos el formulario como diálogo
                if (frmBuscar.ShowDialog() == DialogResult.OK)
                {
                    // Recuperamos el cliente seleccionado
                    Cliente cliente = frmBuscar.ClienteSeleccionado;

                    if (cliente != null)
                    {
                        idClienteSeleccionado = cliente.id_cliente;
                        // 🔑 Cargamos los datos en los TextBox de RegistroVta
                        txtDNIcliente.Text = cliente.dni;
                        txtApellidoNombre.Text = cliente.apellido + ", " + cliente.nombre;

                        // Opcional: Guardar el ID del cliente en una variable privada para usarlo al pagar
                        // idClienteSeleccionado = cliente.id_cliente;
                    }
                }
            }
        }
    }    
}
