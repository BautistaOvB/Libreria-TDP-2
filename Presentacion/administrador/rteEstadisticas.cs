using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gestion_Libreria.Presentacion.administrador
{
    public partial class rteEstadisticas : Form
    {
        // Controles de filtro
        private Panel panelFiltros;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private ComboBox cboRango;
        private Button btnActualizar;
        private Button btnReset;

        public rteEstadisticas()
        {
            InitializeComponent();
            ConstruirPanelFiltros();

            // Usamos Shown en lugar de Load para evitar que los gráficos intenten calcular
            // posiciones (como InnerPlotPosition) cuando el formulario todavía mide 0px.
            this.Shown += RteEstadisticas_Shown;
        }

        // ============================================================
        // Construcción del panel de filtros
        // ============================================================
        private void ConstruirPanelFiltros()
        {
            panelFiltros = new Panel
            {
                Dock = DockStyle.Top,
                Height = 55,
                BackColor = Color.FromArgb(25, 25, 112), // MidnightBlue
                Padding = new Padding(8)
            };

            // Rango rápido
            cboRango = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 140,
                Location = new Point(10, 15)
            };
            cboRango.Items.AddRange(new object[]
            {
                "Hoy", "Últimos 7 días", "Este mes", "Mes anterior",
                "Este año", "Personalizado"
            });
            cboRango.SelectedIndex = 2; // "Este mes" por defecto
            cboRango.SelectedIndexChanged += CboRango_SelectedIndexChanged;

            // Desde
            var lblDesde = new Label
            {
                Text = "Desde:",
                ForeColor = Color.White,
                Location = new Point(165, 18),
                AutoSize = true
            };
            dtpDesde = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Width = 110,
                Location = new Point(215, 14)
            };

            // Hasta
            var lblHasta = new Label
            {
                Text = "Hasta:",
                ForeColor = Color.White,
                Location = new Point(335, 18),
                AutoSize = true
            };
            dtpHasta = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Width = 110,
                Location = new Point(385, 14)
            };

            // Botones
            btnActualizar = new Button
            {
                Text = "🔄 Actualizar",
                Location = new Point(510, 12),
                Size = new Size(100, 28),
                BackColor = Color.LightSteelBlue,
                FlatStyle = FlatStyle.Flat
            };
            btnActualizar.Click += (s, e) => CargarTodosLosGraficos();

            btnReset = new Button
            {
                Text = "♻ Reset",
                Location = new Point(620, 12),
                Size = new Size(80, 28),
                BackColor = Color.LightSteelBlue,
                FlatStyle = FlatStyle.Flat
            };
            btnReset.Click += (s, e) =>
            {
                cboRango.SelectedIndex = 2;
                CargarTodosLosGraficos();
            };

            panelFiltros.Controls.AddRange(new Control[]
            {
                cboRango, lblDesde, dtpDesde, lblHasta, dtpHasta, btnActualizar, btnReset
            });

            // Panel contenedor de los gráficos
            Panel panelGraficos = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.LightSteelBlue
            };

            // Desacoplamos los paneles de gráficos del form original
            this.Controls.Remove(pGraficoLxC);
            this.Controls.Remove(pGraficoVtop);
            this.Controls.Remove(pGraficoTxGenero);

            // Configuramos el Dock
            pGraficoVtop.Dock = DockStyle.Fill;
            pGraficoTxGenero.Dock = DockStyle.Right;
            pGraficoLxC.Dock = DockStyle.Left;

            // 👇 FORZAMOS UN ANCHO MÍNIMO POR SI EL FORMULARIO ES MUY CHICO
            pGraficoLxC.Width = 300;
            pGraficoTxGenero.Width = 300;

            // (Opcional) Si querés que no se puedan achicar más de cierto tamaño:
            pGraficoLxC.MinimumSize = new Size(200, 0);
            pGraficoTxGenero.MinimumSize = new Size(200, 0);
            pGraficoVtop.MinimumSize = new Size(200, 0);

            // Los agregamos al contenedor (el orden importa para el Dock)
            panelGraficos.Controls.Add(pGraficoVtop);      // Centro
            panelGraficos.Controls.Add(pGraficoTxGenero);  // Derecha
            panelGraficos.Controls.Add(pGraficoLxC);       // Izquierda

            // Agregamos al formulario (primero gráficos, luego filtros arriba)
            this.Controls.Add(panelGraficos);
            this.Controls.Add(panelFiltros);
        }

        // ============================================================
        // Eventos
        // ============================================================
        private void RteEstadisticas_Shown(object sender, EventArgs e)
        {
            CargarTodosLosGraficos();
        }

        private void CboRango_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;

            switch (cboRango.SelectedItem.ToString())
            {
                case "Hoy":
                    dtpDesde.Value = hoy;
                    dtpHasta.Value = hoy;
                    break;
                case "Últimos 7 días":
                    dtpDesde.Value = hoy.AddDays(-6);
                    dtpHasta.Value = hoy;
                    break;
                case "Este mes":
                    dtpDesde.Value = new DateTime(hoy.Year, hoy.Month, 1);
                    dtpHasta.Value = hoy;
                    break;
                case "Mes anterior":
                    var primerDiaMesAnt = new DateTime(hoy.Year, hoy.Month, 1).AddMonths(-1);
                    dtpDesde.Value = primerDiaMesAnt;
                    dtpHasta.Value = primerDiaMesAnt.AddMonths(1).AddDays(-1);
                    break;
                case "Este año":
                    dtpDesde.Value = new DateTime(hoy.Year, 1, 1);
                    dtpHasta.Value = hoy;
                    break;
                case "Personalizado":
                    // El usuario elige en los DatePickers
                    break;
            }

            if (cboRango.SelectedItem.ToString() != "Personalizado")
                CargarTodosLosGraficos();
        }

        // ============================================================
        // Lógica de carga de gráficos
        // ============================================================
        private void CargarTodosLosGraficos()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.",
                    "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si los gráficos aún no tienen tamaño, reintentamos en 100ms
            if (chartVendedores.Width == 0 || chartCategorias.Width == 0 || chartProductos.Width == 0)
            {
                var timer = new System.Windows.Forms.Timer { Interval = 100 };
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    CargarTodosLosGraficos();
                };
                timer.Start();
                return;
            }

            CargarGraficoVendedores(desde, hasta);
            CargarGraficoCategorias(desde, hasta);
            CargarGraficoProductos(desde, hasta);
        }

        // ============================================================
        // Gráfico 1: Vendedores
        // ============================================================
        private void CargarGraficoVendedores(DateTime desde, DateTime hasta)
        {
            try
            {
                VentaDatos datos = new VentaDatos();
                var lista = datos.ObtenerVentasPorVendedor(desde, hasta);

                chartVendedores.Series.Clear();
                chartVendedores.Titles.Clear();
                chartVendedores.Legends.Clear();
                chartVendedores.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartVendedores.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                var titulo = chartVendedores.Titles.Add($"Ventas por Vendedor\n{desde:dd/MM/yyyy} - {hasta:dd/MM/yyyy}");
                titulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                titulo.ForeColor = Color.White;

                if (lista.Count == 0)
                {
                    MostrarSinDatos(chartVendedores);
                    return;
                }

                chartVendedores.Palette = ChartColorPalette.BrightPastel;

                Series serie = new Series("Ventas")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    Label = "#PERCENT{P0}",
                    LegendText = "#AXISLABEL (#VAL{C0})",
                    ToolTip = "#AXISLABEL\nVentas: $#VAL{N2}\nPorcentaje: #PERCENT{P1}"
                };

                serie["PieLabelStyle"] = "Outside";
                serie["PieLineColor"] = "Black";
                serie["PieStartAngle"] = "270";

                // Evitamos error de cálculo de posición si el gráfico es muy chico
                if (chartVendedores.Width > 100 && chartVendedores.Height > 100)
                {
                    chartVendedores.ChartAreas[0].InnerPlotPosition = new ElementPosition(10, 10, 60, 80);
                }

                foreach (var item in lista)
                    serie.Points.AddXY(item.NombreVendedor, item.TotalVendido);

                chartVendedores.Series.Add(serie);

                var legend = new Legend("Legend1")
                {
                    Docking = Docking.Right,
                    Alignment = StringAlignment.Center,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    BackColor = Color.Transparent
                };
                chartVendedores.Legends.Add(legend);
                serie.Legend = "Legend1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vendedores: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // Gráfico 2: Categorías
        // ============================================================
        private void CargarGraficoCategorias(DateTime desde, DateTime hasta)
        {
            try
            {
                VentaDatos datos = new VentaDatos();
                var lista = datos.ObtenerVentasPorCategoria(desde, hasta);

                chartCategorias.Series.Clear();
                chartCategorias.Titles.Clear();
                chartCategorias.Legends.Clear();
                chartCategorias.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartCategorias.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                var titulo = chartCategorias.Titles.Add($"Ventas por Categoría\n{desde:dd/MM/yyyy} - {hasta:dd/MM/yyyy}");
                titulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                titulo.ForeColor = Color.White;

                if (lista.Count == 0)
                {
                    MostrarSinDatos(chartCategorias);
                    return;
                }

                chartCategorias.Palette = ChartColorPalette.Excel;

                Series serie = new Series("Ventas")
                {
                    ChartType = SeriesChartType.Doughnut,
                    IsValueShownAsLabel = true,
                    Label = "#PERCENT{P0}",
                    LegendText = "#AXISLABEL",
                    ToolTip = "#AXISLABEL\nTotal: $#VAL{N2}\nPorcentaje: #PERCENT{P1}"
                };

                serie["DoughnutRadius"] = "55";
                serie["PieLabelStyle"] = "Outside";
                serie["PieLineColor"] = "Black";

                foreach (var item in lista)
                    serie.Points.AddXY(item.Categoria, item.TotalVendido);

                chartCategorias.Series.Add(serie);

                var legend = new Legend("Legend1")
                {
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center,
                    Font = new Font("Segoe UI", 8),
                    LegendStyle = LegendStyle.Column,
                    BackColor = Color.Transparent
                };
                chartCategorias.Legends.Add(legend);
                serie.Legend = "Legend1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // Gráfico 3: Productos más vendidos
        // ============================================================
        private void CargarGraficoProductos(DateTime desde, DateTime hasta)
        {
            try
            {
                VentaDatos datos = new VentaDatos();
                var lista = datos.ObtenerProductosMasVendidosPorCategoria(desde, hasta);

                chartProductos.Series.Clear();
                chartProductos.Titles.Clear();
                chartProductos.Legends.Clear();
                chartProductos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartProductos.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                var titulo = chartProductos.Titles.Add($"Libro más vendido por categoría\n{desde:dd/MM/yyyy} - {hasta:dd/MM/yyyy}");
                titulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                titulo.ForeColor = Color.White;

                if (lista.Count == 0)
                {
                    MostrarSinDatos(chartProductos);
                    return;
                }

                chartProductos.Palette = ChartColorPalette.SeaGreen;

                Series serie = new Series("Cantidad")
                {
                    ChartType = SeriesChartType.Bar,
                    IsValueShownAsLabel = true,
                    Label = "#VAL{N0}",
                    ToolTip = "#AXISLABEL\nCantidad: #VAL{N0}"
                };

                foreach (var item in lista)
                {
                    string etiqueta = $"{item.Categoria}\n{item.NombreLibro}";
                    int punto = serie.Points.AddXY(etiqueta, item.CantidadVendida);

                    serie.Points[punto].Color = Color.FromArgb(60, 179, 113); // SeaGreen
                }

                // Destacamos el primero
                if (serie.Points.Count > 0)
                {
                    serie.Points[0].Color = Color.FromArgb(255, 140, 0); // Naranja oscuro
                    serie.Points[0].Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }

                chartProductos.Series.Add(serie);

                chartProductos.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8);
                chartProductos.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
                chartProductos.ChartAreas[0].AxisY.Title = "Unidades vendidas";
                chartProductos.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 8, FontStyle.Italic);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // Utilidad: Mensaje cuando no hay datos
        // ============================================================
        private void MostrarSinDatos(Chart chart)
        {
            chart.Series.Clear();
            chart.Legends.Clear();

            if (chart.ChartAreas.Count > 0)
            {
                chart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                chart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
            }

            Series serie = new Series("SinDatos")
            {
                ChartType = SeriesChartType.Point,
                IsVisibleInLegend = false
            };

            int index = serie.Points.AddXY(0, 0);
            serie.Points[index].Label = "Sin ventas en este período";
            serie.Points[index].LabelForeColor = Color.Gray;
            serie.Points[index].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            serie.Points[index].MarkerStyle = MarkerStyle.None;

            chart.Series.Add(serie);
        }

        private void chartCategorias_Click(object sender, EventArgs e)
        {
            // Evento vacío dejado por el diseñador
        }
    }
}