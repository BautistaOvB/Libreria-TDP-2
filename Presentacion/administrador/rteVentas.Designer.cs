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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punto_Barra_pruebaDataSet1 = new Gestion_Libreria.Punto_Barra_pruebaDataSet1();
            this.punto_Barra_pruebaDataSet = new Gestion_Libreria.Punto_Barra_pruebaDataSet();
            this.puntoBarrapruebaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new Gestion_Libreria.Punto_Barra_pruebaDataSet1TableAdapters.CompraTableAdapter();
            this.Lventas = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.punto_Barra_tdpDataSet1 = new Gestion_Libreria.Punto_Barra_tdpDataSet1();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new Gestion_Libreria.Punto_Barra_tdpDataSet1TableAdapters.ventasTableAdapter();
            this.BtnVerDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarrapruebaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnVerDetalle});
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(0, 75);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(526, 237);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
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
            // Lventas
            // 
            this.Lventas.AutoSize = true;
            this.Lventas.BackColor = System.Drawing.Color.SteelBlue;
            this.Lventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lventas.ForeColor = System.Drawing.Color.AliceBlue;
            this.Lventas.Location = new System.Drawing.Point(12, 19);
            this.Lventas.Name = "Lventas";
            this.Lventas.Size = new System.Drawing.Size(184, 24);
            this.Lventas.TabIndex = 1;
            this.Lventas.Text = "Reporte de Ventas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(397, 22);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
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
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.DataPropertyName = "id_compra";
            this.BtnVerDetalle.HeaderText = "Accion";
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 75);
            this.panel1.TabIndex = 3;
            // 
            // rteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(526, 312);
            this.Controls.Add(this.Lventas);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.panel1);
            this.Name = "rteVentas";
            this.Text = "Punto y Barra | Ventas";
            this.Load += new System.EventHandler(this.rteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarrapruebaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.BindingSource puntoBarrapruebaDataSetBindingSource;
        private Punto_Barra_pruebaDataSet punto_Barra_pruebaDataSet;
        private Punto_Barra_pruebaDataSet1 punto_Barra_pruebaDataSet1;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private Punto_Barra_pruebaDataSet1TableAdapters.CompraTableAdapter compraTableAdapter;
        private System.Windows.Forms.Label Lventas;
        private System.Windows.Forms.Button btnCerrar;
        private Punto_Barra_tdpDataSet1 punto_Barra_tdpDataSet1;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private Punto_Barra_tdpDataSet1TableAdapters.ventasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BtnVerDetalle;
        private System.Windows.Forms.Panel panel1;
    }
}