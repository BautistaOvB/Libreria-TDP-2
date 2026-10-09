namespace Gestion_Libreria.Presentacion.vendedor
{
    partial class addCliente
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
            this.lNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lMail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pCabecera = new System.Windows.Forms.Panel();
            this.btnBuscarApellido = new System.Windows.Forms.Button();
            this.btnBuscarDNI = new System.Windows.Forms.Button();
            this.txtApellidoBuscar = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pDatos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCabecera.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.Color.MidnightBlue;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lNombre.Location = new System.Drawing.Point(34, 34);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(62, 16);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.BackColor = System.Drawing.Color.MidnightBlue;
            this.lDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lDNI.Location = new System.Drawing.Point(63, 131);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(33, 16);
            this.lDNI.TabIndex = 2;
            this.lDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(102, 131);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(152, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.BackColor = System.Drawing.Color.MidnightBlue;
            this.lDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lDireccion.Location = new System.Drawing.Point(23, 183);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(73, 16);
            this.lDireccion.TabIndex = 4;
            this.lDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(102, 183);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(152, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(102, 235);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.BackColor = System.Drawing.Color.MidnightBlue;
            this.lTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTelefono.Location = new System.Drawing.Point(27, 236);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(69, 16);
            this.lTelefono.TabIndex = 7;
            this.lTelefono.Text = "Telefono";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.BackColor = System.Drawing.Color.MidnightBlue;
            this.lApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lApellido.Location = new System.Drawing.Point(31, 80);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(65, 16);
            this.lApellido.TabIndex = 8;
            this.lApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(103, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(207, 349);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(113, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.BackColor = System.Drawing.Color.MidnightBlue;
            this.lMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lMail.Location = new System.Drawing.Point(50, 290);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(46, 16);
            this.lMail.TabIndex = 12;
            this.lMail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.MidnightBlue;
            this.pCabecera.Controls.Add(this.btnBuscarApellido);
            this.pCabecera.Controls.Add(this.btnBuscarDNI);
            this.pCabecera.Controls.Add(this.txtApellidoBuscar);
            this.pCabecera.Controls.Add(this.lblApellido);
            this.pCabecera.Controls.Add(this.txtBuscarDNI);
            this.pCabecera.Controls.Add(this.lblDNI);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(311, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(657, 122);
            this.pCabecera.TabIndex = 15;
            // 
            // btnBuscarApellido
            // 
            this.btnBuscarApellido.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarApellido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarApellido.Location = new System.Drawing.Point(244, 75);
            this.btnBuscarApellido.Name = "btnBuscarApellido";
            this.btnBuscarApellido.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarApellido.TabIndex = 5;
            this.btnBuscarApellido.Text = "Buscar";
            this.btnBuscarApellido.UseVisualStyleBackColor = false;
            this.btnBuscarApellido.Click += new System.EventHandler(this.btnBuscarApellido_Click);
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarDNI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDNI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarDNI.Location = new System.Drawing.Point(244, 40);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDNI.TabIndex = 4;
            this.btnBuscarDNI.Text = "Buscar";
            this.btnBuscarDNI.UseVisualStyleBackColor = false;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // txtApellidoBuscar
            // 
            this.txtApellidoBuscar.Location = new System.Drawing.Point(88, 79);
            this.txtApellidoBuscar.Name = "txtApellidoBuscar";
            this.txtApellidoBuscar.Size = new System.Drawing.Size(135, 20);
            this.txtApellidoBuscar.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellido.Location = new System.Drawing.Point(38, 83);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Location = new System.Drawing.Point(79, 40);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(144, 20);
            this.txtBuscarDNI.TabIndex = 1;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDNI.Location = new System.Drawing.Point(44, 43);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizar.Location = new System.Drawing.Point(21, 349);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pDatos
            // 
            this.pDatos.BackColor = System.Drawing.Color.MidnightBlue;
            this.pDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pDatos.Location = new System.Drawing.Point(0, 0);
            this.pDatos.Name = "pDatos";
            this.pDatos.Size = new System.Drawing.Size(311, 460);
            this.pDatos.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(311, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 338);
            this.panel1.TabIndex = 18;
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCliente,
            this.ApellidoCliente,
            this.DNIcliente,
            this.direccion,
            this.telefonoCliente,
            this.mailCliente});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(657, 338);
            this.dgvClientes.TabIndex = 0;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Nombre";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.HeaderText = "Apellido";
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            // 
            // DNIcliente
            // 
            this.DNIcliente.HeaderText = "DNI";
            this.DNIcliente.Name = "DNIcliente";
            this.DNIcliente.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefonoCliente
            // 
            this.telefonoCliente.HeaderText = "Telefono";
            this.telefonoCliente.Name = "telefonoCliente";
            // 
            // mailCliente
            // 
            this.mailCliente.HeaderText = "Correo";
            this.mailCliente.Name = "mailCliente";
            this.mailCliente.ReadOnly = true;
            // 
            // addCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(968, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pCabecera);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lMail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.pDatos);
            this.Name = "addCliente";
            this.Text = "Punto y Barra | Registrar Cliente";
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.Button btnBuscarApellido;
        private System.Windows.Forms.Button btnBuscarDNI;
        private System.Windows.Forms.TextBox txtApellidoBuscar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailCliente;
    }
}