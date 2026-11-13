namespace Gestion_Libreria.Presentacion.repositor
{
    partial class reporteEgresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporteEgresos));
            this.pCabecera = new System.Windows.Forms.Panel();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.pDatagrid = new System.Windows.Forms.Panel();
            this.dgvEgresos = new System.Windows.Forms.DataGridView();
            this.pDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalleEgreso = new System.Windows.Forms.DataGridView();
            this.pCabecera.SuspendLayout();
            this.pDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).BeginInit();
            this.pDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEgreso)).BeginInit();
            this.SuspendLayout();
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.MidnightBlue;
            this.pCabecera.Controls.Add(this.btnBuscarFecha);
            this.pCabecera.Controls.Add(this.dtpHasta);
            this.pCabecera.Controls.Add(this.dtpDesde);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(1034, 100);
            this.pCabecera.TabIndex = 0;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarFecha.Location = new System.Drawing.Point(209, 20);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(75, 42);
            this.btnBuscarFecha.TabIndex = 2;
            this.btnBuscarFecha.Text = "Buscar fecha";
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(12, 46);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(183, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(12, 16);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(183, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // pDatagrid
            // 
            this.pDatagrid.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pDatagrid.Controls.Add(this.dgvEgresos);
            this.pDatagrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pDatagrid.Location = new System.Drawing.Point(0, 100);
            this.pDatagrid.Name = "pDatagrid";
            this.pDatagrid.Size = new System.Drawing.Size(540, 439);
            this.pDatagrid.TabIndex = 1;
            // 
            // dgvEgresos
            // 
            this.dgvEgresos.AllowUserToOrderColumns = true;
            this.dgvEgresos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEgresos.Location = new System.Drawing.Point(0, 0);
            this.dgvEgresos.Name = "dgvEgresos";
            this.dgvEgresos.Size = new System.Drawing.Size(540, 439);
            this.dgvEgresos.TabIndex = 0;
            // 
            // pDetalle
            // 
            this.pDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.pDetalle.Controls.Add(this.dgvDetalleEgreso);
            this.pDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetalle.Location = new System.Drawing.Point(540, 100);
            this.pDetalle.Name = "pDetalle";
            this.pDetalle.Size = new System.Drawing.Size(494, 439);
            this.pDetalle.TabIndex = 2;
            // 
            // dgvDetalleEgreso
            // 
            this.dgvDetalleEgreso.AllowUserToOrderColumns = true;
            this.dgvDetalleEgreso.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvDetalleEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleEgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleEgreso.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleEgreso.Name = "dgvDetalleEgreso";
            this.dgvDetalleEgreso.Size = new System.Drawing.Size(494, 439);
            this.dgvDetalleEgreso.TabIndex = 0;
            // 
            // reporteEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 539);
            this.Controls.Add(this.pDetalle);
            this.Controls.Add(this.pDatagrid);
            this.Controls.Add(this.pCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reporteEgresos";
            this.Text = "Punto y Barra | Egresos";
            this.pCabecera.ResumeLayout(false);
            this.pDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).EndInit();
            this.pDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEgreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Panel pDatagrid;
        private System.Windows.Forms.Panel pDetalle;
        private System.Windows.Forms.DataGridView dgvEgresos;
        private System.Windows.Forms.DataGridView dgvDetalleEgreso;
    }
}