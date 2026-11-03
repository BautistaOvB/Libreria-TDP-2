namespace Gestion_Libreria.Presentacion.administrador
{
    partial class DetalleVenta
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lMetodo = new System.Windows.Forms.Label();
            this.txtMetodo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lVendedor = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.lNumero = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.pCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pCabecera.Controls.Add(this.btnCerrar);
            this.pCabecera.Controls.Add(this.lMetodo);
            this.pCabecera.Controls.Add(this.txtMetodo);
            this.pCabecera.Controls.Add(this.txtTotal);
            this.pCabecera.Controls.Add(this.lTotal);
            this.pCabecera.Controls.Add(this.txtVendedor);
            this.pCabecera.Controls.Add(this.lVendedor);
            this.pCabecera.Controls.Add(this.lFecha);
            this.pCabecera.Controls.Add(this.txtFecha);
            this.pCabecera.Controls.Add(this.txtIdVenta);
            this.pCabecera.Controls.Add(this.lNumero);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(650, 127);
            this.pCabecera.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(563, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lMetodo
            // 
            this.lMetodo.AutoSize = true;
            this.lMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMetodo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lMetodo.Location = new System.Drawing.Point(76, 96);
            this.lMetodo.Name = "lMetodo";
            this.lMetodo.Size = new System.Drawing.Size(91, 16);
            this.lMetodo.TabIndex = 9;
            this.lMetodo.Text = "Pagado con";
            // 
            // txtMetodo
            // 
            this.txtMetodo.Location = new System.Drawing.Point(173, 93);
            this.txtMetodo.Name = "txtMetodo";
            this.txtMetodo.ReadOnly = true;
            this.txtMetodo.Size = new System.Drawing.Size(121, 20);
            this.txtMetodo.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(492, 96);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lTotal.Location = new System.Drawing.Point(354, 94);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(132, 20);
            this.lTotal.TabIndex = 6;
            this.lTotal.Text = "Total de Venta:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(492, 54);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(121, 20);
            this.txtVendedor.TabIndex = 5;
            // 
            // lVendedor
            // 
            this.lVendedor.AutoSize = true;
            this.lVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVendedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lVendedor.Location = new System.Drawing.Point(400, 60);
            this.lVendedor.Name = "lVendedor";
            this.lVendedor.Size = new System.Drawing.Size(75, 16);
            this.lVendedor.TabIndex = 4;
            this.lVendedor.Text = "Vendedor";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lFecha.Location = new System.Drawing.Point(12, 54);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(142, 20);
            this.lFecha.TabIndex = 3;
            this.lFecha.Text = "Fecha de Venta:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(173, 56);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(121, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(173, 18);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.ReadOnly = true;
            this.txtIdVenta.Size = new System.Drawing.Size(121, 20);
            this.txtIdVenta.TabIndex = 1;
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lNumero.Location = new System.Drawing.Point(13, 19);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(154, 20);
            this.lNumero.TabIndex = 0;
            this.lNumero.Text = "Numero de Venta:";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.Location = new System.Drawing.Point(0, 127);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(650, 265);
            this.dgvDetalles.TabIndex = 1;
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 392);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.pCabecera);
            this.Name = "DetalleVenta";
            this.Text = "Punto y Barra | Factura";
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lVendedor;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lMetodo;
        private System.Windows.Forms.TextBox txtMetodo;
        private System.Windows.Forms.Button btnCerrar;
    }
}