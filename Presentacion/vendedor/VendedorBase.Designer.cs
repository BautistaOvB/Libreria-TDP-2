using System.Windows.Forms;

namespace Gestion_Libreria.Presentacion.vendedor
{
    partial class VendedorBase
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

        private Form formularioActivo = null;

        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Si ya hay un formulario abierto en el panel, lo cerramos
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;

            // Configuración para incrustar el formulario dentro del panel
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Quita los bordes y botones de cerrar
            formularioHijo.Dock = DockStyle.Fill;                  // Lo adapta al tamaño del panel

            PanelContenedor.Controls.Add(formularioHijo);
            PanelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCajeroProductos = new System.Windows.Forms.Button();
            this.BtnRegistroVta = new System.Windows.Forms.Button();
            this.BtnRteVtaCajero = new System.Windows.Forms.Button();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gestion_Libreria.Properties.Resources.punto_y_barra_azul_blanco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCajeroProductos
            // 
            this.BtnCajeroProductos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnCajeroProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCajeroProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCajeroProductos.Location = new System.Drawing.Point(12, 263);
            this.BtnCajeroProductos.Name = "BtnCajeroProductos";
            this.BtnCajeroProductos.Size = new System.Drawing.Size(140, 50);
            this.BtnCajeroProductos.TabIndex = 1;
            this.BtnCajeroProductos.Text = "Ver Productos";
            this.BtnCajeroProductos.UseVisualStyleBackColor = false;
            this.BtnCajeroProductos.Click += new System.EventHandler(this.BtnCajeroProductos_Click);
            // 
            // BtnRegistroVta
            // 
            this.BtnRegistroVta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnRegistroVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroVta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRegistroVta.Location = new System.Drawing.Point(12, 172);
            this.BtnRegistroVta.Name = "BtnRegistroVta";
            this.BtnRegistroVta.Size = new System.Drawing.Size(140, 50);
            this.BtnRegistroVta.TabIndex = 2;
            this.BtnRegistroVta.Text = "Registrar Venta";
            this.BtnRegistroVta.UseVisualStyleBackColor = false;
            this.BtnRegistroVta.Click += new System.EventHandler(this.BtnRegistroVta_Click);
            // 
            // BtnRteVtaCajero
            // 
            this.BtnRteVtaCajero.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnRteVtaCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRteVtaCajero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRteVtaCajero.Location = new System.Drawing.Point(12, 360);
            this.BtnRteVtaCajero.Name = "BtnRteVtaCajero";
            this.BtnRteVtaCajero.Size = new System.Drawing.Size(140, 50);
            this.BtnRteVtaCajero.TabIndex = 3;
            this.BtnRteVtaCajero.Text = "Ver Ventas Realizadas";
            this.BtnRteVtaCajero.UseVisualStyleBackColor = false;
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelBotones.Controls.Add(this.BtnRteVtaCajero);
            this.PanelBotones.Controls.Add(this.BtnRegistroVta);
            this.PanelBotones.Controls.Add(this.BtnCajeroProductos);
            this.PanelBotones.Controls.Add(this.pictureBox1);
            this.PanelBotones.Cursor = System.Windows.Forms.Cursors.No;
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelBotones.Location = new System.Drawing.Point(0, 0);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(166, 450);
            this.PanelBotones.TabIndex = 2;
            this.PanelBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBotones_Paint);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(166, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(634, 450);
            this.PanelContenedor.TabIndex = 3;
            // 
            // VendedorBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelBotones);
            this.Name = "VendedorBase";
            this.Text = "Punto y Barra | Cajero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnCajeroProductos;
        private Button BtnRegistroVta;
        private Button BtnRteVtaCajero;
        private Panel PanelBotones;
        private Panel PanelContenedor;
    }
}