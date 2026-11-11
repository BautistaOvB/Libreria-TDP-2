namespace Gestion_Libreria.Presentacion.administrador
{
    partial class guardarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guardarCompra));
            this.pCabecera = new System.Windows.Forms.Panel();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lProveedor = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.btnRegistrarProveedor = new System.Windows.Forms.Button();
            this.lCuit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pCabecera.Controls.Add(this.lCuit);
            this.pCabecera.Controls.Add(this.textBox1);
            this.pCabecera.Controls.Add(this.btnRegistrarProveedor);
            this.pCabecera.Controls.Add(this.btnBuscarProveedor);
            this.pCabecera.Controls.Add(this.lProveedor);
            this.pCabecera.Controls.Add(this.txtProveedor);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(1044, 129);
            this.pCabecera.TabIndex = 0;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(125, 20);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(145, 20);
            this.txtProveedor.TabIndex = 0;
            // 
            // lProveedor
            // 
            this.lProveedor.AutoSize = true;
            this.lProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProveedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lProveedor.Location = new System.Drawing.Point(27, 21);
            this.lProveedor.Name = "lProveedor";
            this.lProveedor.Size = new System.Drawing.Size(80, 15);
            this.lProveedor.TabIndex = 1;
            this.lProveedor.Text = "Razon Social";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.Azure;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(288, 26);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(77, 37);
            this.btnBuscarProveedor.TabIndex = 2;
            this.btnBuscarProveedor.Text = "Buscar Proveedor";
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarProveedor
            // 
            this.btnRegistrarProveedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProveedor.ForeColor = System.Drawing.Color.Azure;
            this.btnRegistrarProveedor.Location = new System.Drawing.Point(380, 26);
            this.btnRegistrarProveedor.Name = "btnRegistrarProveedor";
            this.btnRegistrarProveedor.Size = new System.Drawing.Size(77, 37);
            this.btnRegistrarProveedor.TabIndex = 3;
            this.btnRegistrarProveedor.Text = "Nuevo Proveedor";
            this.btnRegistrarProveedor.UseVisualStyleBackColor = false;
            // 
            // lCuit
            // 
            this.lCuit.AutoSize = true;
            this.lCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCuit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lCuit.Location = new System.Drawing.Point(81, 48);
            this.lCuit.Name = "lCuit";
            this.lCuit.Size = new System.Drawing.Size(34, 15);
            this.lCuit.TabIndex = 5;
            this.lCuit.Text = "CUIT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 4;
            // 
            // guardarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1044, 515);
            this.Controls.Add(this.pCabecera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guardarCompra";
            this.Text = "Punto Barra | Guardar Compra";
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lProveedor;
        private System.Windows.Forms.Button btnRegistrarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label lCuit;
        private System.Windows.Forms.TextBox textBox1;
    }
}