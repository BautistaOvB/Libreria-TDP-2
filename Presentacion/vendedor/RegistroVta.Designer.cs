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
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnIrAlPago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lTotalPrecio = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.pCabecera = new System.Windows.Forms.Panel();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCantiad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblVenedor = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDNIcliente = new System.Windows.Forms.TextBox();
            this.lblClienteDNI = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.pCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(0, 187);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(938, 196);
            this.dgvCarrito.TabIndex = 9;
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
            // lTotalPrecio
            // 
            this.lTotalPrecio.AutoSize = true;
            this.lTotalPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPrecio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lTotalPrecio.Location = new System.Drawing.Point(164, 22);
            this.lTotalPrecio.Name = "lTotalPrecio";
            this.lTotalPrecio.Size = new System.Drawing.Size(35, 16);
            this.lTotalPrecio.TabIndex = 6;
            this.lTotalPrecio.Text = "0,00";
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
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click_1);
            // 
            // pCabecera
            // 
            this.pCabecera.Controls.Add(this.btnAgregarCarrito);
            this.pCabecera.Controls.Add(this.btnBuscar);
            this.pCabecera.Controls.Add(this.lblCantiad);
            this.pCabecera.Controls.Add(this.nudCantidad);
            this.pCabecera.Controls.Add(this.lblPrecio);
            this.pCabecera.Controls.Add(this.lblCantidad);
            this.pCabecera.Controls.Add(this.lblNombre);
            this.pCabecera.Controls.Add(this.txtPrecio);
            this.pCabecera.Controls.Add(this.txtStock);
            this.pCabecera.Controls.Add(this.txtNombre);
            this.pCabecera.Controls.Add(this.txtFecha);
            this.pCabecera.Controls.Add(this.lblFecha);
            this.pCabecera.Controls.Add(this.textBox2);
            this.pCabecera.Controls.Add(this.lblVenedor);
            this.pCabecera.Controls.Add(this.lblNombreCompleto);
            this.pCabecera.Controls.Add(this.textBox1);
            this.pCabecera.Controls.Add(this.btnBuscarProducto);
            this.pCabecera.Controls.Add(this.txtDNIcliente);
            this.pCabecera.Controls.Add(this.lblClienteDNI);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(938, 187);
            this.pCabecera.TabIndex = 10;
            this.pCabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.pCabecera_Paint);
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(851, 133);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(75, 42);
            this.btnAgregarCarrito.TabIndex = 24;
            this.btnAgregarCarrito.Text = "Agregar al Carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 145);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(161, 20);
            this.txtNombre.TabIndex = 15;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 9;
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 383);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIrAlPago);
            this.panel2.Controls.Add(this.lTotalPrecio);
            this.panel2.Controls.Add(this.lblSubtotal);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 100);
            this.panel2.TabIndex = 12;
            // 
            // RegistroVta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(938, 483);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.pCabecera);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RegistroVta";
            this.Text = "Punto Barra | Registrar Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnIrAlPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lTotalPrecio;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblVenedor;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDNIcliente;
        private System.Windows.Forms.Label lblClienteDNI;
        private System.Windows.Forms.Label lblCantiad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Button btnBuscar;
    }
}