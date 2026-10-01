using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gestion_Libreria.Presentacion.repositor
{
    public partial class AddProd : Form
    {
        private string cadenaConexion = @"Server=localhost; Database=Punto_Barra_tdp; Integrated Security=True; TrustServerCertificate=True;";
        public AddProd()
        {
            InitializeComponent();
        }

        private void Lnombre_prod_Click(object sender, EventArgs e)
        {

        }

        private void TBnombre_prod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void TBeditorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProd_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void GuardarProducto()
        {
            string query = "INSERT INTO libros (ISBN, nombre, stock, precio) VALUES (@ISBN, @nombre, @stock, @precio)";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@ISBN", textBox1.Text.Trim());
                    comando.Parameters.AddWithValue("@nombre", TBnombre_prod.Text.Trim());
                    comando.Parameters.AddWithValue("@stock", Convert.ToInt32(numericUpDown1.Value));
                    comando.Parameters.AddWithValue("@precio", numericUpDown2.Value);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla presionada
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBnombre_prod.Text) ||
        string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos de texto.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDown1.Value <= 0 || numericUpDown2.Value <= 0)
            {
                MessageBox.Show("El precio y la cantidad deben ser mayores a 0.",
                                "Campos inválidos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            GuardarProducto();
            MessageBox.Show("Producto guardado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

    }
}
