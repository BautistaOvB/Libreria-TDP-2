namespace Gestion_Libreria.Presentacion.vendedor
{
    partial class RegistroVta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVta));
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnIrAlPago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.pCabecera = new System.Windows.Forms.Panel();
            this.btnAgregarAlCarrito = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCantiad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblVenedor = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNyA = new System.Windows.Forms.TextBox();
            this.txtDNIcliente = new System.Windows.Forms.TextBox();
            this.lblClienteDNI = new System.Windows.Forms.Label();
            this.pDgvCarrito = new System.Windows.Forms.Panel();
            this.pResumen = new System.Windows.Forms.Panel();
            this.pCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.pResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Location = new System.Drawing.Point(32, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 18);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total a pagar: $";
            // 
            // btnIrAlPago
            // 
            this.btnIrAlPago.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIrAlPago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIrAlPago.Location = new System.Drawing.Point(821, 46);
            this.btnIrAlPago.Name = "btnIrAlPago";
            this.btnIrAlPago.Size = new System.Drawing.Size(84, 31);
            this.btnIrAlPago.TabIndex = 3;
            this.btnIrAlPago.Text = "Ir al pago";
            this.btnIrAlPago.UseVisualStyleBackColor = false;
            this.btnIrAlPago.Click += new System.EventHandler(this.btnIrAlPago_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(715, 46);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSubtotal.Location = new System.Drawing.Point(41, 53);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(65, 15);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "Subtotal: $";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarProducto.Location = new System.Drawing.Point(12, 121);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 44);
            this.btnBuscarProducto.TabIndex = 8;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // pCabecera
            // 
            this.pCabecera.Controls.Add(this.btnAgregarAlCarrito);
            this.pCabecera.Controls.Add(this.btnBuscar);
            this.pCabecera.Controls.Add(this.lblCantiad);
            this.pCabecera.Controls.Add(this.nudCantidad);
            this.pCabecera.Controls.Add(this.lblPrecio);
            this.pCabecera.Controls.Add(this.lblCantidad);
            this.pCabecera.Controls.Add(this.lblNombre);
            this.pCabecera.Controls.Add(this.txtPrecio);
            this.pCabecera.Controls.Add(this.txtStock);
            this.pCabecera.Controls.Add(this.txtProducto);
            this.pCabecera.Controls.Add(this.txtFecha);
            this.pCabecera.Controls.Add(this.lblFecha);
            this.pCabecera.Controls.Add(this.textBox2);
            this.pCabecera.Controls.Add(this.lblVenedor);
            this.pCabecera.Controls.Add(this.lblNombreCompleto);
            this.pCabecera.Controls.Add(this.txtNyA);
            this.pCabecera.Controls.Add(this.btnBuscarProducto);
            this.pCabecera.Controls.Add(this.txtDNIcliente);
            this.pCabecera.Controls.Add(this.lblClienteDNI);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(938, 187);
            this.pCabecera.TabIndex = 10;
            // 
            // btnAgregarAlCarrito
            // 
            this.btnAgregarAlCarrito.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarAlCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlCarrito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarAlCarrito.Location = new System.Drawing.Point(830, 132);
            this.btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            this.btnAgregarAlCarrito.Size = new System.Drawing.Size(75, 43);
            this.btnAgregarAlCarrito.TabIndex = 24;
            this.btnAgregarAlCarrito.Text = "Agregar al Carrito";
            this.btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarAlCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(242, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 38);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblCantiad
            // 
            this.lblCantiad.AutoSize = true;
            this.lblCantiad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCantiad.Location = new System.Drawing.Point(588, 121);
            this.lblCantiad.Name = "lblCantiad";
            this.lblCantiad.Size = new System.Drawing.Size(49, 13);
            this.lblCantiad.TabIndex = 22;
            this.lblCantiad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(564, 144);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(110, 20);
            this.nudCantidad.TabIndex = 21;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPrecio.Location = new System.Drawing.Point(457, 121);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 20;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCantidad.Location = new System.Drawing.Point(328, 121);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(35, 13);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Stock";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNombre.Location = new System.Drawing.Point(145, 126);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(429, 144);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(297, 144);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 16;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(107, 145);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(161, 20);
            this.txtProducto.TabIndex = 15;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(460, 10);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(126, 20);
            this.txtFecha.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFecha.Location = new System.Drawing.Point(374, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha de Venta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 12;
            // 
            // lblVenedor
            // 
            this.lblVenedor.AutoSize = true;
            this.lblVenedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVenedor.Location = new System.Drawing.Point(29, 13);
            this.lblVenedor.Name = "lblVenedor";
            this.lblVenedor.Size = new System.Drawing.Size(110, 13);
            this.lblVenedor.TabIndex = 11;
            this.lblVenedor.Text = "Nombre del Vendedor";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNombreCompleto.Location = new System.Drawing.Point(362, 53);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(92, 13);
            this.lblNombreCompleto.TabIndex = 10;
            this.lblNombreCompleto.Text = "Apellido y Nombre";
            // 
            // txtNyA
            // 
            this.txtNyA.Location = new System.Drawing.Point(460, 50);
            this.txtNyA.Name = "txtNyA";
            this.txtNyA.Size = new System.Drawing.Size(138, 20);
            this.txtNyA.TabIndex = 9;
            // 
            // txtDNIcliente
            // 
            this.txtDNIcliente.Location = new System.Drawing.Point(107, 53);
            this.txtDNIcliente.Name = "txtDNIcliente";
            this.txtDNIcliente.Size = new System.Drawing.Size(129, 20);
            this.txtDNIcliente.TabIndex = 7;
            // 
            // lblClienteDNI
            // 
            this.lblClienteDNI.AutoSize = true;
            this.lblClienteDNI.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblClienteDNI.Location = new System.Drawing.Point(26, 57);
            this.lblClienteDNI.Name = "lblClienteDNI";
            this.lblClienteDNI.Size = new System.Drawing.Size(61, 13);
            this.lblClienteDNI.TabIndex = 6;
            this.lblClienteDNI.Text = "DNI Cliente";
            // 
            // pDgvCarrito
            // 
            this.pDgvCarrito.BackColor = System.Drawing.Color.SteelBlue;
            this.pDgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgvCarrito.Location = new System.Drawing.Point(0, 187);
            this.pDgvCarrito.Name = "pDgvCarrito";
            this.pDgvCarrito.Size = new System.Drawing.Size(938, 196);
            this.pDgvCarrito.TabIndex = 11;
            // 
            // pResumen
            // 
            this.pResumen.Controls.Add(this.btnIrAlPago);
            this.pResumen.Controls.Add(this.lblSubtotal);
            this.pResumen.Controls.Add(this.btnCancelar);
            this.pResumen.Controls.Add(this.lblTotal);
            this.pResumen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pResumen.Location = new System.Drawing.Point(0, 383);
            this.pResumen.Name = "pResumen";
            this.pResumen.Size = new System.Drawing.Size(938, 100);
            this.pResumen.TabIndex = 12;
            // 
            // RegistroVta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(938, 483);
            this.Controls.Add(this.pDgvCarrito);
            this.Controls.Add(this.pCabecera);
            this.Controls.Add(this.pResumen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroVta";
            this.Text = "Punto Barra | Registrar Venta";
            this.Load += new System.EventHandler(this.FormRegistrarVenta_Load);
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.pResumen.ResumeLayout(false);
            this.pResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnIrAlPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.Panel pDgvCarrito;
        private System.Windows.Forms.Panel pResumen;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblVenedor;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNyA;
        private System.Windows.Forms.TextBox txtDNIcliente;
        private System.Windows.Forms.Label lblClienteDNI;
        private System.Windows.Forms.Label lblCantiad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarAlCarrito;
    }
}