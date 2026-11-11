namespace Gestion_Libreria.Presentacion.repositor
{
    partial class AddProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProveedor));
            this.pAdd = new System.Windows.Forms.Panel();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lRazonSocial = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lCuit = new System.Windows.Forms.Label();
            this.pCabecera = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.pAdd.SuspendLayout();
            this.pCabecera.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pAdd
            // 
            this.pAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.pAdd.Controls.Add(this.txtMail);
            this.pAdd.Controls.Add(this.lEmail);
            this.pAdd.Controls.Add(this.txtRazonSocial);
            this.pAdd.Controls.Add(this.lRazonSocial);
            this.pAdd.Controls.Add(this.btnCancelar);
            this.pAdd.Controls.Add(this.btnRegistrar);
            this.pAdd.Controls.Add(this.btnActualizar);
            this.pAdd.Controls.Add(this.txtTelefono);
            this.pAdd.Controls.Add(this.lTelefono);
            this.pAdd.Controls.Add(this.lDireccion);
            this.pAdd.Controls.Add(this.txtDireccion);
            this.pAdd.Controls.Add(this.txtNombre);
            this.pAdd.Controls.Add(this.lNombre);
            this.pAdd.Controls.Add(this.txtCuit);
            this.pAdd.Controls.Add(this.lCuit);
            this.pAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pAdd.Location = new System.Drawing.Point(0, 0);
            this.pAdd.Name = "pAdd";
            this.pAdd.Size = new System.Drawing.Size(278, 531);
            this.pAdd.TabIndex = 0;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(22, 370);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(195, 20);
            this.txtMail.TabIndex = 14;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.ForeColor = System.Drawing.Color.AliceBlue;
            this.lEmail.Location = new System.Drawing.Point(19, 351);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(46, 16);
            this.lEmail.TabIndex = 13;
            this.lEmail.Text = "Email";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(22, 184);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(195, 20);
            this.txtRazonSocial.TabIndex = 12;
            // 
            // lRazonSocial
            // 
            this.lRazonSocial.AutoSize = true;
            this.lRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRazonSocial.ForeColor = System.Drawing.Color.AliceBlue;
            this.lRazonSocial.Location = new System.Drawing.Point(19, 165);
            this.lRazonSocial.Name = "lRazonSocial";
            this.lRazonSocial.Size = new System.Drawing.Size(99, 16);
            this.lRazonSocial.TabIndex = 11;
            this.lRazonSocial.Text = "Razón Social";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(104, 479);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Location = new System.Drawing.Point(188, 479);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizar.Location = new System.Drawing.Point(18, 479);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(22, 310);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.ForeColor = System.Drawing.Color.AliceBlue;
            this.lTelefono.Location = new System.Drawing.Point(19, 291);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(69, 16);
            this.lTelefono.TabIndex = 6;
            this.lTelefono.Text = "Telefono";
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.ForeColor = System.Drawing.Color.AliceBlue;
            this.lDireccion.Location = new System.Drawing.Point(19, 229);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(73, 16);
            this.lDireccion.TabIndex = 5;
            this.lDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(22, 248);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(195, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.lNombre.Location = new System.Drawing.Point(19, 102);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(66, 16);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre ";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(22, 62);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(195, 20);
            this.txtCuit.TabIndex = 1;
            // 
            // lCuit
            // 
            this.lCuit.AutoSize = true;
            this.lCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCuit.ForeColor = System.Drawing.Color.AliceBlue;
            this.lCuit.Location = new System.Drawing.Point(19, 46);
            this.lCuit.Name = "lCuit";
            this.lCuit.Size = new System.Drawing.Size(33, 16);
            this.lCuit.TabIndex = 0;
            this.lCuit.Text = "Cuit";
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.MidnightBlue;
            this.pCabecera.Controls.Add(this.btnSeleccionar);
            this.pCabecera.Controls.Add(this.btnBuscarProveedor);
            this.pCabecera.Controls.Add(this.txtBuscar);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(278, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(745, 100);
            this.pCabecera.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeleccionar.Location = new System.Drawing.Point(633, 60);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 28);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProveedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(199, 27);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 35);
            this.btnBuscarProveedor.TabIndex = 1;
            this.btnBuscarProveedor.Text = "Buscar Proveedor";
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(30, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(141, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.dgvProveedor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(278, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 431);
            this.panel2.TabIndex = 2;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToOrderColumns = true;
            this.dgvProveedor.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedor.Location = new System.Drawing.Point(0, 0);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.Size = new System.Drawing.Size(745, 431);
            this.dgvProveedor.TabIndex = 0;
            this.dgvProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellDoubleClick);
            this.dgvProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellDoubleClick);
            // 
            // AddProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pCabecera);
            this.Controls.Add(this.pAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProveedor";
            this.Text = "Punto y Barra | Nuevo Proveedor";
            this.pAdd.ResumeLayout(false);
            this.pAdd.PerformLayout();
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAdd;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lCuit;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lRazonSocial;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}