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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.punto_Barra_pruebaDataSet = new Gestion_Libreria.Punto_Barra_pruebaDataSet();
            this.puntoBarrapruebaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punto_Barra_pruebaDataSet1 = new Gestion_Libreria.Punto_Barra_pruebaDataSet1();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new Gestion_Libreria.Punto_Barra_pruebaDataSet1TableAdapters.CompraTableAdapter();
            this.Lventas = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.idcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnVerDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarrapruebaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcompraDataGridViewTextBoxColumn,
            this.fechacompraDataGridViewTextBoxColumn,
            this.totalcompraDataGridViewTextBoxColumn,
            this.BtnVerDetalle});
            this.dataGridView1.DataSource = this.compraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 184);
            this.dataGridView1.TabIndex = 0;
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
            // punto_Barra_pruebaDataSet1
            // 
            this.punto_Barra_pruebaDataSet1.DataSetName = "Punto_Barra_pruebaDataSet1";
            this.punto_Barra_pruebaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra";
            this.compraBindingSource.DataSource = this.punto_Barra_pruebaDataSet1;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // Lventas
            // 
            this.Lventas.AutoSize = true;
            this.Lventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lventas.Location = new System.Drawing.Point(23, 19);
            this.Lventas.Name = "Lventas";
            this.Lventas.Size = new System.Drawing.Size(167, 24);
            this.Lventas.TabIndex = 1;
            this.Lventas.Text = "Reporte de Ventas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(380, 258);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // idcompraDataGridViewTextBoxColumn
            // 
            this.idcompraDataGridViewTextBoxColumn.DataPropertyName = "id_compra";
            this.idcompraDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idcompraDataGridViewTextBoxColumn.Name = "idcompraDataGridViewTextBoxColumn";
            this.idcompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcompraDataGridViewTextBoxColumn.Width = 75;
            // 
            // fechacompraDataGridViewTextBoxColumn
            // 
            this.fechacompraDataGridViewTextBoxColumn.DataPropertyName = "fecha_compra";
            this.fechacompraDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechacompraDataGridViewTextBoxColumn.Name = "fechacompraDataGridViewTextBoxColumn";
            // 
            // totalcompraDataGridViewTextBoxColumn
            // 
            this.totalcompraDataGridViewTextBoxColumn.DataPropertyName = "total_compra";
            this.totalcompraDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalcompraDataGridViewTextBoxColumn.Name = "totalcompraDataGridViewTextBoxColumn";
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.DataPropertyName = "id_compra";
            this.BtnVerDetalle.HeaderText = "Accion";
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.ReadOnly = true;
            // 
            // rteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(484, 293);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Lventas);
            this.Controls.Add(this.dataGridView1);
            this.Name = "rteVentas";
            this.Text = "Punto y Barra | Ventas";
            this.Load += new System.EventHandler(this.rteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarrapruebaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource puntoBarrapruebaDataSetBindingSource;
        private Punto_Barra_pruebaDataSet punto_Barra_pruebaDataSet;
        private Punto_Barra_pruebaDataSet1 punto_Barra_pruebaDataSet1;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private Punto_Barra_pruebaDataSet1TableAdapters.CompraTableAdapter compraTableAdapter;
        private System.Windows.Forms.Label Lventas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BtnVerDetalle;
    }
}