namespace Gestion_Libreria.Presentacion.repositor
{
    partial class rteInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rteInventario));
            this.Cabecera = new System.Windows.Forms.Panel();
            this.pArticulos = new System.Windows.Forms.Panel();
            this.lTotalLibros = new System.Windows.Forms.Label();
            this.lCantidad = new System.Windows.Forms.Label();
            this.btnMasCantidad = new System.Windows.Forms.Button();
            this.btnMasVendidos = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pLibros = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lStock = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lISBN = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.Cabecera.SuspendLayout();
            this.pArticulos.SuspendLayout();
            this.pLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cabecera
            // 
            this.Cabecera.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cabecera.Controls.Add(this.pArticulos);
            this.Cabecera.Controls.Add(this.btnMasCantidad);
            this.Cabecera.Controls.Add(this.btnMasVendidos);
            this.Cabecera.Controls.Add(this.txtBuscar);
            this.Cabecera.Controls.Add(this.btnBuscar);
            this.Cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecera.Location = new System.Drawing.Point(0, 0);
            this.Cabecera.Name = "Cabecera";
            this.Cabecera.Size = new System.Drawing.Size(1035, 124);
            this.Cabecera.TabIndex = 0;
            // 
            // pArticulos
            // 
            this.pArticulos.BackColor = System.Drawing.Color.SteelBlue;
            this.pArticulos.Controls.Add(this.lTotalLibros);
            this.pArticulos.Controls.Add(this.lCantidad);
            this.pArticulos.Location = new System.Drawing.Point(176, 12);
            this.pArticulos.Name = "pArticulos";
            this.pArticulos.Size = new System.Drawing.Size(160, 94);
            this.pArticulos.TabIndex = 4;
            // 
            // lTotalLibros
            // 
            this.lTotalLibros.AutoSize = true;
            this.lTotalLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalLibros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTotalLibros.Location = new System.Drawing.Point(39, 52);
            this.lTotalLibros.Name = "lTotalLibros";
            this.lTotalLibros.Size = new System.Drawing.Size(28, 16);
            this.lTotalLibros.TabIndex = 1;
            this.lTotalLibros.Text = "###";
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lCantidad.Location = new System.Drawing.Point(12, 19);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(138, 16);
            this.lCantidad.TabIndex = 0;
            this.lCantidad.Text = "Cantidad de libros:";
            // 
            // btnMasCantidad
            // 
            this.btnMasCantidad.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMasCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMasCantidad.Location = new System.Drawing.Point(12, 61);
            this.btnMasCantidad.Name = "btnMasCantidad";
            this.btnMasCantidad.Size = new System.Drawing.Size(96, 40);
            this.btnMasCantidad.TabIndex = 3;
            this.btnMasCantidad.Text = "Mas Stockeados";
            this.btnMasCantidad.UseVisualStyleBackColor = false;
            this.btnMasCantidad.Click += new System.EventHandler(this.btnMasCantidad_Click);
            // 
            // btnMasVendidos
            // 
            this.btnMasVendidos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMasVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasVendidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMasVendidos.Location = new System.Drawing.Point(12, 12);
            this.btnMasVendidos.Name = "btnMasVendidos";
            this.btnMasVendidos.Size = new System.Drawing.Size(97, 43);
            this.btnMasVendidos.TabIndex = 2;
            this.btnMasVendidos.Text = "Mas Vendidos";
            this.btnMasVendidos.UseVisualStyleBackColor = false;
            this.btnMasVendidos.Click += new System.EventHandler(this.btnMasVendidos_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(653, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(850, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar producto";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pLibros
            // 
            this.pLibros.BackColor = System.Drawing.Color.SteelBlue;
            this.pLibros.Controls.Add(this.dgvStock);
            this.pLibros.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLibros.Location = new System.Drawing.Point(0, 124);
            this.pLibros.Name = "pLibros";
            this.pLibros.Size = new System.Drawing.Size(695, 460);
            this.pLibros.TabIndex = 1;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(695, 460);
            this.dgvStock.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lAutor);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.lGenero);
            this.panel1.Controls.Add(this.txtGenero);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.lPrecio);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.lStock);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.lISBN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(695, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 460);
            this.panel1.TabIndex = 2;
            // 
            // lGenero
            // 
            this.lGenero.AutoSize = true;
            this.lGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenero.ForeColor = System.Drawing.Color.AliceBlue;
            this.lGenero.Location = new System.Drawing.Point(27, 299);
            this.lGenero.Name = "lGenero";
            this.lGenero.Size = new System.Drawing.Size(62, 16);
            this.lGenero.TabIndex = 9;
            this.lGenero.Text = "Genero:";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(27, 318);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(194, 20);
            this.txtGenero.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(27, 257);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(194, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.ForeColor = System.Drawing.Color.AliceBlue;
            this.lPrecio.Location = new System.Drawing.Point(30, 238);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lPrecio.Size = new System.Drawing.Size(56, 16);
            this.lPrecio.TabIndex = 6;
            this.lPrecio.Text = "Precio:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(27, 192);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(194, 20);
            this.txtStock.TabIndex = 5;
            // 
            // lStock
            // 
            this.lStock.AutoSize = true;
            this.lStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStock.ForeColor = System.Drawing.Color.AliceBlue;
            this.lStock.Location = new System.Drawing.Point(24, 173);
            this.lStock.Name = "lStock";
            this.lStock.Size = new System.Drawing.Size(127, 16);
            this.lStock.TabIndex = 4;
            this.lStock.Text = "Stock disponible:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.lNombre.Location = new System.Drawing.Point(24, 105);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(62, 16);
            this.lNombre.TabIndex = 3;
            this.lNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(27, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(27, 61);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(194, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // lISBN
            // 
            this.lISBN.AutoSize = true;
            this.lISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lISBN.ForeColor = System.Drawing.Color.AliceBlue;
            this.lISBN.Location = new System.Drawing.Point(24, 41);
            this.lISBN.Name = "lISBN";
            this.lISBN.Size = new System.Drawing.Size(46, 16);
            this.lISBN.TabIndex = 0;
            this.lISBN.Text = "ISBN:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizar.Location = new System.Drawing.Point(155, 425);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(30, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lAutor
            // 
            this.lAutor.AutoSize = true;
            this.lAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAutor.ForeColor = System.Drawing.Color.AliceBlue;
            this.lAutor.Location = new System.Drawing.Point(27, 353);
            this.lAutor.Name = "lAutor";
            this.lAutor.Size = new System.Drawing.Size(43, 16);
            this.lAutor.TabIndex = 13;
            this.lAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(27, 372);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(194, 20);
            this.txtAutor.TabIndex = 12;
            // 
            // rteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pLibros);
            this.Controls.Add(this.Cabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rteInventario";
            this.Text = "Punto y Barra | Inventario";
            this.Load += new System.EventHandler(this.rteInventario_Load);
            this.Cabecera.ResumeLayout(false);
            this.Cabecera.PerformLayout();
            this.pArticulos.ResumeLayout(false);
            this.pArticulos.PerformLayout();
            this.pLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Cabecera;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel pLibros;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lISBN;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lStock;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnMasCantidad;
        private System.Windows.Forms.Button btnMasVendidos;
        private System.Windows.Forms.Panel pArticulos;
        private System.Windows.Forms.Label lTotalLibros;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lAutor;
        private System.Windows.Forms.TextBox txtAutor;
    }
}