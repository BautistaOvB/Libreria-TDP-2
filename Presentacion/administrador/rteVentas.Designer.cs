namespace Gestion_Libreria.Presentacion.administrador
{
    partial class rteVentas
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
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punto_Barra_pruebaDataSet1 = new Gestion_Libreria.Punto_Barra_pruebaDataSet1();
            this.punto_Barra_pruebaDataSet = new Gestion_Libreria.Punto_Barra_pruebaDataSet();
            this.puntoBarrapruebaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new Gestion_Libreria.Punto_Barra_pruebaDataSet1TableAdapters.CompraTableAdapter();
            this.punto_Barra_tdpDataSet1 = new Gestion_Libreria.Punto_Barra_tdpDataSet1();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new Gestion_Libreria.Punto_Barra_tdpDataSet1TableAdapters.ventasTableAdapter();
            this.pCabecera = new System.Windows.Forms.Panel();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lFecha = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.pVentas = new System.Windows.Forms.Panel();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.txtFiltroVendedor = new System.Windows.Forms.TextBox();
            this.btnBuscarVendedor = new System.Windows.Forms.Button();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lnombreVendedor = new System.Windows.Forms.Label();
            this.lNventa = new System.Windows.Forms.Label();
            this.txtNventa = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.lAbonado = new System.Windows.Forms.Label();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarrapruebaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            this.pCabecera.SuspendLayout();
            this.pVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra";
            this.compraBindingSource.DataSource = this.punto_Barra_pruebaDataSet1;
            // 
            // punto_Barra_pruebaDataSet1
            // 
            this.punto_Barra_pruebaDataSet1.DataSetName = "Punto_Barra_pruebaDataSet1";
            this.punto_Barra_pruebaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // punto_Barra_pruebaDataSet
            // 
            this.punto_Barra_pruebaDataSet.DataSetName = "Punto_Barra_pruebaDataSet";
            this.punto_Barra_pruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puntoBarrapruebaDataSetBindingSource
            // 
            this.puntoBarrapruebaDataSetBindingSource.DataSource = this.punto_Barra_pruebaDataSet;
            this.puntoBarrapruebaDataSetBindingSource.Position = 0;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // punto_Barra_tdpDataSet1
            // 
            this.punto_Barra_tdpDataSet1.DataSetName = "Punto_Barra_tdpDataSet1";
            this.punto_Barra_tdpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "ventas";
            this.ventasBindingSource.DataSource = this.punto_Barra_tdpDataSet1;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.MidnightBlue;
            this.pCabecera.Controls.Add(this.txtMetodoPago);
            this.pCabecera.Controls.Add(this.lAbonado);
            this.pCabecera.Controls.Add(this.lTotal);
            this.pCabecera.Controls.Add(this.txtTotal);
            this.pCabecera.Controls.Add(this.txtNventa);
            this.pCabecera.Controls.Add(this.lNventa);
            this.pCabecera.Controls.Add(this.lnombreVendedor);
            this.pCabecera.Controls.Add(this.txtVendedor);
            this.pCabecera.Controls.Add(this.btnBuscarVendedor);
            this.pCabecera.Controls.Add(this.txtFiltroVendedor);
            this.pCabecera.Controls.Add(this.btnBuscarFecha);
            this.pCabecera.Controls.Add(this.dtpHasta);
            this.pCabecera.Controls.Add(this.lFecha);
            this.pCabecera.Controls.Add(this.dtpDesde);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(979, 108);
            this.pCabecera.TabIndex = 3;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarFecha.Location = new System.Drawing.Point(476, 27);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFecha.TabIndex = 3;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(251, 30);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 2;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lFecha.Location = new System.Drawing.Point(28, 11);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(43, 13);
            this.lFecha.TabIndex = 1;
            this.lFecha.Text = "Fecha: ";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(28, 30);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // pVentas
            // 
            this.pVentas.Controls.Add(this.dgvVentas);
            this.pVentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pVentas.Location = new System.Drawing.Point(0, 108);
            this.pVentas.Name = "pVentas";
            this.pVentas.Size = new System.Drawing.Size(565, 341);
            this.pVentas.TabIndex = 4;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToOrderColumns = true;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(565, 341);
            this.dgvVentas.TabIndex = 0;
            // 
            // pContenedor
            // 
            this.pContenedor.Controls.Add(this.dgvDetalles);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(565, 108);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(414, 341);
            this.pContenedor.TabIndex = 5;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(414, 341);
            this.dgvDetalles.TabIndex = 0;
            // 
            // txtFiltroVendedor
            // 
            this.txtFiltroVendedor.Location = new System.Drawing.Point(28, 69);
            this.txtFiltroVendedor.Name = "txtFiltroVendedor";
            this.txtFiltroVendedor.Size = new System.Drawing.Size(200, 20);
            this.txtFiltroVendedor.TabIndex = 4;
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarVendedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarVendedor.Location = new System.Drawing.Point(251, 66);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarVendedor.TabIndex = 5;
            this.btnBuscarVendedor.Text = "Filtrar vendedor";
            this.btnBuscarVendedor.UseVisualStyleBackColor = false;
            this.btnBuscarVendedor.Click += new System.EventHandler(this.btnBuscarVendedor_Click);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(642, 40);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(129, 20);
            this.txtVendedor.TabIndex = 6;
            // 
            // lnombreVendedor
            // 
            this.lnombreVendedor.AutoSize = true;
            this.lnombreVendedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lnombreVendedor.Location = new System.Drawing.Point(581, 43);
            this.lnombreVendedor.Name = "lnombreVendedor";
            this.lnombreVendedor.Size = new System.Drawing.Size(56, 13);
            this.lnombreVendedor.TabIndex = 7;
            this.lnombreVendedor.Text = "Vendedor:";
            // 
            // lNventa
            // 
            this.lNventa.AutoSize = true;
            this.lNventa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lNventa.Location = new System.Drawing.Point(581, 11);
            this.lNventa.Name = "lNventa";
            this.lNventa.Size = new System.Drawing.Size(54, 13);
            this.lNventa.TabIndex = 8;
            this.lNventa.Text = "Venta n°: ";
            // 
            // txtNventa
            // 
            this.txtNventa.Location = new System.Drawing.Point(642, 11);
            this.txtNventa.Name = "txtNventa";
            this.txtNventa.ReadOnly = true;
            this.txtNventa.Size = new System.Drawing.Size(130, 20);
            this.txtNventa.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(642, 69);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(67, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTotal.Location = new System.Drawing.Point(591, 76);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(34, 13);
            this.lTotal.TabIndex = 11;
            this.lTotal.Text = "Total:";
            // 
            // lAbonado
            // 
            this.lAbonado.AutoSize = true;
            this.lAbonado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lAbonado.Location = new System.Drawing.Point(744, 76);
            this.lAbonado.Name = "lAbonado";
            this.lAbonado.Size = new System.Drawing.Size(71, 13);
            this.lAbonado.TabIndex = 12;
            this.lAbonado.Text = "Abonado con";
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(822, 76);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.ReadOnly = true;
            this.txtMetodoPago.Size = new System.Drawing.Size(120, 20);
            this.txtMetodoPago.TabIndex = 13;
            // 
            // rteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(979, 449);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.pVentas);
            this.Controls.Add(this.pCabecera);
            this.Name = "rteVentas";
            this.Text = "Punto y Barra | Ventas";
            this.Load += new System.EventHandler(this.rteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarrapruebaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            this.pVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.pContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource puntoBarrapruebaDataSetBindingSource;
        private Punto_Barra_pruebaDataSet punto_Barra_pruebaDataSet;
        private Punto_Barra_pruebaDataSet1 punto_Barra_pruebaDataSet1;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private Punto_Barra_pruebaDataSet1TableAdapters.CompraTableAdapter compraTableAdapter;
        private Punto_Barra_tdpDataSet1 punto_Barra_tdpDataSet1;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private Punto_Barra_tdpDataSet1TableAdapters.ventasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.Panel pVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.Button btnBuscarVendedor;
        private System.Windows.Forms.TextBox txtFiltroVendedor;
        private System.Windows.Forms.Label lnombreVendedor;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label lAbonado;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNventa;
        private System.Windows.Forms.Label lNventa;
    }
}