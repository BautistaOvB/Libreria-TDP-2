namespace Gestion_Libreria.Presentacion.repositor
{
    partial class AddProd
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
            this.Lnombre_prod = new System.Windows.Forms.Label();
            this.TBnombre_prod = new System.Windows.Forms.TextBox();
            this.LCod = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.Leditorial = new System.Windows.Forms.Label();
            this.TBeditorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lnombre_prod
            // 
            this.Lnombre_prod.AutoSize = true;
            this.Lnombre_prod.BackColor = System.Drawing.SystemColors.Control;
            this.Lnombre_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnombre_prod.Location = new System.Drawing.Point(181, 20);
            this.Lnombre_prod.Name = "Lnombre_prod";
            this.Lnombre_prod.Size = new System.Drawing.Size(56, 16);
            this.Lnombre_prod.TabIndex = 0;
            this.Lnombre_prod.Text = "Nombre";
            this.Lnombre_prod.Click += new System.EventHandler(this.Lnombre_prod_Click);
            // 
            // TBnombre_prod
            // 
            this.TBnombre_prod.Location = new System.Drawing.Point(184, 39);
            this.TBnombre_prod.Name = "TBnombre_prod";
            this.TBnombre_prod.Size = new System.Drawing.Size(188, 20);
            this.TBnombre_prod.TabIndex = 1;
            // 
            // LCod
            // 
            this.LCod.AutoSize = true;
            this.LCod.BackColor = System.Drawing.SystemColors.Control;
            this.LCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCod.Location = new System.Drawing.Point(181, 72);
            this.LCod.Name = "LCod";
            this.LCod.Size = new System.Drawing.Size(91, 16);
            this.LCod.TabIndex = 2;
            this.LCod.Text = "Codigo | ISBN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 3;
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.BackColor = System.Drawing.SystemColors.Control;
            this.LStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(181, 125);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(61, 16);
            this.LStock.TabIndex = 4;
            this.LStock.Text = "Cantidad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(297, 226);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(389, 226);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // Leditorial
            // 
            this.Leditorial.AutoSize = true;
            this.Leditorial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Leditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leditorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Leditorial.Location = new System.Drawing.Point(181, 176);
            this.Leditorial.Name = "Leditorial";
            this.Leditorial.Size = new System.Drawing.Size(56, 16);
            this.Leditorial.TabIndex = 8;
            this.Leditorial.Text = "Editorial";
            // 
            // TBeditorial
            // 
            this.TBeditorial.Location = new System.Drawing.Point(184, 196);
            this.TBeditorial.Name = "TBeditorial";
            this.TBeditorial.Size = new System.Drawing.Size(188, 20);
            this.TBeditorial.TabIndex = 9;
            // 
            // AddProd
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.TBeditorial);
            this.Controls.Add(this.Leditorial);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LCod);
            this.Controls.Add(this.TBnombre_prod);
            this.Controls.Add(this.Lnombre_prod);
            this.Name = "AddProd";
            this.Text = "Agregar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lnombre_prod;
        private System.Windows.Forms.TextBox TBnombre_prod;
        private System.Windows.Forms.Label LCod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label Leditorial;
        private System.Windows.Forms.TextBox TBeditorial;
    }
}