namespace Gestion_Libreria.Presentacion.vendedor
{
    partial class ProdDetalles
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
            this.LISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lGenero = new System.Windows.Forms.Label();
            this.lDisponibles = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.BtnAgregarCarrito = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LISBN
            // 
            this.LISBN.AutoSize = true;
            this.LISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISBN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LISBN.Location = new System.Drawing.Point(28, 41);
            this.LISBN.Name = "LISBN";
            this.LISBN.Size = new System.Drawing.Size(42, 16);
            this.LISBN.TabIndex = 0;
            this.LISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(88, 41);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(175, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTitulo.Location = new System.Drawing.Point(24, 87);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(46, 16);
            this.lTitulo.TabIndex = 2;
            this.lTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(88, 87);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(175, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(88, 136);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(175, 20);
            this.txtGenero.TabIndex = 4;
            // 
            // lGenero
            // 
            this.lGenero.AutoSize = true;
            this.lGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lGenero.Location = new System.Drawing.Point(24, 137);
            this.lGenero.Name = "lGenero";
            this.lGenero.Size = new System.Drawing.Size(58, 16);
            this.lGenero.TabIndex = 5;
            this.lGenero.Text = "Genero";
            // 
            // lDisponibles
            // 
            this.lDisponibles.AutoSize = true;
            this.lDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDisponibles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lDisponibles.Location = new System.Drawing.Point(147, 193);
            this.lDisponibles.Name = "lDisponibles";
            this.lDisponibles.Size = new System.Drawing.Size(139, 16);
            this.lDisponibles.TabIndex = 6;
            this.lDisponibles.Text = "Unidades disponibles";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(27, 193);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 7;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lPrecio.Location = new System.Drawing.Point(27, 247);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(49, 16);
            this.lPrecio.TabIndex = 8;
            this.lPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(88, 247);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(134, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // BtnAgregarCarrito
            // 
            this.BtnAgregarCarrito.Location = new System.Drawing.Point(198, 306);
            this.BtnAgregarCarrito.Name = "BtnAgregarCarrito";
            this.BtnAgregarCarrito.Size = new System.Drawing.Size(88, 45);
            this.BtnAgregarCarrito.TabIndex = 10;
            this.BtnAgregarCarrito.Text = "Agregar al carrito";
            this.BtnAgregarCarrito.UseVisualStyleBackColor = true;
            this.BtnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(65, 317);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ProdDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(328, 387);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregarCarrito);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lDisponibles);
            this.Controls.Add(this.lGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.LISBN);
            this.Name = "ProdDetalles";
            this.Text = "Detalle de Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lGenero;
        private System.Windows.Forms.Label lDisponibles;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button BtnAgregarCarrito;
        private System.Windows.Forms.Button BtnSalir;
    }
}