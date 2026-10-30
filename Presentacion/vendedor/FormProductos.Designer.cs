namespace Gestion_Libreria.Presentacion.vendedor
{
    partial class FormProductos
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pCabecera = new System.Windows.Forms.Panel();
            this.pFondo = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pDetalle = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            
            this.pFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(30, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(178, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            
            // 
            // punto_Barra_pruebaDataSet
            // 
            
            // 
            // librosTableAdapter
            // 
           
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(234, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.MidnightBlue;
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(867, 78);
            this.pCabecera.TabIndex = 6;
            // 
            // pFondo
            // 
            this.pFondo.Controls.Add(this.dgvProductos);
            this.pFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFondo.Location = new System.Drawing.Point(0, 78);
            this.pFondo.Name = "pFondo";
            this.pFondo.Size = new System.Drawing.Size(867, 431);
            this.pFondo.TabIndex = 9;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(867, 431);
            this.dgvProductos.TabIndex = 0;
            // 
            // pDetalle
            // 
            this.pDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.pDetalle.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDetalle.Location = new System.Drawing.Point(572, 78);
            this.pDetalle.Name = "pDetalle";
            this.pDetalle.Size = new System.Drawing.Size(295, 431);
            this.pDetalle.TabIndex = 0;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(867, 509);
            this.Controls.Add(this.pDetalle);
            this.Controls.Add(this.pFondo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pCabecera);
            this.Name = "FormProductos";
            this.Text = "Punto y Barra | Buscar Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            
            this.pFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        
        private System.Windows.Forms.BindingSource librosBindingSource;
        
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.Panel pFondo;
        private System.Windows.Forms.Panel pDetalle;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}