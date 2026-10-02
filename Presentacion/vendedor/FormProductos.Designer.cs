namespace Gestion_Libreria.Presentacion.vendedor
{
    partial class FormProductos
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
            this.components = new System.ComponentModel.Container();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punto_Barra_pruebaDataSet = new Gestion_Libreria.Punto_Barra_pruebaDataSet();
            this.librosTableAdapter = new Gestion_Libreria.Punto_Barra_pruebaDataSetTableAdapters.LibrosTableAdapter();
            this.AddCarrito = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBotones = new System.Windows.Forms.Panel();
            this.pFondo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).BeginInit();
            this.pBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(30, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(178, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvProductos.Location = new System.Drawing.Point(0, 78);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(783, 348);
            this.dgvProductos.TabIndex = 2;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.punto_Barra_pruebaDataSet;
            // 
            // punto_Barra_pruebaDataSet
            // 
            this.punto_Barra_pruebaDataSet.DataSetName = "Punto_Barra_pruebaDataSet";
            this.punto_Barra_pruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // AddCarrito
            // 
            this.AddCarrito.Location = new System.Drawing.Point(21, 33);
            this.AddCarrito.Name = "AddCarrito";
            this.AddCarrito.Size = new System.Drawing.Size(83, 42);
            this.AddCarrito.TabIndex = 3;
            this.AddCarrito.Text = "Agregar al Carrito";
            this.AddCarrito.UseVisualStyleBackColor = true;
            this.AddCarrito.Click += new System.EventHandler(this.AddCarrito_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(138, 33);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 42);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(234, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 78);
            this.panel1.TabIndex = 6;
            // 
            // pBotones
            // 
            this.pBotones.Controls.Add(this.AddCarrito);
            this.pBotones.Controls.Add(this.btnCancelar);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotones.Location = new System.Drawing.Point(0, 326);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(783, 100);
            this.pBotones.TabIndex = 7;
            // 
            // pFondo
            // 
            this.pFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFondo.Location = new System.Drawing.Point(0, 0);
            this.pFondo.Name = "pFondo";
            this.pFondo.Size = new System.Drawing.Size(783, 426);
            this.pFondo.TabIndex = 8;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(783, 426);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pFondo);
            this.Name = "FormProductos";
            this.Text = "Punto y Barra | Buscar Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_pruebaDataSet)).EndInit();
            this.pBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private Punto_Barra_pruebaDataSet punto_Barra_pruebaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private Punto_Barra_pruebaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.Button AddCarrito;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Panel pFondo;
    }
}