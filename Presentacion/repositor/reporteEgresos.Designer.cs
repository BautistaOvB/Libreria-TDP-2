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
            this.pCabecera = new System.Windows.Forms.Panel();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.pDatagrid = new System.Windows.Forms.Panel();
            this.pDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalleEgreso = new System.Windows.Forms.DataGridView();
            this.dgvEgresos = new System.Windows.Forms.DataGridView();
            this.pCabecera.SuspendLayout();
            this.pDatagrid.SuspendLayout();
            this.pDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).BeginInit();
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
            this.pCabecera.Size = new System.Drawing.Size(800, 100);
            this.pCabecera.TabIndex = 0;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(12, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(183, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(201, 12);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Location = new System.Drawing.Point(408, 10);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFecha.TabIndex = 2;
            this.btnBuscarFecha.Text = "Fecha";
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            // 
            // pDatagrid
            // 
            this.pDatagrid.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pDatagrid.Controls.Add(this.dgvEgresos);
            this.pDatagrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pDatagrid.Location = new System.Drawing.Point(0, 100);
            this.pDatagrid.Name = "pDatagrid";
            this.pDatagrid.Size = new System.Drawing.Size(416, 350);
            this.pDatagrid.TabIndex = 1;
            // 
            // pDetalle
            // 
            this.pDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.pDetalle.Controls.Add(this.dgvDetalleEgreso);
            this.pDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetalle.Location = new System.Drawing.Point(416, 100);
            this.pDetalle.Name = "pDetalle";
            this.pDetalle.Size = new System.Drawing.Size(384, 350);
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
            this.dgvDetalleEgreso.Size = new System.Drawing.Size(384, 350);
            this.dgvDetalleEgreso.TabIndex = 0;
            // 
            // dgvEgresos
            // 
            this.dgvEgresos.AllowUserToOrderColumns = true;
            this.dgvEgresos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEgresos.Location = new System.Drawing.Point(0, 0);
            this.dgvEgresos.Name = "dgvEgresos";
            this.dgvEgresos.Size = new System.Drawing.Size(416, 350);
            this.dgvEgresos.TabIndex = 0;
            // 
            // reporteEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pDetalle);
            this.Controls.Add(this.pDatagrid);
            this.Controls.Add(this.pCabecera);
            this.Name = "reporteEgresos";
            this.Text = "Punto y Barra | Egresos";
            this.pCabecera.ResumeLayout(false);
            this.pDatagrid.ResumeLayout(false);
            this.pDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).EndInit();
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