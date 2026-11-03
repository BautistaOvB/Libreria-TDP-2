namespace Gestion_Libreria.Presentacion.administrador
{
    partial class mostrarUsuario
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
            this.LNyA = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.Lemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Lusuario = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.LRoles = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punto_Barra_tdpDataSet2 = new Gestion_Libreria.Punto_Barra_tdpDataSet2();
            this.punto_Barra_tdpDataSet = new Gestion_Libreria.Punto_Barra_tdpDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Gestion_Libreria.Punto_Barra_tdpDataSetTableAdapters.usuariosTableAdapter();
            this.rolesTableAdapter = new Gestion_Libreria.Punto_Barra_tdpDataSet2TableAdapters.rolesTableAdapter();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LNyA
            // 
            this.LNyA.AutoSize = true;
            this.LNyA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LNyA.Location = new System.Drawing.Point(23, 51);
            this.LNyA.Name = "LNyA";
            this.LNyA.Size = new System.Drawing.Size(92, 13);
            this.LNyA.TabIndex = 0;
            this.LNyA.Text = "Nombre y Apellido";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompleto.Location = new System.Drawing.Point(26, 68);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.ReadOnly = true;
            this.txtNombreCompleto.Size = new System.Drawing.Size(209, 20);
            this.txtNombreCompleto.TabIndex = 1;
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lemail.Location = new System.Drawing.Point(23, 117);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(32, 13);
            this.Lemail.TabIndex = 2;
            this.Lemail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(26, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(209, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // Lusuario
            // 
            this.Lusuario.AutoSize = true;
            this.Lusuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lusuario.Location = new System.Drawing.Point(26, 179);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(43, 13);
            this.Lusuario.TabIndex = 4;
            this.Lusuario.Text = "Usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(29, 196);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(206, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // LRoles
            // 
            this.LRoles.AutoSize = true;
            this.LRoles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LRoles.Location = new System.Drawing.Point(26, 245);
            this.LRoles.Name = "LRoles";
            this.LRoles.Size = new System.Drawing.Size(23, 13);
            this.LRoles.TabIndex = 6;
            this.LRoles.Text = "Rol";
            // 
            // cmbRol
            // 
            this.cmbRol.DataSource = this.rolesBindingSource;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(29, 261);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(206, 21);
            this.cmbRol.TabIndex = 7;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.punto_Barra_tdpDataSet2;
            // 
            // punto_Barra_tdpDataSet2
            // 
            this.punto_Barra_tdpDataSet2.DataSetName = "Punto_Barra_tdpDataSet2";
            this.punto_Barra_tdpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // punto_Barra_tdpDataSet
            // 
            this.punto_Barra_tdpDataSet.DataSetName = "Punto_Barra_tdpDataSet";
            this.punto_Barra_tdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.punto_Barra_tdpDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(29, 357);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(160, 357);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // mostrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(292, 392);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.LRoles);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Lusuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.LNyA);
            this.Name = "mostrarUsuario";
            this.Text = "Ver usuario";
            this.Load += new System.EventHandler(this.mostrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNyA;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Lusuario;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label LRoles;
        private System.Windows.Forms.ComboBox cmbRol;
        private Punto_Barra_tdpDataSet punto_Barra_tdpDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private Punto_Barra_tdpDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private Punto_Barra_tdpDataSet2 punto_Barra_tdpDataSet2;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private Punto_Barra_tdpDataSet2TableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
    }
}