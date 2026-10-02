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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pVentas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lFecha = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarrapruebaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pVentas.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnBuscarFecha);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.lFecha);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 95);
            this.panel1.TabIndex = 3;
            // 
            // pVentas
            // 
            this.pVentas.Controls.Add(this.dgvVentas);
            this.pVentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pVentas.Location = new System.Drawing.Point(0, 95);
            this.pVentas.Name = "pVentas";
            this.pVentas.Size = new System.Drawing.Size(565, 354);
            this.pVentas.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDetalles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(565, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 354);
            this.panel2.TabIndex = 5;
            // 
            // dgvVentas
            // 
            this.dgvVentas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(565, 354);
            this.dgvVentas.TabIndex = 0;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(414, 354);
            this.dgvDetalles.TabIndex = 0;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(28, 30);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
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
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(260, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 2;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Location = new System.Drawing.Point(485, 26);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFecha.TabIndex = 3;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            // 
            // rteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(979, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pVentas);
            this.Controls.Add(this.panel1);
            this.Name = "rteVentas";
            this.Text = "Punto y Barra | Ventas";
            this.Load += new System.EventHandler(this.rteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarrapruebaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pVentas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscarFecha;
    }
}