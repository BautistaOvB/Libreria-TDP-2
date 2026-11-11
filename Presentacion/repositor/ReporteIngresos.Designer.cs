namespace Gestion_Libreria.Presentacion.repositor
{
    partial class RIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RIngresos));
            this.pCabecera = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.lProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.fCompra = new System.Windows.Forms.Label();
            this.pCompras = new System.Windows.Forms.Panel();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.pDetalles = new System.Windows.Forms.Panel();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.pCabecera.SuspendLayout();
            this.pCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.pDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.MidnightBlue;
            this.pCabecera.Controls.Add(this.txtTotal);
            this.pCabecera.Controls.Add(this.lTotal);
            this.pCabecera.Controls.Add(this.lProveedor);
            this.pCabecera.Controls.Add(this.txtProveedor);
            this.pCabecera.Controls.Add(this.txtFecha);
            this.pCabecera.Controls.Add(this.fCompra);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(950, 100);
            this.pCabecera.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(769, 65);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(123, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTotal.Location = new System.Drawing.Point(668, 68);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(95, 13);
            this.lTotal.TabIndex = 1;
            this.lTotal.Text = "Total de la compra";
            // 
            // lProveedor
            // 
            this.lProveedor.AutoSize = true;
            this.lProveedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lProveedor.Location = new System.Drawing.Point(707, 38);
            this.lProveedor.Name = "lProveedor";
            this.lProveedor.Size = new System.Drawing.Size(56, 13);
            this.lProveedor.TabIndex = 3;
            this.lProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(770, 35);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(122, 20);
            this.txtProveedor.TabIndex = 2;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(770, 8);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(122, 20);
            this.txtFecha.TabIndex = 1;
            
            // 
            // fCompra
            // 
            this.fCompra.AutoSize = true;
            this.fCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fCompra.Location = new System.Drawing.Point(673, 8);
            this.fCompra.Name = "fCompra";
            this.fCompra.Size = new System.Drawing.Size(90, 13);
            this.fCompra.TabIndex = 0;
            this.fCompra.Text = "Fecha de compra";
            // 
            // pCompras
            // 
            this.pCompras.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pCompras.Controls.Add(this.dgvCompras);
            this.pCompras.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCompras.Location = new System.Drawing.Point(0, 100);
            this.pCompras.Name = "pCompras";
            this.pCompras.Size = new System.Drawing.Size(478, 408);
            this.pCompras.TabIndex = 1;
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToOrderColumns = true;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompras.Location = new System.Drawing.Point(0, 0);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(478, 408);
            this.dgvCompras.TabIndex = 0;
            // 
            // pDetalles
            // 
            this.pDetalles.BackColor = System.Drawing.Color.SteelBlue;
            this.pDetalles.Controls.Add(this.dgvDetalles);
            this.pDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetalles.Location = new System.Drawing.Point(478, 100);
            this.pDetalles.Name = "pDetalles";
            this.pDetalles.Size = new System.Drawing.Size(472, 408);
            this.pDetalles.TabIndex = 2;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToOrderColumns = true;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(472, 408);
            this.dgvDetalles.TabIndex = 0;
            // 
            // RIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(950, 508);
            this.Controls.Add(this.pDetalles);
            this.Controls.Add(this.pCompras);
            this.Controls.Add(this.pCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RIngresos";
            this.Text = "Reporte de Ingresos";
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            this.pCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.pDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.Panel pCompras;
        private System.Windows.Forms.Label lProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label fCompra;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Panel pDetalles;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lTotal;
    }
}