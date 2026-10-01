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
            this.BtnCajeroProductos = new System.Windows.Forms.Button();
            this.BtnRegistroVta = new System.Windows.Forms.Button();
            this.BtnRteVtaCajero = new System.Windows.Forms.Button();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCajeroProductos
            // 
            this.BtnCajeroProductos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnCajeroProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCajeroProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCajeroProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCajeroProductos.Location = new System.Drawing.Point(12, 252);
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
            this.BtnRegistroVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroVta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRegistroVta.Location = new System.Drawing.Point(12, 186);
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
            this.BtnRteVtaCajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRteVtaCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRteVtaCajero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRteVtaCajero.Location = new System.Drawing.Point(12, 319);
            this.BtnRteVtaCajero.Name = "BtnRteVtaCajero";
            this.BtnRteVtaCajero.Size = new System.Drawing.Size(140, 50);
            this.BtnRteVtaCajero.TabIndex = 3;
            this.BtnRteVtaCajero.Text = "Ver Ventas Realizadas";
            this.BtnRteVtaCajero.UseVisualStyleBackColor = false;
            this.BtnRteVtaCajero.Click += new System.EventHandler(this.BtnRteVtaCajero_Click);
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelBotones.Controls.Add(this.btnCliente);
            this.PanelBotones.Controls.Add(this.btnSalir);
            this.PanelBotones.Controls.Add(this.BtnRteVtaCajero);
            this.PanelBotones.Controls.Add(this.BtnRegistroVta);
            this.PanelBotones.Controls.Add(this.BtnCajeroProductos);
            this.PanelBotones.Controls.Add(this.pictureBox1);
            this.PanelBotones.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelBotones.Location = new System.Drawing.Point(0, 0);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(166, 450);
            this.PanelBotones.TabIndex = 2;
            this.PanelBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBotones_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(45, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(166, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(634, 450);
            this.PanelContenedor.TabIndex = 3;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 386);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(140, 52);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Gestionar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gestion_Libreria.Properties.Resources.punto_y_barra_azul_blanco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(31, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.PanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnCajeroProductos;
        private Button BtnRegistroVta;
        private Button BtnRteVtaCajero;
        private Panel PanelBotones;
        private Panel PanelContenedor;
        private Button btnSalir;
        private Button btnCliente;
    }
}