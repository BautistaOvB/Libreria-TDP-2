namespace Gestion_Libreria.Presentacion.administrador
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
            this.lInventario = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.punto_Barra_tdpDataSet1 = new Gestion_Libreria.Punto_Barra_tdpDataSet1();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Gestion_Libreria.Punto_Barra_tdpDataSet1TableAdapters.librosTableAdapter();
            this.Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cabecera
            // 
            this.Cabecera.BackColor = System.Drawing.Color.SteelBlue;
            this.Cabecera.Controls.Add(this.lInventario);
            this.Cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecera.Location = new System.Drawing.Point(0, 0);
            this.Cabecera.Name = "Cabecera";
            this.Cabecera.Size = new System.Drawing.Size(800, 100);
            this.Cabecera.TabIndex = 0;
            // 
            // lInventario
            // 
            this.lInventario.AutoSize = true;
            this.lInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInventario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lInventario.Location = new System.Drawing.Point(34, 36);
            this.lInventario.Name = "lInventario";
            this.lInventario.Size = new System.Drawing.Size(89, 20);
            this.lInventario.TabIndex = 0;
            this.lInventario.Text = "Inventario";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 100);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(800, 350);
            this.dgvStock.TabIndex = 1;
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
            // rteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.Cabecera);
            this.Name = "rteInventario";
            this.Text = "Punto y Barra | Inventario";
            this.Load += new System.EventHandler(this.rteInventario_Load_1);
            this.Cabecera.ResumeLayout(false);
            this.Cabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Cabecera;
        private System.Windows.Forms.Label lInventario;
        private System.Windows.Forms.DataGridView dgvStock;
        private Punto_Barra_tdpDataSet1 punto_Barra_tdpDataSet1;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private Punto_Barra_tdpDataSet1TableAdapters.librosTableAdapter librosTableAdapter;
    }
}