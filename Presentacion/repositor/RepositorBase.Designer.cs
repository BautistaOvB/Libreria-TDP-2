namespace Gestion_Libreria.Presentacion.repositor
{
    partial class Repositor_base
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEgresos = new System.Windows.Forms.Button();
            this.BtnVerStock = new System.Windows.Forms.Button();
            this.BtnNingreso = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnAddProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.BtnEgresos);
            this.panel2.Controls.Add(this.BtnVerStock);
            this.panel2.Controls.Add(this.BtnNingreso);
            this.panel2.Controls.Add(this.BtnReportes);
            this.panel2.Controls.Add(this.BtnAddProd);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 461);
            this.panel2.TabIndex = 1;
            // 
            // BtnEgresos
            // 
            this.BtnEgresos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEgresos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEgresos.Location = new System.Drawing.Point(15, 399);
            this.BtnEgresos.Name = "BtnEgresos";
            this.BtnEgresos.Size = new System.Drawing.Size(140, 50);
            this.BtnEgresos.TabIndex = 6;
            this.BtnEgresos.Text = "Reporte de egresos";
            this.BtnEgresos.UseVisualStyleBackColor = false;
            // 
            // BtnVerStock
            // 
            this.BtnVerStock.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnVerStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVerStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVerStock.Location = new System.Drawing.Point(15, 261);
            this.BtnVerStock.Name = "BtnVerStock";
            this.BtnVerStock.Size = new System.Drawing.Size(140, 50);
            this.BtnVerStock.TabIndex = 5;
            this.BtnVerStock.Text = "Ver Productos";
            this.BtnVerStock.UseVisualStyleBackColor = false;
            this.BtnVerStock.Click += new System.EventHandler(this.BtnVerStock_Click);
            // 
            // BtnNingreso
            // 
            this.BtnNingreso.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnNingreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNingreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNingreso.Location = new System.Drawing.Point(15, 328);
            this.BtnNingreso.Name = "BtnNingreso";
            this.BtnNingreso.Size = new System.Drawing.Size(140, 50);
            this.BtnNingreso.TabIndex = 4;
            this.BtnNingreso.Text = "Registrar Ingreso";
            this.BtnNingreso.UseVisualStyleBackColor = false;
            this.BtnNingreso.Click += new System.EventHandler(this.BtnNingreso_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnReportes.Location = new System.Drawing.Point(15, 195);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(140, 50);
            this.BtnReportes.TabIndex = 3;
            this.BtnReportes.Text = "Reporte de ingresos";
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnAddProd
            // 
            this.BtnAddProd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddProd.Location = new System.Drawing.Point(15, 130);
            this.BtnAddProd.Name = "BtnAddProd";
            this.BtnAddProd.Padding = new System.Windows.Forms.Padding(5);
            this.BtnAddProd.Size = new System.Drawing.Size(140, 50);
            this.BtnAddProd.TabIndex = 2;
            this.BtnAddProd.Text = "Agregar producto";
            this.BtnAddProd.UseVisualStyleBackColor = false;
            this.BtnAddProd.Click += new System.EventHandler(this.BtnAddProd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gestion_Libreria.Properties.Resources.punto_y_barra_azul_blanco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(40, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(179, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 461);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // Repositor_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Repositor_base";
            this.Text = "Punto y Barra | Repositor";
            this.Load += new System.EventHandler(this.Repositor_base_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAddProd;
        private System.Windows.Forms.Button BtnNingreso;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnVerStock;
        private System.Windows.Forms.Button BtnEgresos;
        private System.Windows.Forms.Panel panel3;
    }
}