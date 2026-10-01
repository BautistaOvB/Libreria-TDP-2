namespace Gestion_Libreria.Presentacion.vendedor
{
    partial class reporteVentas
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtDNIcliente = new System.Windows.Forms.TextBox();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.btnBuscarxFecha = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.pCabecera.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.DarkBlue;
            this.pCabecera.Controls.Add(this.lblFecha);
            this.pCabecera.Controls.Add(this.lblDNI);
            this.pCabecera.Controls.Add(this.btnBuscarxFecha);
            this.pCabecera.Controls.Add(this.btnBuscarDni);
            this.pCabecera.Controls.Add(this.txtDNIcliente);
            this.pCabecera.Controls.Add(this.dateTimePicker2);
            this.pCabecera.Controls.Add(this.dateTimePicker1);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(1150, 129);
            this.pCabecera.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(257, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // txtDNIcliente
            // 
            this.txtDNIcliente.Location = new System.Drawing.Point(24, 76);
            this.txtDNIcliente.Name = "txtDNIcliente";
            this.txtDNIcliente.Size = new System.Drawing.Size(170, 20);
            this.txtDNIcliente.TabIndex = 2;
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarDni.Location = new System.Drawing.Point(226, 73);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDni.TabIndex = 3;
            this.btnBuscarDni.Text = "Buscar";
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            // 
            // btnBuscarxFecha
            // 
            this.btnBuscarxFecha.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarxFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarxFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarxFecha.Location = new System.Drawing.Point(475, 29);
            this.btnBuscarxFecha.Name = "btnBuscarxFecha";
            this.btnBuscarxFecha.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarxFecha.TabIndex = 4;
            this.btnBuscarxFecha.Text = "Buscar";
            this.btnBuscarxFecha.UseVisualStyleBackColor = false;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDNI.Location = new System.Drawing.Point(21, 60);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(62, 13);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "Documento";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(24, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.dgvVentas);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 129);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(550, 342);
            this.pLeft.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDetalle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(550, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 342);
            this.panel1.TabIndex = 2;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(600, 342);
            this.dgvDetalle.TabIndex = 0;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvVentas
            // 
            this.dgvVentas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(550, 342);
            this.dgvVentas.TabIndex = 0;
            // 
            // reporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pCabecera);
            this.Name = "reporteVentas";
            this.Text = "reporteVentas";
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            this.pLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.TextBox txtDNIcliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnBuscarxFecha;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridView dgvVentas;
    }
}