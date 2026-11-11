using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System.Drawing;
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class Pago : Form
    {
        private List<ItemCarrito> carrito;
        private decimal total;
        private int idCliente;
        private string nombreCliente;

        // 🔑 Para que RegistroVta sepa el ID de venta generado
        public int IdVentaGenerado { get; private set; } = 0;

        // ============================================================
        // CONSTRUCTOR: recibe el carrito
        // ============================================================
        public Pago(List<ItemCarrito> carritoRecibido, int idClienteRecibido, string nombreClienteRecibido)
        {
            InitializeComponent();

            carrito = carritoRecibido;
            idCliente = idClienteRecibido;
            nombreCliente = nombreClienteRecibido;

            // Calculamos el total
            total = 0;
            foreach (ItemCarrito item in carrito)
                total += item.Subtotal;

            // Suscribimos eventos
            this.Load += Pago_Load;
            this.cmbMetodo.SelectedIndexChanged += cmbMetodo_SelectedIndexChanged;
            this.btnConfirmar.Click += btnConfirmar_Click;
            this.btnCancelar.Click += btnCancelar_Click;

            this.txtNtarjeta.KeyPress += txtNtarjeta_KeyPress;
            this.txtCvv.KeyPress += txtCvv_KeyPress;
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

            HabilitarCamposTarjeta(false);

            txtCliente.Text = nombreCliente;
            txtCliente.ReadOnly = true;
            // Mostrar total en algún label
            // lblTotal.Text = "Total: $" + total.ToString("N2");
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
                FillWeight = 40
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBN",
                FillWeight = 20
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCantidad",
                HeaderText = "Cant.",
                DataPropertyName = "Cantidad",
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
                FillWeight = 15
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 15
            });
        }

        // ============================================================
        // CARGAMOS EL CARRITO EN LA GRILLA
        // ============================================================
        private void CargarCarrito()
        {
            // 🔑 Ahora usamos la clase ItemCarrito directamente,
            // pero creamos una lista anónima para que los nombres de
            // propiedades coincidan con DataPropertyName.
            var listaParaMostrar = new List<object>();

            foreach (ItemCarrito item in carrito)
            {
                listaParaMostrar.Add(new
                {
                    Nombre = item.Libro.Nombre,
                    ISBN = item.Libro.ISBN,
                    Cantidad = item.Cantidad,
                    Precio = item.Libro.Precio,
                    Subtotal = item.Subtotal
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

            MetodoPago metodo = (MetodoPago)cmbMetodo.SelectedItem;
            string nombre = metodo.nombre.ToLower();

            bool esTarjeta = nombre.Contains("tarjeta") || nombre.Contains("credito") ||
                             nombre.Contains("crédito") || nombre.Contains("debito") || nombre.Contains("débito");

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
                int idUsuario = Sesion.IdUsuario;
                int idMetodo = (int)cmbMetodo.SelectedValue;

                VentaDatos datos = new VentaDatos();

                // 1. Guardamos en la base de datos
                IdVentaGenerado = datos.RegistrarVentaConCantidades(idUsuario, idMetodo, idCliente, carrito);

                // 2. Le avisamos al usuario que la venta se registró (ANTES de imprimir)
                MessageBox.Show($"¡Venta #{IdVentaGenerado} registrada con éxito!\nTotal: {total:C2}",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Preparamos la impresión
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirFacturaCarrito_PrintPage);
                pd.DocumentName = $"Factura_{IdVentaGenerado}";

                // 4. Mostramos la vista previa
                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = pd;
                preview.Width = 800;
                preview.Height = 600;
                preview.ShowDialog();

                // 5. 🔑 CLAVE PARA CORTAR EL BUCLE: 
                // Forzamos el DialogResult ANTES de cerrar
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void ImprimirFacturaCarrito_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fontSubtitulo = new Font("Arial", 11, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 10, FontStyle.Regular);
            Font fontPequena = new Font("Arial", 8, FontStyle.Italic);
            Brush brush = Brushes.Black;

            float yPos = 20;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;

            // 1. Encabezado
            g.DrawString("PUNTO Y BARRA - LIBRERÍA", fontTitulo, brush, leftMargin, yPos);
            yPos += 25;
            g.DrawString("FACTURA DE VENTA", fontSubtitulo, brush, leftMargin, yPos);
            yPos += 30;

            // 2. Datos de la Venta
            g.DrawString($"N° Factura: {IdVentaGenerado}", fontNormal, brush, leftMargin, yPos);
            g.DrawString($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}", fontNormal, brush, leftMargin + 250, yPos);
            yPos += 20;
            g.DrawString($"Cliente: {nombreCliente}", fontNormal, brush, leftMargin, yPos);

            // Acá usamos el objeto 'metodo' que ya está seleccionado en el ComboBox
            MetodoPago metodoSeleccionado = (MetodoPago)cmbMetodo.SelectedItem;
            g.DrawString($"Método de Pago: {metodoSeleccionado.nombre}", fontNormal, brush, leftMargin + 250, yPos);
            yPos += 30;

            // 3. Línea separadora
            g.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 10;

            // 4. Cabecera de la tabla
            g.DrawString("Cant.", fontSubtitulo, brush, leftMargin, yPos);
            g.DrawString("Descripción", fontSubtitulo, brush, leftMargin + 50, yPos);

            SizeF sizeUnit = g.MeasureString("P. Unit.", fontSubtitulo);
            g.DrawString("P. Unit.", fontSubtitulo, brush, leftMargin + 380 - sizeUnit.Width, yPos);

            SizeF sizeSubtotal = g.MeasureString("Subtotal", fontSubtitulo);
            g.DrawString("Subtotal", fontSubtitulo, brush, rightMargin - sizeSubtotal.Width, yPos);

            yPos += 20;
            g.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 10;

            // 5. Filas de detalles (Acá iteramos sobre 'carrito' en vez de la BD)
            foreach (ItemCarrito item in carrito)
            {
                if (yPos > e.MarginBounds.Bottom - 50) break; // Control de página simple

                g.DrawString(item.Cantidad.ToString(), fontNormal, brush, leftMargin, yPos);

                // Recortar nombre si es muy largo
                string nombreLibro = item.Libro.Nombre;
                string nombreCorto = nombreLibro.Length > 50 ? nombreLibro.Substring(0, 47) + "..." : nombreLibro;

                g.DrawString(nombreCorto, fontNormal, brush, leftMargin + 50, yPos);

                // Precio Unitario
                string precioUnitStr = item.Libro.Precio.ToString("C2");
                SizeF sizePU = g.MeasureString(precioUnitStr, fontNormal);
                g.DrawString(precioUnitStr, fontNormal, brush, leftMargin + 380 - sizePU.Width, yPos);

                // Subtotal
                string subtotalStr = item.Subtotal.ToString("C2");
                SizeF sizeSub = g.MeasureString(subtotalStr, fontNormal);
                g.DrawString(subtotalStr, fontNormal, brush, rightMargin - sizeSub.Width, yPos);

                yPos += 20;
            }

            // 6. Total
            yPos += 10;
            g.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 20;

            Font fontTotal = new Font("Arial", 14, FontStyle.Bold);
            string totalStr = $"TOTAL: {total:C2}";
            SizeF sizeTotal = g.MeasureString(totalStr, fontTotal);
            g.DrawString(totalStr, fontTotal, brush, rightMargin - sizeTotal.Width, yPos);

            yPos += 50;

            // 7. Pie de página
            g.DrawString("¡Gracias por su compra!", fontPequena, brush, leftMargin, yPos);
            yPos += 15;
            g.DrawString("Punto y Barra | Librería", fontPequena, brush, leftMargin, yPos);
        }

        // ============================================================
        // CANCELAR
        // ============================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        // ============================================================
        // VALIDACIÓN: Solo números en N° Tarjeta
        // ============================================================
        private void txtNtarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitimos solo dígitos y teclas de control (Backspace, Delete, flechas, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla presionada
            }
        }

        // ============================================================
        // VALIDACIÓN: Solo números en CVV
        // ============================================================
        private void txtCvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitimos solo dígitos y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla presionada
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNtarjeta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}