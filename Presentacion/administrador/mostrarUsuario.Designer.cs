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
            this.TBnya = new System.Windows.Forms.TextBox();
            this.Lemail = new System.Windows.Forms.Label();
            this.TBmail = new System.Windows.Forms.TextBox();
            this.Lusuario = new System.Windows.Forms.Label();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.LRoles = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.punto_Barra_tdpDataSet = new Gestion_Libreria.Punto_Barra_tdpDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Gestion_Libreria.Punto_Barra_tdpDataSetTableAdapters.usuariosTableAdapter();
            this.punto_Barra_tdpDataSet2 = new Gestion_Libreria.Punto_Barra_tdpDataSet2();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Gestion_Libreria.Punto_Barra_tdpDataSet2TableAdapters.rolesTableAdapter();
            this.Beditar = new System.Windows.Forms.Button();
            this.Bguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
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
            // TBnya
            // 
            this.TBnya.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TBnya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBnya.Location = new System.Drawing.Point(26, 68);
            this.TBnya.Name = "TBnya";
            this.TBnya.ReadOnly = true;
            this.TBnya.Size = new System.Drawing.Size(209, 20);
            this.TBnya.TabIndex = 1;
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
            // TBmail
            // 
            this.TBmail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TBmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBmail.Location = new System.Drawing.Point(26, 133);
            this.TBmail.Name = "TBmail";
            this.TBmail.ReadOnly = true;
            this.TBmail.Size = new System.Drawing.Size(209, 20);
            this.TBmail.TabIndex = 3;
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
            // TBusuario
            // 
            this.TBusuario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TBusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBusuario.Location = new System.Drawing.Point(29, 196);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(206, 20);
            this.TBusuario.TabIndex = 5;
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rolesBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // punto_Barra_tdpDataSet2
            // 
            this.punto_Barra_tdpDataSet2.DataSetName = "Punto_Barra_tdpDataSet2";
            this.punto_Barra_tdpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.punto_Barra_tdpDataSet2;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // Beditar
            // 
            this.Beditar.Location = new System.Drawing.Point(29, 357);
            this.Beditar.Name = "Beditar";
            this.Beditar.Size = new System.Drawing.Size(75, 23);
            this.Beditar.TabIndex = 8;
            this.Beditar.Text = "Editar";
            this.Beditar.UseVisualStyleBackColor = true;
            // 
            // Bguardar
            // 
            this.Bguardar.Location = new System.Drawing.Point(160, 357);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.Size = new System.Drawing.Size(75, 23);
            this.Bguardar.TabIndex = 9;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.UseVisualStyleBackColor = true;
            // 
            // mostrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(292, 392);
            this.Controls.Add(this.Bguardar);
            this.Controls.Add(this.Beditar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LRoles);
            this.Controls.Add(this.TBusuario);
            this.Controls.Add(this.Lusuario);
            this.Controls.Add(this.TBmail);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.TBnya);
            this.Controls.Add(this.LNyA);
            this.Name = "mostrarUsuario";
            this.Text = "Ver usuario";
            this.Load += new System.EventHandler(this.mostrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNyA;
        private System.Windows.Forms.TextBox TBnya;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.TextBox TBmail;
        private System.Windows.Forms.Label Lusuario;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.Label LRoles;
        private System.Windows.Forms.ComboBox comboBox1;
        private Punto_Barra_tdpDataSet punto_Barra_tdpDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private Punto_Barra_tdpDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private Punto_Barra_tdpDataSet2 punto_Barra_tdpDataSet2;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private Punto_Barra_tdpDataSet2TableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button Beditar;
        private System.Windows.Forms.Button Bguardar;
    }
}