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
            this.pDBusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lnombre.Location = new System.Drawing.Point(40, 48);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(44, 13);
            this.Lnombre.TabIndex = 0;
            this.Lnombre.Text = "Nombre";
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(43, 64);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(150, 20);
            this.TBnombre.TabIndex = 1;
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lemail.Location = new System.Drawing.Point(43, 155);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(32, 13);
            this.Lemail.TabIndex = 2;
            this.Lemail.Text = "Email";
            this.Lemail.Click += new System.EventHandler(this.Lemail_Click);
            // 
            // TBmail
            // 
            this.TBmail.Location = new System.Drawing.Point(43, 171);
            this.TBmail.Name = "TBmail";
            this.TBmail.Size = new System.Drawing.Size(150, 20);
            this.TBmail.TabIndex = 3;
            // 
            // LPass
            // 
            this.LPass.AutoSize = true;
            this.LPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LPass.Location = new System.Drawing.Point(40, 213);
            this.LPass.Name = "LPass";
            this.LPass.Size = new System.Drawing.Size(61, 13);
            this.LPass.TabIndex = 4;
            this.LPass.Text = "Contraseña";
            // 
            // TBpass
            // 
            this.TBpass.BackColor = System.Drawing.SystemColors.Window;
            this.TBpass.Location = new System.Drawing.Point(43, 229);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(150, 20);
            this.TBpass.TabIndex = 5;
            // 
            // Lrol
            // 
            this.Lrol.AutoSize = true;
            this.Lrol.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.RBvendedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.RBadmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.RBrepositor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RBrepositor.Location = new System.Drawing.Point(214, 361);
            this.RBrepositor.Name = "RBrepositor";
            this.RBrepositor.Size = new System.Drawing.Size(70, 17);
            this.RBrepositor.TabIndex = 9;
            this.RBrepositor.Text = "Repositor";
            this.RBrepositor.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(26, 438);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 10;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // Bsalir
            // 
            this.Bsalir.Location = new System.Drawing.Point(120, 438);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(75, 23);
            this.Bsalir.TabIndex = 11;
            this.Bsalir.Text = "Salir";
            this.Bsalir.UseVisualStyleBackColor = true;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // LBapellido
            // 
            this.LBapellido.AutoSize = true;
            this.LBapellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBapellido.Location = new System.Drawing.Point(43, 99);
            this.LBapellido.Name = "LBapellido";
            this.LBapellido.Size = new System.Drawing.Size(44, 13);
            this.LBapellido.TabIndex = 12;
            this.LBapellido.Text = "Apellido";
            // 
            // TBapellido
            // 
            this.TBapellido.Location = new System.Drawing.Point(43, 115);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(152, 20);
            this.TBapellido.TabIndex = 13;
            // 
            // Lusername
            // 
            this.Lusername.AutoSize = true;
            this.Lusername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lusername.Location = new System.Drawing.Point(40, 276);
            this.Lusername.Name = "Lusername";
            this.Lusername.Size = new System.Drawing.Size(98, 13);
            this.Lusername.TabIndex = 14;
            this.Lusername.Text = "Nombre de Usuario";
            // 
            // TBusername
            // 
            this.TBusername.Location = new System.Drawing.Point(43, 292);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(150, 20);
            this.TBusername.TabIndex = 15;
            // 
            // pDBusuarios
            // 
            this.pDBusuarios.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pDBusuarios.Controls.Add(this.dgvUsuarios);
            this.pDBusuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDBusuarios.Location = new System.Drawing.Point(290, 0);
            this.pDBusuarios.Name = "pDBusuarios";
            this.pDBusuarios.Size = new System.Drawing.Size(681, 473);
            this.pDBusuarios.TabIndex = 16;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(681, 473);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // addUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(971, 473);
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
            this.Name = "addUsuario";
            this.Text = "Agregar Usuario";
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
    }
}