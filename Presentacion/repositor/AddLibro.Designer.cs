namespace Gestion_Libreria.Presentacion.repositor
{
    partial class AddLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLibro));
            this.Lnombre_prod = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LCod = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAddCarrito = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Leditorial = new System.Windows.Forms.Label();
            this.LPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pProducto = new System.Windows.Forms.Panel();
            this.txtMostrarEditorial = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lAutor = new System.Windows.Forms.Label();
            this.lGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.pDataGrid = new System.Windows.Forms.Panel();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.pCarrito = new System.Windows.Forms.Panel();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.pCabecera = new System.Windows.Forms.Panel();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.lFecha = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lProveedor = new System.Windows.Forms.Label();
            this.pFooter = new System.Windows.Forms.Panel();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.lTotal = new System.Windows.Forms.Label();
            this.pProducto.SuspendLayout();
            this.pDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.pCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.pCabecera.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lnombre_prod
            // 
            this.Lnombre_prod.AutoSize = true;
            this.Lnombre_prod.BackColor = System.Drawing.Color.MidnightBlue;
            this.Lnombre_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnombre_prod.ForeColor = System.Drawing.Color.Azure;
            this.Lnombre_prod.Location = new System.Drawing.Point(40, 20);
            this.Lnombre_prod.Name = "Lnombre_prod";
            this.Lnombre_prod.Size = new System.Drawing.Size(62, 16);
            this.Lnombre_prod.TabIndex = 0;
            this.Lnombre_prod.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.Location = new System.Drawing.Point(43, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // LCod
            // 
            this.LCod.AutoSize = true;
            this.LCod.BackColor = System.Drawing.Color.MidnightBlue;
            this.LCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCod.ForeColor = System.Drawing.Color.Azure;
            this.LCod.Location = new System.Drawing.Point(40, 72);
            this.LCod.Name = "LCod";
            this.LCod.Size = new System.Drawing.Size(104, 16);
            this.LCod.TabIndex = 2;
            this.LCod.Text = "Codigo | ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(43, 91);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(188, 20);
            this.txtISBN.TabIndex = 3;
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.BackColor = System.Drawing.Color.MidnightBlue;
            this.LStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.ForeColor = System.Drawing.Color.Azure;
            this.LStock.Location = new System.Drawing.Point(40, 125);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(69, 16);
            this.LStock.TabIndex = 4;
            this.LStock.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(43, 144);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(188, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // btnAddCarrito
            // 
            this.btnAddCarrito.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCarrito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCarrito.Location = new System.Drawing.Point(156, 390);
            this.btnAddCarrito.Name = "btnAddCarrito";
            this.btnAddCarrito.Size = new System.Drawing.Size(75, 44);
            this.btnAddCarrito.TabIndex = 6;
            this.btnAddCarrito.Text = "Agregar al Carrito";
            this.btnAddCarrito.UseVisualStyleBackColor = false;
            this.btnAddCarrito.Click += new System.EventHandler(this.btnAddCarrito_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(46, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // Leditorial
            // 
            this.Leditorial.AutoSize = true;
            this.Leditorial.BackColor = System.Drawing.Color.MidnightBlue;
            this.Leditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leditorial.ForeColor = System.Drawing.Color.Azure;
            this.Leditorial.Location = new System.Drawing.Point(40, 176);
            this.Leditorial.Name = "Leditorial";
            this.Leditorial.Size = new System.Drawing.Size(150, 16);
            this.Leditorial.TabIndex = 8;
            this.Leditorial.Text = "Editorial | Proveedor";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.BackColor = System.Drawing.Color.MidnightBlue;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.ForeColor = System.Drawing.Color.Azure;
            this.LPrecio.Location = new System.Drawing.Point(40, 231);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(52, 16);
            this.LPrecio.TabIndex = 10;
            this.LPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(43, 252);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(188, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // pProducto
            // 
            this.pProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.pProducto.Controls.Add(this.txtMostrarEditorial);
            this.pProducto.Controls.Add(this.txtAutor);
            this.pProducto.Controls.Add(this.lAutor);
            this.pProducto.Controls.Add(this.lGenero);
            this.pProducto.Controls.Add(this.cmbGenero);
            this.pProducto.Controls.Add(this.btnAddCarrito);
            this.pProducto.Controls.Add(this.btnSalir);
            this.pProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pProducto.Location = new System.Drawing.Point(0, 0);
            this.pProducto.Name = "pProducto";
            this.pProducto.Size = new System.Drawing.Size(291, 516);
            this.pProducto.TabIndex = 12;
            // 
            // txtMostrarEditorial
            // 
            this.txtMostrarEditorial.Location = new System.Drawing.Point(43, 195);
            this.txtMostrarEditorial.Name = "txtMostrarEditorial";
            this.txtMostrarEditorial.ReadOnly = true;
            this.txtMostrarEditorial.Size = new System.Drawing.Size(188, 20);
            this.txtMostrarEditorial.TabIndex = 14;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(43, 352);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(188, 20);
            this.txtAutor.TabIndex = 14;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            // 
            // lAutor
            // 
            this.lAutor.AutoSize = true;
            this.lAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAutor.ForeColor = System.Drawing.Color.Azure;
            this.lAutor.Location = new System.Drawing.Point(44, 333);
            this.lAutor.Name = "lAutor";
            this.lAutor.Size = new System.Drawing.Size(43, 16);
            this.lAutor.TabIndex = 12;
            this.lAutor.Text = "Autor";
            // 
            // lGenero
            // 
            this.lGenero.AutoSize = true;
            this.lGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenero.ForeColor = System.Drawing.Color.Azure;
            this.lGenero.Location = new System.Drawing.Point(43, 280);
            this.lGenero.Name = "lGenero";
            this.lGenero.Size = new System.Drawing.Size(58, 16);
            this.lGenero.TabIndex = 9;
            this.lGenero.Text = "Genero";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(43, 299);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(188, 21);
            this.cmbGenero.TabIndex = 8;
            // 
            // pDataGrid
            // 
            this.pDataGrid.Controls.Add(this.dgvLibros);
            this.pDataGrid.Controls.Add(this.pCarrito);
            this.pDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDataGrid.Location = new System.Drawing.Point(291, 0);
            this.pDataGrid.Name = "pDataGrid";
            this.pDataGrid.Size = new System.Drawing.Size(938, 516);
            this.pDataGrid.TabIndex = 13;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToOrderColumns = true;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibros.Location = new System.Drawing.Point(346, 0);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(592, 516);
            this.dgvLibros.TabIndex = 0;
            // 
            // pCarrito
            // 
            this.pCarrito.Controls.Add(this.dgvCarrito);
            this.pCarrito.Controls.Add(this.pCabecera);
            this.pCarrito.Controls.Add(this.pFooter);
            this.pCarrito.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCarrito.Location = new System.Drawing.Point(0, 0);
            this.pCarrito.Name = "pCarrito";
            this.pCarrito.Size = new System.Drawing.Size(346, 516);
            this.pCarrito.TabIndex = 1;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(0, 111);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(346, 279);
            this.dgvCarrito.TabIndex = 1;
            this.dgvCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellContentClick);
            // 
            // pCabecera
            // 
            this.pCabecera.Controls.Add(this.btnBuscarProveedor);
            this.pCabecera.Controls.Add(this.lFecha);
            this.pCabecera.Controls.Add(this.txtProveedor);
            this.pCabecera.Controls.Add(this.lProveedor);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(346, 111);
            this.pCabecera.TabIndex = 2;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(264, 39);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(65, 24);
            this.btnBuscarProveedor.TabIndex = 2;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lFecha.Location = new System.Drawing.Point(16, 14);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(50, 16);
            this.lFecha.TabIndex = 2;
            this.lFecha.Text = "Fecha";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(106, 41);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(140, 20);
            this.txtProveedor.TabIndex = 1;
            // 
            // lProveedor
            // 
            this.lProveedor.AutoSize = true;
            this.lProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProveedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lProveedor.Location = new System.Drawing.Point(16, 43);
            this.lProveedor.Name = "lProveedor";
            this.lProveedor.Size = new System.Drawing.Size(84, 16);
            this.lProveedor.TabIndex = 0;
            this.lProveedor.Text = "Proveedor:";
            // 
            // pFooter
            // 
            this.pFooter.Controls.Add(this.btnConfirmarCompra);
            this.pFooter.Controls.Add(this.lTotal);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 390);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(346, 126);
            this.pFooter.TabIndex = 0;
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCompra.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnConfirmarCompra.Location = new System.Drawing.Point(230, 61);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(75, 43);
            this.btnConfirmarCompra.TabIndex = 1;
            this.btnConfirmarCompra.Text = "Confirmar Compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = false;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lTotal.Location = new System.Drawing.Point(6, 28);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(142, 16);
            this.lTotal.TabIndex = 0;
            this.lTotal.Text = "Total de la compra:";
            // 
            // AddLibro
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1229, 516);
            this.Controls.Add(this.pDataGrid);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.LPrecio);
            this.Controls.Add(this.Leditorial);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.LCod);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Lnombre_prod);
            this.Controls.Add(this.pProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddLibro";
            this.Text = "Punto Barra | Agregar Producto";
            this.Load += new System.EventHandler(this.AddProd_Load);
            this.pProducto.ResumeLayout(false);
            this.pProducto.PerformLayout();
            this.pDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.pCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lnombre_prod;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LCod;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAddCarrito;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label Leditorial;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Panel pProducto;
        private System.Windows.Forms.Panel pDataGrid;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label lGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Panel pCarrito;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lProveedor;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtMostrarEditorial;
    }
}