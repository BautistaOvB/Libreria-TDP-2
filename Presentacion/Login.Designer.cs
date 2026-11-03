namespace Gestion_Libreria.Presentacion
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.Lpassword = new System.Windows.Forms.Label();
            this.LtituloLogin = new System.Windows.Forms.Label();
            this.Bsalir = new System.Windows.Forms.Button();
            this.imgInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(341, 202);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 0;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(235, 77);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(143, 20);
            this.usernameText.TabIndex = 1;
            // 
            // PassText
            // 
            this.PassText.HideSelection = false;
            this.PassText.Location = new System.Drawing.Point(236, 150);
            this.PassText.Name = "PassText";
            this.PassText.PasswordChar = '*';
            this.PassText.Size = new System.Drawing.Size(143, 20);
            this.PassText.TabIndex = 2;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LUsuario.Location = new System.Drawing.Point(235, 58);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(125, 16);
            this.LUsuario.TabIndex = 4;
            this.LUsuario.Text = "Nombre de Usuario";
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.BackColor = System.Drawing.Color.SteelBlue;
            this.Lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lpassword.Location = new System.Drawing.Point(235, 131);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(76, 16);
            this.Lpassword.TabIndex = 5;
            this.Lpassword.Text = "Contraseña";
            // 
            // LtituloLogin
            // 
            this.LtituloLogin.AutoSize = true;
            this.LtituloLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.LtituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtituloLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LtituloLogin.Location = new System.Drawing.Point(178, 9);
            this.LtituloLogin.Name = "LtituloLogin";
            this.LtituloLogin.Size = new System.Drawing.Size(200, 20);
            this.LtituloLogin.TabIndex = 6;
            this.LtituloLogin.Text = "Bienvenido a Punto y Barra";
            // 
            // Bsalir
            // 
            this.Bsalir.Location = new System.Drawing.Point(238, 202);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(75, 23);
            this.Bsalir.TabIndex = 7;
            this.Bsalir.Text = "Salir";
            this.Bsalir.UseVisualStyleBackColor = true;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // imgInicio
            // 
            this.imgInicio.BackColor = System.Drawing.Color.Transparent;
            this.imgInicio.BackgroundImage = global::Gestion_Libreria.Properties.Resources.punto_y_barra_azul_blanco;
            this.imgInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgInicio.Image = global::Gestion_Libreria.Properties.Resources.punto_y_barra_azul_blanco;
            this.imgInicio.Location = new System.Drawing.Point(22, 49);
            this.imgInicio.Name = "imgInicio";
            this.imgInicio.Size = new System.Drawing.Size(166, 176);
            this.imgInicio.TabIndex = 3;
            this.imgInicio.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.Bsalir);
            this.Controls.Add(this.LtituloLogin);
            this.Controls.Add(this.Lpassword);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.imgInicio);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.BtnIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Inicio Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.PictureBox imgInicio;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label Lpassword;
        private System.Windows.Forms.Label LtituloLogin;
        private System.Windows.Forms.Button Bsalir;
    }
}

