namespace Gestion_Libreria.Presentacion.administrador
{
    partial class rteEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rteEstadisticas));
            this.pGraficoLxC = new System.Windows.Forms.Panel();
            this.chartCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pGraficoVtop = new System.Windows.Forms.Panel();
            this.chartVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pGraficoTxGenero = new System.Windows.Forms.Panel();
            this.chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pGraficoLxC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).BeginInit();
            this.pGraficoVtop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendedores)).BeginInit();
            this.pGraficoTxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pGraficoLxC
            // 
            this.pGraficoLxC.BackColor = System.Drawing.Color.MidnightBlue;
            this.pGraficoLxC.Controls.Add(this.chartCategorias);
            this.pGraficoLxC.Dock = System.Windows.Forms.DockStyle.Left;
            this.pGraficoLxC.Location = new System.Drawing.Point(0, 0);
            this.pGraficoLxC.Name = "pGraficoLxC";
            this.pGraficoLxC.Size = new System.Drawing.Size(362, 500);
            this.pGraficoLxC.TabIndex = 0;
            // 
            // chartCategorias
            // 
            this.chartCategorias.BackColor = System.Drawing.Color.LightSteelBlue;
            chartArea1.Name = "ChartArea1";
            this.chartCategorias.ChartAreas.Add(chartArea1);
            this.chartCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCategorias.Legends.Add(legend1);
            this.chartCategorias.Location = new System.Drawing.Point(0, 0);
            this.chartCategorias.Name = "chartCategorias";
            this.chartCategorias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCategorias.Series.Add(series1);
            this.chartCategorias.Size = new System.Drawing.Size(362, 500);
            this.chartCategorias.TabIndex = 0;
            this.chartCategorias.Text = "chart1";
            // 
            // pGraficoVtop
            // 
            this.pGraficoVtop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pGraficoVtop.Controls.Add(this.chartVendedores);
            this.pGraficoVtop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGraficoVtop.Location = new System.Drawing.Point(362, 0);
            this.pGraficoVtop.Name = "pGraficoVtop";
            this.pGraficoVtop.Size = new System.Drawing.Size(352, 500);
            this.pGraficoVtop.TabIndex = 1;
            // 
            // chartVendedores
            // 
            this.chartVendedores.BackColor = System.Drawing.Color.LightSteelBlue;
            chartArea2.Name = "ChartArea1";
            this.chartVendedores.ChartAreas.Add(chartArea2);
            this.chartVendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartVendedores.Legends.Add(legend2);
            this.chartVendedores.Location = new System.Drawing.Point(0, 0);
            this.chartVendedores.Name = "chartVendedores";
            this.chartVendedores.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVendedores.Series.Add(series2);
            this.chartVendedores.Size = new System.Drawing.Size(352, 500);
            this.chartVendedores.TabIndex = 0;
            this.chartVendedores.Text = "Vendedores con mas ventas";
            // 
            // pGraficoTxGenero
            // 
            this.pGraficoTxGenero.BackColor = System.Drawing.Color.MidnightBlue;
            this.pGraficoTxGenero.Controls.Add(this.chartProductos);
            this.pGraficoTxGenero.Dock = System.Windows.Forms.DockStyle.Right;
            //this.pGraficoTxGenero.Location = new System.Drawing.Point(714, 0);
            this.pGraficoTxGenero.Name = "pGraficoTxGenero";
            //this.pGraficoTxGenero.Size = new System.Drawing.Size(365, 500);
            this.pGraficoTxGenero.TabIndex = 2;
            // 
            // chartProductos
            // 
            this.chartProductos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chartProductos.BorderlineColor = System.Drawing.Color.Honeydew;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartProductos.ChartAreas.Add(chartArea3);
            this.chartProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartProductos.Legends.Add(legend3);
            this.chartProductos.Location = new System.Drawing.Point(0, 0);
            this.chartProductos.Name = "chartProductos";
            this.chartProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartProductos.Series.Add(series3);
            this.chartProductos.Size = new System.Drawing.Size(365, 500);
            this.chartProductos.TabIndex = 0;
            this.chartProductos.Text = "chart1";
            // 
            // rteEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1079, 500);
            this.Controls.Add(this.pGraficoVtop);
            this.Controls.Add(this.pGraficoTxGenero);
            this.Controls.Add(this.pGraficoLxC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rteEstadisticas";
            this.Text = "Punto Barra | Reporte Estadístico";
            this.pGraficoLxC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).EndInit();
            this.pGraficoVtop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVendedores)).EndInit();
            this.pGraficoTxGenero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pGraficoLxC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategorias;
        private System.Windows.Forms.Panel pGraficoVtop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendedores;
        private System.Windows.Forms.Panel pGraficoTxGenero;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductos;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}