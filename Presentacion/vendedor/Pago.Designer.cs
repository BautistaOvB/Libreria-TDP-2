namespace Gestion_Libreria.Presentacion.vendedor
{
    partial class Pago
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
            this.pCabecera = new System.Windows.Forms.Panel();
            this.lCarrito = new System.Windows.Forms.Label();
            this.pDatagrid = new System.Windows.Forms.Panel();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lCvv = new System.Windows.Forms.Label();
            this.lTitular = new System.Windows.Forms.Label();
            this.lNro = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtNtarjeta = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lCliente = new System.Windows.Forms.Label();
            this.lMetodo = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.metodospagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.punto_Barra_tdpDataSet1 = new Gestion_Libreria.Punto_Barra_tdpDataSet1();
            this.punto_Barra_tdpDataSet = new Gestion_Libreria.Punto_Barra_tdpDataSet();
            this.puntoBarratdpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodospagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodos_pagoTableAdapter = new Gestion_Libreria.Punto_Barra_tdpDataSet1TableAdapters.metodos_pagoTableAdapter();
            this.pCabecera.SuspendLayout();
            this.pDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metodospagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarratdpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodospagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pCabecera
            // 
            this.pCabecera.BackColor = System.Drawing.Color.MidnightBlue;
            this.pCabecera.Controls.Add(this.lCarrito);
            this.pCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCabecera.Location = new System.Drawing.Point(0, 0);
            this.pCabecera.Name = "pCabecera";
            this.pCabecera.Size = new System.Drawing.Size(497, 74);
            this.pCabecera.TabIndex = 0;
            // 
            // lCarrito
            // 
            this.lCarrito.AutoSize = true;
            this.lCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCarrito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lCarrito.Location = new System.Drawing.Point(12, 26);
            this.lCarrito.Name = "lCarrito";
            this.lCarrito.Size = new System.Drawing.Size(164, 20);
            this.lCarrito.TabIndex = 0;
            this.lCarrito.Text = "Carrito de Compras";
            // 
            // pDatagrid
            // 
            this.pDatagrid.BackColor = System.Drawing.Color.SteelBlue;
            this.pDatagrid.Controls.Add(this.dgvCarrito);
            this.pDatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatagrid.ForeColor = System.Drawing.Color.SteelBlue;
            this.pDatagrid.Location = new System.Drawing.Point(0, 74);
            this.pDatagrid.Name = "pDatagrid";
            this.pDatagrid.Size = new System.Drawing.Size(497, 398);
            this.pDatagrid.TabIndex = 1;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToOrderColumns = true;
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(0, 0);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(497, 398);
            this.dgvCarrito.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.lCvv);
            this.panel2.Controls.Add(this.lTitular);
            this.panel2.Controls.Add(this.lNro);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.txtCvv);
            this.panel2.Controls.Add(this.txtTitular);
            this.panel2.Controls.Add(this.txtNtarjeta);
            this.panel2.Controls.Add(this.cmbCliente);
            this.panel2.Controls.Add(this.lCliente);
            this.panel2.Controls.Add(this.lMetodo);
            this.panel2.Controls.Add(this.cmbMetodo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 160);
            this.panel2.TabIndex = 2;
            // 
            // lCvv
            // 
            this.lCvv.AutoSize = true;
            this.lCvv.ForeColor = System.Drawing.Color.AliceBlue;
            this.lCvv.Location = new System.Drawing.Point(382, 90);
            this.lCvv.Name = "lCvv";
            this.lCvv.Size = new System.Drawing.Size(28, 13);
            this.lCvv.TabIndex = 11;
            this.lCvv.Text = "CVV";
            // 
            // lTitular
            // 
            this.lTitular.AutoSize = true;
            this.lTitular.ForeColor = System.Drawing.Color.AliceBlue;
            this.lTitular.Location = new System.Drawing.Point(269, 64);
            this.lTitular.Name = "lTitular";
            this.lTitular.Size = new System.Drawing.Size(93, 13);
            this.lTitular.TabIndex = 10;
            this.lTitular.Text = "Nombre del Titular";
            // 
            // lNro
            // 
            this.lNro.AutoSize = true;
            this.lNro.ForeColor = System.Drawing.Color.AliceBlue;
            this.lNro.Location = new System.Drawing.Point(307, 39);
            this.lNro.Name = "lNro";
            this.lNro.Size = new System.Drawing.Size(55, 13);
            this.lNro.TabIndex = 9;
            this.lNro.Text = "N° Tarjeta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCancelar.Location = new System.Drawing.Point(295, 125);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnConfirmar.Location = new System.Drawing.Point(385, 125);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(97, 23);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar pago";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(417, 87);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(65, 20);
            this.txtCvv.TabIndex = 6;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(365, 61);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(117, 20);
            this.txtTitular.TabIndex = 5;
            // 
            // txtNtarjeta
            // 
            this.txtNtarjeta.Location = new System.Drawing.Point(365, 33);
            this.txtNtarjeta.Name = "txtNtarjeta";
            this.txtNtarjeta.Size = new System.Drawing.Size(117, 20);
            this.txtNtarjeta.TabIndex = 4;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(49, 78);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 3;
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lCliente.Location = new System.Drawing.Point(46, 61);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(110, 13);
            this.lCliente.TabIndex = 2;
            this.lCliente.Text = "Seleccione un Cliente";
            // 
            // lMetodo
            // 
            this.lMetodo.AutoSize = true;
            this.lMetodo.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lMetodo.Location = new System.Drawing.Point(43, 17);
            this.lMetodo.Name = "lMetodo";
            this.lMetodo.Size = new System.Drawing.Size(114, 13);
            this.lMetodo.TabIndex = 1;
            this.lMetodo.Text = "Seleccione un Metodo";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DataSource = this.metodospagoBindingSource1;
            this.cmbMetodo.DisplayMember = "nombre";
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Location = new System.Drawing.Point(46, 33);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodo.TabIndex = 0;
            this.cmbMetodo.ValueMember = "id_metodo";
            // 
            // metodospagoBindingSource1
            // 
            this.metodospagoBindingSource1.DataMember = "metodos_pago";
            this.metodospagoBindingSource1.DataSource = this.punto_Barra_tdpDataSet1;
            // 
            // punto_Barra_tdpDataSet1
            // 
            this.punto_Barra_tdpDataSet1.DataSetName = "Punto_Barra_tdpDataSet1";
            this.punto_Barra_tdpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // punto_Barra_tdpDataSet
            // 
            this.punto_Barra_tdpDataSet.DataSetName = "Punto_Barra_tdpDataSet";
            this.punto_Barra_tdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puntoBarratdpDataSetBindingSource
            // 
            this.puntoBarratdpDataSetBindingSource.DataSource = this.punto_Barra_tdpDataSet;
            this.puntoBarratdpDataSetBindingSource.Position = 0;
            // 
            // metodospagoBindingSource
            // 
            this.metodospagoBindingSource.DataMember = "metodos_pago";
            this.metodospagoBindingSource.DataSource = this.punto_Barra_tdpDataSet1;
            // 
            // metodos_pagoTableAdapter
            // 
            this.metodos_pagoTableAdapter.ClearBeforeFill = true;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pDatagrid);
            this.Controls.Add(this.pCabecera);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            this.pCabecera.ResumeLayout(false);
            this.pCabecera.PerformLayout();
            this.pDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metodospagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_Barra_tdpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBarratdpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodospagoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCabecera;
        private System.Windows.Forms.Label lCarrito;
        private System.Windows.Forms.Panel pDatagrid;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private Punto_Barra_tdpDataSet punto_Barra_tdpDataSet;
        private System.Windows.Forms.BindingSource puntoBarratdpDataSetBindingSource;
        private Punto_Barra_tdpDataSet1 punto_Barra_tdpDataSet1;
        private System.Windows.Forms.BindingSource metodospagoBindingSource;
        private Punto_Barra_tdpDataSet1TableAdapters.metodos_pagoTableAdapter metodos_pagoTableAdapter;
        private System.Windows.Forms.Label lMetodo;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNtarjeta;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.BindingSource metodospagoBindingSource1;
        private System.Windows.Forms.Label lCvv;
        private System.Windows.Forms.Label lTitular;
        private System.Windows.Forms.Label lNro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}