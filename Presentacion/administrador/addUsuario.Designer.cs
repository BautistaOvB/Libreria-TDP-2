namespace Gestion_Libreria.Presentacion.administrador
{
    partial class addUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUsuario));
            this.Lnombre = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.Lemail = new System.Windows.Forms.Label();
            this.TBmail = new System.Windows.Forms.TextBox();
            this.LPass = new System.Windows.Forms.Label();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.Lrol = new System.Windows.Forms.Label();
            this.RBvendedor = new System.Windows.Forms.RadioButton();
            this.RBadmin = new System.Windows.Forms.RadioButton();
            this.RBrepositor = new System.Windows.Forms.RadioButton();
            this.BGuardar = new System.Windows.Forms.Button();
            this.Bsalir = new System.Windows.Forms.Button();
            this.LBapellido = new System.Windows.Forms.Label();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.Lusername = new System.Windows.Forms.Label();
            this.TBusername = new System.Windows.Forms.TextBox();
            this.pDBusuarios = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.TBtelefono = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.TBdireccion = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.lDNI = new System.Windows.Forms.Label();
            this.pDBusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.Lnombre.Location = new System.Drawing.Point(9, 48);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(44, 13);
            this.Lnombre.TabIndex = 0;
            this.Lnombre.Text = "Nombre";
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(12, 64);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(150, 20);
            this.TBnombre.TabIndex = 1;
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.ForeColor = System.Drawing.Color.AliceBlue;
            this.Lemail.Location = new System.Drawing.Point(178, 201);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(32, 13);
            this.Lemail.TabIndex = 2;
            this.Lemail.Text = "Email";
            // 
            // TBmail
            // 
            this.TBmail.Location = new System.Drawing.Point(178, 217);
            this.TBmail.Name = "TBmail";
            this.TBmail.Size = new System.Drawing.Size(150, 20);
            this.TBmail.TabIndex = 3;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.ForeColor = System.Drawing.Color.AliceBlue;
            this.LPass.Location = new System.Drawing.Point(9, 269);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(61, 13);
            this.LPass.TabIndex = 4;
            this.LPass.Text = "Contraseña";
            // 
            // TBpass
            // 
            this.TBpass.BackColor = System.Drawing.SystemColors.Window;
            this.TBpass.Location = new System.Drawing.Point(12, 285);
            this.TBpass.Name = "TBpass";
            this.TBpass.PasswordChar = '*';
            this.TBpass.Size = new System.Drawing.Size(150, 20);
            this.TBpass.TabIndex = 5;
            // 
            // Lrol
            // 
            this.Lrol.AutoSize = true;
            this.Lrol.ForeColor = System.Drawing.Color.AliceBlue;
            this.Lrol.Location = new System.Drawing.Point(40, 345);
            this.Lrol.Name = "Lrol";
            this.Lrol.Size = new System.Drawing.Size(23, 13);
            this.Lrol.TabIndex = 6;
            this.Lrol.Text = "Rol";
            // 
            // RBvendedor
            // 
            this.RBvendedor.AutoSize = true;
            this.RBvendedor.Checked = true;
            this.RBvendedor.ForeColor = System.Drawing.Color.AliceBlue;
            this.RBvendedor.Location = new System.Drawing.Point(43, 361);
            this.RBvendedor.Name = "RBvendedor";
            this.RBvendedor.Size = new System.Drawing.Size(71, 17);
            this.RBvendedor.TabIndex = 7;
            this.RBvendedor.TabStop = true;
            this.RBvendedor.Text = "Vendedor";
            this.RBvendedor.UseMnemonic = false;
            this.RBvendedor.UseVisualStyleBackColor = true;
            // 
            // RBadmin
            // 
            this.RBadmin.AutoSize = true;
            this.RBadmin.ForeColor = System.Drawing.Color.AliceBlue;
            this.RBadmin.Location = new System.Drawing.Point(120, 361);
            this.RBadmin.Name = "RBadmin";
            this.RBadmin.Size = new System.Drawing.Size(88, 17);
            this.RBadmin.TabIndex = 8;
            this.RBadmin.Text = "Administrador";
            this.RBadmin.UseVisualStyleBackColor = true;
            // 
            // RBrepositor
            // 
            this.RBrepositor.AutoSize = true;
            this.RBrepositor.ForeColor = System.Drawing.Color.AliceBlue;
            this.RBrepositor.Location = new System.Drawing.Point(214, 361);
            this.RBrepositor.Name = "RBrepositor";
            this.RBrepositor.Size = new System.Drawing.Size(70, 17);
            this.RBrepositor.TabIndex = 9;
            this.RBrepositor.Text = "Repositor";
            this.RBrepositor.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.ForeColor = System.Drawing.Color.AliceBlue;
            this.BGuardar.Location = new System.Drawing.Point(214, 438);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 10;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // Bsalir
            // 
            this.Bsalir.BackColor = System.Drawing.Color.SteelBlue;
            this.Bsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsalir.ForeColor = System.Drawing.Color.AliceBlue;
            this.Bsalir.Location = new System.Drawing.Point(57, 438);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(75, 23);
            this.Bsalir.TabIndex = 11;
            this.Bsalir.Text = "Salir";
            this.Bsalir.UseVisualStyleBackColor = false;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // LBapellido
            // 
            this.LBapellido.AutoSize = true;
            this.LBapellido.ForeColor = System.Drawing.Color.AliceBlue;
            this.LBapellido.Location = new System.Drawing.Point(180, 48);
            this.LBapellido.Name = "LBapellido";
            this.LBapellido.Size = new System.Drawing.Size(44, 13);
            this.LBapellido.TabIndex = 12;
            this.LBapellido.Text = "Apellido";
            // 
            // TBapellido
            // 
            this.TBapellido.Location = new System.Drawing.Point(180, 64);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(152, 20);
            this.TBapellido.TabIndex = 13;
            // 
            // Lusername
            // 
            this.Lusername.AutoSize = true;
            this.Lusername.ForeColor = System.Drawing.Color.AliceBlue;
            this.Lusername.Location = new System.Drawing.Point(180, 269);
            this.Lusername.Name = "Lusername";
            this.Lusername.Size = new System.Drawing.Size(98, 13);
            this.Lusername.TabIndex = 14;
            this.Lusername.Text = "Nombre de Usuario";
            // 
            // TBusername
            // 
            this.TBusername.Location = new System.Drawing.Point(180, 285);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(150, 20);
            this.TBusername.TabIndex = 15;
            // 
            // pDBusuarios
            // 
            this.pDBusuarios.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pDBusuarios.Controls.Add(this.dgvUsuarios);
            this.pDBusuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDBusuarios.Location = new System.Drawing.Point(343, 0);
            this.pDBusuarios.Name = "pDBusuarios";
            this.pDBusuarios.Size = new System.Drawing.Size(628, 473);
            this.pDBusuarios.TabIndex = 16;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(681, 473);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // TBtelefono
            // 
            this.TBtelefono.Location = new System.Drawing.Point(12, 143);
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(150, 20);
            this.TBtelefono.TabIndex = 18;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.ForeColor = System.Drawing.Color.AliceBlue;
            this.lTelefono.Location = new System.Drawing.Point(12, 127);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(49, 13);
            this.lTelefono.TabIndex = 17;
            this.lTelefono.Text = "Telefono";
            this.lTelefono.Click += new System.EventHandler(this.lTelefono_Click);
            // 
            // TBdireccion
            // 
            this.TBdireccion.Location = new System.Drawing.Point(178, 143);
            this.TBdireccion.Name = "TBdireccion";
            this.TBdireccion.Size = new System.Drawing.Size(150, 20);
            this.TBdireccion.TabIndex = 20;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.ForeColor = System.Drawing.Color.AliceBlue;
            this.lDireccion.Location = new System.Drawing.Point(178, 127);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(52, 13);
            this.lDireccion.TabIndex = 19;
            this.lDireccion.Text = "Direccion";
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(12, 217);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(150, 20);
            this.TBDni.TabIndex = 22;
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.ForeColor = System.Drawing.Color.AliceBlue;
            this.lDNI.Location = new System.Drawing.Point(12, 201);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(26, 13);
            this.lDNI.TabIndex = 21;
            this.lDNI.Text = "DNI";
            // 
            // addUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(971, 473);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.lDNI);
            this.Controls.Add(this.TBdireccion);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.TBtelefono);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.pDBusuarios);
            this.Controls.Add(this.TBusername);
            this.Controls.Add(this.Lusername);
            this.Controls.Add(this.TBapellido);
            this.Controls.Add(this.LBapellido);
            this.Controls.Add(this.Bsalir);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.RBrepositor);
            this.Controls.Add(this.RBadmin);
            this.Controls.Add(this.RBvendedor);
            this.Controls.Add(this.Lrol);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.LPass);
            this.Controls.Add(this.TBmail);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.Lnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addUsuario";
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.addUsuario_Load);
            this.pDBusuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.TextBox TBmail;
        private System.Windows.Forms.Label LPass;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.Label Lrol;
        private System.Windows.Forms.RadioButton RBvendedor;
        private System.Windows.Forms.RadioButton RBadmin;
        private System.Windows.Forms.RadioButton RBrepositor;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button Bsalir;
        private System.Windows.Forms.Label LBapellido;
        private System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.Label Lusername;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.Panel pDBusuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox TBtelefono;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.TextBox TBdireccion;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label lDNI;
    }
}