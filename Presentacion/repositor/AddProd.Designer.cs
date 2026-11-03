namespace Gestion_Libreria.Presentacion.repositor
{
    partial class AddProd
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
            this.Lnombre_prod = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LCod = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.LPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pProducto = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.pDataGrid = new System.Windows.Forms.Panel();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pProducto.SuspendLayout();
            this.pDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // Lnombre_prod
            // 
            this.Lnombre_prod.AutoSize = true;
            this.Lnombre_prod.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lnombre_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnombre_prod.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.LCod.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCod.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.LStock.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LStock.Location = new System.Drawing.Point(40, 125);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(46, 16);
            this.LStock.TabIndex = 4;
            this.LStock.Text = "Stock";
            this.LStock.Click += new System.EventHandler(this.LStock_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(43, 144);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(188, 20);
            this.txtStock.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(91, 456);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LPrecio.Location = new System.Drawing.Point(41, 180);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(52, 16);
            this.LPrecio.TabIndex = 10;
            this.LPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(43, 199);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(188, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // pProducto
            // 
            this.pProducto.Controls.Add(this.btnEliminar);
            this.pProducto.Controls.Add(this.btnModificar);
            this.pProducto.Controls.Add(this.label2);
            this.pProducto.Controls.Add(this.txtPrecio);
            this.pProducto.Controls.Add(this.label1);
            this.pProducto.Controls.Add(this.LPrecio);
            this.pProducto.Controls.Add(this.txtStockMin);
            this.pProducto.Controls.Add(this.txtAutor);
            this.pProducto.Controls.Add(this.lGenero);
            this.pProducto.Controls.Add(this.cmbGenero);
            this.pProducto.Controls.Add(this.btnGuardar);
            this.pProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pProducto.Location = new System.Drawing.Point(0, 0);
            this.pProducto.Name = "pProducto";
            this.pProducto.Size = new System.Drawing.Size(269, 491);
            this.pProducto.TabIndex = 12;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(0, 456);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(41, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stock minimo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(40, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Autor";
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(43, 312);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(187, 20);
            this.txtStockMin.TabIndex = 11;
            this.txtStockMin.TextChanged += new System.EventHandler(this.txtStockMin_TextChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(43, 260);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(188, 20);
            this.txtAutor.TabIndex = 10;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            // 
            // lGenero
            // 
            this.lGenero.AutoSize = true;
            this.lGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lGenero.Location = new System.Drawing.Point(40, 353);
            this.lGenero.Name = "lGenero";
            this.lGenero.Size = new System.Drawing.Size(58, 16);
            this.lGenero.TabIndex = 9;
            this.lGenero.Text = "Genero";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(42, 372);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(188, 21);
            this.cmbGenero.TabIndex = 8;
            // 
            // pDataGrid
            // 
            this.pDataGrid.Controls.Add(this.dgvLibros);
            this.pDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDataGrid.Location = new System.Drawing.Point(269, 0);
            this.pDataGrid.Name = "pDataGrid";
            this.pDataGrid.Size = new System.Drawing.Size(566, 491);
            this.pDataGrid.TabIndex = 13;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToOrderColumns = true;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibros.Location = new System.Drawing.Point(0, 0);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(566, 491);
            this.dgvLibros.TabIndex = 0;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(188, 456);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddProd
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(835, 491);
            this.Controls.Add(this.pDataGrid);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.LCod);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Lnombre_prod);
            this.Controls.Add(this.pProducto);
            this.Name = "AddProd";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AddProd_Load);
            this.pProducto.ResumeLayout(false);
            this.pProducto.PerformLayout();
            this.pDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lnombre_prod;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LCod;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Panel pProducto;
        private System.Windows.Forms.Panel pDataGrid;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label lGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}