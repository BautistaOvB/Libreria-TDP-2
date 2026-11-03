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
            this.components = new System.ComponentModel.Container();
            this.Cabecera = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.punto_Barra_tdpDataSet1 = new Gestion_Libreria.Punto_Barra_tdpDataSet1();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Gestion_Libreria.Punto_Barra_tdpDataSet1TableAdapters.librosTableAdapter();
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
            this.btnMasVendidos = new System.Windows.Forms.Button();
            this.btnMasCantidad = new System.Windows.Forms.Button();
            this.Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            this.pLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cabecera
            // 
            this.Cabecera.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cabecera.Controls.Add(this.btnMasCantidad);
            this.Cabecera.Controls.Add(this.btnMasVendidos);
            this.Cabecera.Controls.Add(this.txtBuscar);
            this.Cabecera.Controls.Add(this.btnBuscar);
            this.Cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecera.Location = new System.Drawing.Point(0, 0);
            this.Cabecera.Name = "Cabecera";
            this.Cabecera.Size = new System.Drawing.Size(937, 100);
            this.Cabecera.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(504, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(690, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar producto";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // punto_Barra_tdpDataSet1
            // 
            this.punto_Barra_tdpDataSet1.DataSetName = "Punto_Barra_tdpDataSet1";
            this.punto_Barra_tdpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.punto_Barra_tdpDataSet1;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // pLibros
            // 
            this.pLibros.BackColor = System.Drawing.Color.SteelBlue;
            this.pLibros.Controls.Add(this.dgvStock);
            this.pLibros.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLibros.Location = new System.Drawing.Point(0, 100);
            this.pLibros.Name = "pLibros";
            this.pLibros.Size = new System.Drawing.Size(695, 350);
            this.pLibros.TabIndex = 1;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(695, 350);
            this.dgvStock.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.panel1.Location = new System.Drawing.Point(695, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 350);
            this.panel1.TabIndex = 2;
            // 
            // lGenero
            // 
            this.lGenero.AutoSize = true;
            this.lGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenero.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(194, 20);
            this.txtGenero.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(27, 257);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(194, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(194, 20);
            this.txtStock.TabIndex = 5;
            // 
            // lStock
            // 
            this.lStock.AutoSize = true;
            this.lStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStock.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.lNombre.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(27, 61);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(194, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // lISBN
            // 
            this.lISBN.AutoSize = true;
            this.lISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lISBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lISBN.Location = new System.Drawing.Point(24, 41);
            this.lISBN.Name = "lISBN";
            this.lISBN.Size = new System.Drawing.Size(46, 16);
            this.lISBN.TabIndex = 0;
            this.lISBN.Text = "ISBN:";
            // 
            // btnMasVendidos
            // 
            this.btnMasVendidos.Location = new System.Drawing.Point(12, 12);
            this.btnMasVendidos.Name = "btnMasVendidos";
            this.btnMasVendidos.Size = new System.Drawing.Size(97, 34);
            this.btnMasVendidos.TabIndex = 2;
            this.btnMasVendidos.Text = "Mas Vendidos";
            this.btnMasVendidos.UseVisualStyleBackColor = true;
            // 
            // btnMasCantidad
            // 
            this.btnMasCantidad.Location = new System.Drawing.Point(13, 53);
            this.btnMasCantidad.Name = "btnMasCantidad";
            this.btnMasCantidad.Size = new System.Drawing.Size(96, 30);
            this.btnMasCantidad.TabIndex = 3;
            this.btnMasCantidad.Text = "Mas Pedidos";
            this.btnMasCantidad.UseVisualStyleBackColor = true;
            // 
            // rteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pLibros);
            this.Controls.Add(this.Cabecera);
            this.Name = "rteInventario";
            this.Text = "Punto y Barra | Inventario";
            this.Load += new System.EventHandler(this.rteInventario_Load);
            this.Cabecera.ResumeLayout(false);
            this.Cabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            this.pLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Cabecera;
        private Punto_Barra_tdpDataSet1 punto_Barra_tdpDataSet1;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private Punto_Barra_tdpDataSet1TableAdapters.librosTableAdapter librosTableAdapter;
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
    }
}