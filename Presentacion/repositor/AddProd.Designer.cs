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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LPrecio = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lnombre_prod
            // 
            this.Lnombre_prod.AutoSize = true;
            this.Lnombre_prod.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lnombre_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnombre_prod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lnombre_prod.Location = new System.Drawing.Point(40, 20);
            this.Lnombre_prod.Name = "Lnombre_prod";
            this.Lnombre_prod.Size = new System.Drawing.Size(62, 18);
            this.Lnombre_prod.TabIndex = 0;
            this.Lnombre_prod.Text = "Nombre";
            this.Lnombre_prod.Click += new System.EventHandler(this.Lnombre_prod_Click);
            // 
            // TBnombre_prod
            // 
            this.TBnombre_prod.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TBnombre_prod.Location = new System.Drawing.Point(43, 39);
            this.TBnombre_prod.Name = "TBnombre_prod";
            this.TBnombre_prod.Size = new System.Drawing.Size(188, 20);
            this.TBnombre_prod.TabIndex = 1;
            this.TBnombre_prod.TextChanged += new System.EventHandler(this.TBnombre_prod_TextChanged);
            // 
            // LCod
            // 
            this.LCod.AutoSize = true;
            this.LCod.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCod.Location = new System.Drawing.Point(40, 72);
            this.LCod.Name = "LCod";
            this.LCod.Size = new System.Drawing.Size(103, 18);
            this.LCod.TabIndex = 2;
            this.LCod.Text = "Codigo | ISBN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(138, 135);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(66, 18);
            this.LStock.TabIndex = 4;
            this.LStock.Text = "Cantidad";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(89, 233);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.Location = new System.Drawing.Point(40, 135);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(51, 18);
            this.LPrecio.TabIndex = 10;
            this.LPrecio.Text = "Precio";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(43, 168);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(141, 168);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // AddProd
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(278, 267);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.LPrecio);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LCod);
            this.Controls.Add(this.TBnombre_prod);
            this.Controls.Add(this.Lnombre_prod);
            this.Name = "AddProd";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AddProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lnombre_prod;
        private System.Windows.Forms.TextBox TBnombre_prod;
        private System.Windows.Forms.Label LCod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}