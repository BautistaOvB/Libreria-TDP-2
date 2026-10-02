namespace Gestion_Libreria.Presentacion.administrador
{
    partial class Admin_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Base));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStock = new System.Windows.Forms.Button();
            this.BtnRptVentas = new System.Windows.Forms.Button();
            this.VerUsuario = new System.Windows.Forms.Button();
            this.BtnAddUsuario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.BtnRptVentas);
            this.panel1.Controls.Add(this.VerUsuario);
            this.panel1.Controls.Add(this.BtnAddUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 529);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Gestion_Libreria.Properties.Resources.punto_y_barra_azul_blanco;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(36, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 88);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStock.Location = new System.Drawing.Point(12, 434);
            this.btnStock.Margin = new System.Windows.Forms.Padding(0);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(140, 50);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Ver Inventario";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // BtnRptVentas
            // 
            this.BtnRptVentas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnRptVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRptVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRptVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRptVentas.Location = new System.Drawing.Point(12, 337);
            this.BtnRptVentas.Name = "BtnRptVentas";
            this.BtnRptVentas.Size = new System.Drawing.Size(140, 50);
            this.BtnRptVentas.TabIndex = 2;
            this.BtnRptVentas.Text = "Reporte de Ventas";
            this.BtnRptVentas.UseVisualStyleBackColor = false;
            this.BtnRptVentas.Click += new System.EventHandler(this.BtnRptVentas_Click);
            // 
            // VerUsuario
            // 
            this.VerUsuario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.VerUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VerUsuario.Location = new System.Drawing.Point(12, 238);
            this.VerUsuario.Name = "VerUsuario";
            this.VerUsuario.Padding = new System.Windows.Forms.Padding(10);
            this.VerUsuario.Size = new System.Drawing.Size(140, 50);
            this.VerUsuario.TabIndex = 1;
            this.VerUsuario.Text = "Ver Usuarios";
            this.VerUsuario.UseVisualStyleBackColor = false;
            this.VerUsuario.Click += new System.EventHandler(this.VerUsuario_Click);
            // 
            // BtnAddUsuario
            // 
            this.BtnAddUsuario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnAddUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddUsuario.Location = new System.Drawing.Point(12, 149);
            this.BtnAddUsuario.Name = "BtnAddUsuario";
            this.BtnAddUsuario.Size = new System.Drawing.Size(140, 50);
            this.BtnAddUsuario.TabIndex = 0;
            this.BtnAddUsuario.Text = "Registrar Usuario";
            this.BtnAddUsuario.UseVisualStyleBackColor = false;
            this.BtnAddUsuario.Click += new System.EventHandler(this.BtnAddUsuario_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(163, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 100);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImage = global::Gestion_Libreria.Properties.Resources.punto_y_barra_usuarios_registrados;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Gestion_Libreria.Properties.Resources.punto_y_barra_usuarios_registrados;
            this.pictureBox1.Location = new System.Drawing.Point(794, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Administrador";
            this.label1.Visible = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(163, 100);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(884, 429);
            this.PanelContenedor.TabIndex = 2;
            // 
            // Admin_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1047, 529);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Base";
            this.Text = "Punto y Barra | Administrador";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button VerUsuario;
        private System.Windows.Forms.Button BtnAddUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button BtnRptVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}