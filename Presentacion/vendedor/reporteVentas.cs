using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gestion_Libreria.Datos;
using Gestion_Libreria.Entidad;

namespace Gestion_Libreria.Presentacion.vendedor
{
    public partial class reporteVentas : Form
    {

        private List<Venta> listaVentas;
        private int idUsuarioLogueado;

        // ============================================================
        // CONSTRUCTORES
        // ============================================================
        public reporteVentas()
        {
            InitializeComponent();

            // Suscribimos el evento para mostrar el detalle al hacer clic
            this.dgvVentas.CellClick += dgvVentas_CellClick;

            // ✅ AGREGAR ESTA LÍNEA: conectar el evento Load
            this.Load += reporteVentas_Load;
        }

        public reporteVentas(int idUsuario) : this()
        {
            idUsuarioLogueado = idUsuario;
        }

        private void reporteVentas_Load(object sender, EventArgs e)
        {
            ConfigurarGrillaVentas();
            ConfigurarGrillaDetalle();
            CargarVentas();
        }

        // ============================================================
        // CONFIGURAMOS LAS COLUMNAS DE dgvVentas (ya existe en el diseñador)
        // ============================================================
        private void ConfigurarGrillaVentas()
        {
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ReadOnly = true;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.MultiSelect = false;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVentas.Columns.Clear();

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdVenta",
                HeaderText = "ID",
                DataPropertyName = "id_venta",
                FillWeight = 15
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFecha",
                HeaderText = "Fecha",
                DataPropertyName = "fecha_venta",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                FillWeight = 30
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotal",
                HeaderText = "Total",
                DataPropertyName = "total_venta",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 25
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMetodo",
                HeaderText = "Método",
                DataPropertyName = "nombre_metodo",
                FillWeight = 30
            });
        }

        // ============================================================
        // CONFIGURAMOS LAS COLUMNAS DE dgvDetalle (ya existe en el diseñador)
        // ============================================================
        private void ConfigurarGrillaDetalle()
        {
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.ReadOnly = true;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.MultiSelect = false;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalle.Columns.Clear();

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBN",
                FillWeight = 30
            });

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombreLibro",
                HeaderText = "Libro",
                DataPropertyName = "nombre_libro",
                FillWeight = 35
            });

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCantidad",
                HeaderText = "Cant.",
                DataPropertyName = "cantidad",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                FillWeight = 10
            });

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecioUnitario",
                HeaderText = "Precio Unit.",
                DataPropertyName = "precio_unitario",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 15
            });

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "subtotal",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                },
                FillWeight = 15
            });
        }

        // ============================================================
        // CARGAR LAS VENTAS DEL VENDEDOR LOGUEADO
        // ============================================================
        private void CargarVentas()
        {
            try
            {
                VentaDatos datos = new VentaDatos();

                if (idUsuarioLogueado > 0)
                    listaVentas = datos.ObtenerPorUsuario(idUsuarioLogueado);
                else
                    listaVentas = datos.ObtenerTodas();

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = listaVentas;

                dgvDetalle.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // AL HACER CLIC EN UNA VENTA, MOSTRAR EL DETALLE
        // ============================================================
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                Venta ventaSeleccionada = (Venta)dgvVentas.Rows[e.RowIndex].DataBoundItem;
                if (ventaSeleccionada == null) return;

                VentaDatos datos = new VentaDatos();
                List<VentaDetalle> detalles = datos.ObtenerDetalles(ventaSeleccionada.id_venta);

                dgvDetalle.DataSource = null;
                dgvDetalle.DataSource = detalles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BOTÓN FILTRAR POR FECHA
        // ⚠️ Asegurate de conectar tu botón "Buscar" a este método
        // ============================================================
        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde = dtpDesde.Value;
                DateTime hasta = dtpHasta.Value;

                if (desde.Date > hasta.Date)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                VentaDatos datos = new VentaDatos();

                if (idUsuarioLogueado > 0)
                    listaVentas = datos.ObtenerPorUsuarioYFecha(idUsuarioLogueado, desde, hasta);
                else
                    listaVentas = datos.ObtenerPorFecha(desde, hasta);

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = listaVentas;

                dgvDetalle.DataSource = null;

                if (listaVentas.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas en ese rango de fechas.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fecha: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}