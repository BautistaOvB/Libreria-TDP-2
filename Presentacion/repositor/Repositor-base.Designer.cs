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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAddProd = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnStock = new System.Windows.Forms.Button();
            this.BtnVerStock = new System.Windows.Forms.Button();
            this.BtnEgresos = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(165, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.BtnEgresos);
            this.panel2.Controls.Add(this.BtnVerStock);
            this.panel2.Controls.Add(this.BtnStock);
            this.panel2.Controls.Add(this.BtnReportes);
            this.panel2.Controls.Add(this.BtnAddProd);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 461);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(162, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 363);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(162, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(621, 100);
            this.panel4.TabIndex = 3;
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
            // BtnAddProd
            // 
            this.BtnAddProd.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnAddProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddProd.Location = new System.Drawing.Point(15, 130);
            this.BtnAddProd.Name = "BtnAddProd";
            this.BtnAddProd.Padding = new System.Windows.Forms.Padding(5);
            this.BtnAddProd.Size = new System.Drawing.Size(140, 50);
            this.BtnAddProd.TabIndex = 2;
            this.BtnAddProd.Text = "Agregar producto";
            this.BtnAddProd.UseVisualStyleBackColor = false;
            // 
            // BtnReportes
            // 
            this.BtnReportes.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnReportes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReportes.Location = new System.Drawing.Point(15, 186);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(140, 50);
            this.BtnReportes.TabIndex = 3;
            this.BtnReportes.Text = "Reporte de ingresos";
            this.BtnReportes.UseVisualStyleBackColor = false;
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnStock.Location = new System.Drawing.Point(15, 298);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(140, 50);
            this.BtnStock.TabIndex = 4;
            this.BtnStock.Text = "Modificar Stock";
            this.BtnStock.UseVisualStyleBackColor = false;
            // 
            // BtnVerStock
            // 
            this.BtnVerStock.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnVerStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVerStock.Location = new System.Drawing.Point(15, 242);
            this.BtnVerStock.Name = "BtnVerStock";
            this.BtnVerStock.Size = new System.Drawing.Size(140, 50);
            this.BtnVerStock.TabIndex = 5;
            this.BtnVerStock.Text = "Ver Productos";
            this.BtnVerStock.UseVisualStyleBackColor = false;
            // 
            // BtnEgresos
            // 
            this.BtnEgresos.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnEgresos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEgresos.Location = new System.Drawing.Point(16, 355);
            this.BtnEgresos.Name = "BtnEgresos";
            this.BtnEgresos.Size = new System.Drawing.Size(140, 50);
            this.BtnEgresos.TabIndex = 6;
            this.BtnEgresos.Text = "Reporte de egresos";
            this.BtnEgresos.UseVisualStyleBackColor = false;
            // 
            // Repositor_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel4);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAddProd;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnVerStock;
        private System.Windows.Forms.Button BtnEgresos;
    }
}