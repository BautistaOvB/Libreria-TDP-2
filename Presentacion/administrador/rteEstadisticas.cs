using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gestion_Libreria.Presentacion.administrador
{
    public partial class rteEstadisticas : Form
    {
        public rteEstadisticas()
        {
            InitializeComponent();
            this.Load += rteEstadisticas_Load;
        }
        private void rteEstadisticas_Load(object sender, EventArgs e)
        {
            CargarGraficoVendedores();
            CargarGraficoCategorias();
            CargarGraficoProductos();
        }

        private void CargarGraficoVendedores()
        {
            VentaDatos datos = new VentaDatos();
            var lista = datos.ObtenerVentasPorVendedor();

            chartVendedores.Series.Clear();
            chartVendedores.Titles.Clear();
            chartVendedores.Titles.Add("Ventas por Vendedor");

            // Ajustamos un poco el diseño visual
            chartVendedores.Palette = ChartColorPalette.BrightPastel;

            Series serie = new Series("Ventas");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;

            // Para que muestre el nombre y el monto formateado
            serie.Label = "#PERCENT{P0}"; // Muestra el porcentaje en la torta
            serie.LegendText = "#VALX"; // Muestra el nombre en la leyenda

            foreach (var item in lista)
            {
                // El "X" es el nombre, el "Y" es el valor
                serie.Points.AddXY(item.NombreVendedor, item.TotalVendido);
            }

            chartVendedores.Series.Add(serie);
        }

        private void CargarGraficoCategorias()
        {
            VentaDatos datos = new VentaDatos();
            var lista = datos.ObtenerVentasPorCategoria();

            chartCategorias.Series.Clear();
            chartCategorias.Titles.Clear();
            chartCategorias.Titles.Add("Ventas por Categoría");
            chartCategorias.Palette = ChartColorPalette.Excel;

            Series serie = new Series("Ventas");
            serie.ChartType = SeriesChartType.Doughnut;
            serie.IsValueShownAsLabel = true;

            serie.Label= "#PERCENT{P0}"; // 👈 Muestra el porcentaje adentro
            serie.LegendText = "#VALX"; // 👈 Muestra el nombre en la leyenda
            serie.ToolTip = "#VALX: #VAL{C0}"; // ToolTip con el monto

            foreach (var item in lista)
            {
                serie.Points.AddXY(item.Categoria, item.TotalVendido);
            }

            chartCategorias.Series.Add(serie);
        }

        private void CargarGraficoProductos()
        {
            VentaDatos datos = new VentaDatos();
            var lista = datos.ObtenerProductosMasVendidosPorCategoria();

            chartProductos.Series.Clear();
            chartProductos.Titles.Clear();
            chartProductos.Titles.Add("Libro más vendido por Categoría");
            chartProductos.Legends.Clear(); // Ocultamos la leyenda (opcional)

            // 👇 ACÁ VAN LAS LÍNEAS PARA QUITAR LA GRILLA NEGRA (que estaban mal ubicadas arriba)
            chartProductos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartProductos.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartProductos.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartProductos.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            Series serie = new Series("Cantidad");
            serie.ChartType = SeriesChartType.Bar;
            serie.IsValueShownAsLabel = true;
            serie.Palette = ChartColorPalette.SeaGreen; // Le pusimos un color más lindo a las barras

            foreach (var item in lista)
            {
                string etiqueta = $"{item.Categoria}\n({item.NombreLibro})";
                serie.Points.AddXY(etiqueta, item.CantidadVendida);
            }

            chartProductos.Series.Add(serie);
        }
    }
}
