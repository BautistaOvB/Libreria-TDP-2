namespace Gestion_Libreria.Presentacion.administrador
{
    partial class adminInicio
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
            this.Lpyb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lpyb
            // 
            this.Lpyb.AutoSize = true;
            this.Lpyb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lpyb.Location = new System.Drawing.Point(144, 24);
            this.Lpyb.Name = "Lpyb";
            this.Lpyb.Size = new System.Drawing.Size(186, 13);
            this.Lpyb.TabIndex = 0;
            this.Lpyb.Text = "Punto y Barra | Panel de administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gestion_Libreria.Properties.Resources.punto_y_barra;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Gestion_Libreria.Properties.Resources.punto_y_barra;
            this.pictureBox1.Location = new System.Drawing.Point(140, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // adminInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lpyb);
            this.Name = "adminInicio";
            this.Text = "adminInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lpyb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}