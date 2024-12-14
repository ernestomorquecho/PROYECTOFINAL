using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoFinal
{

    public partial class FormCompras1 : Form
    {
        private ConexionBD conexionBD;
        public FormCompras1()
        {
            InitializeComponent();
            conexionBD = new ConexionBD();
        }

        private void CargaProductos()
        {
            try
            {
                // Obtener la conexión desde la clase ConexionBD
                MySqlConnection conexion = conexionBD.ObtenerConexion();

                // Consulta para obtener los productos
                string consulta = "SELECT * FROM productos";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    int i = 0; // Contador para los grupos de controles

                    while (reader.Read() && i < 10) // Asegurarse de no superar los 10 productos
                    {
                        // Asignar valores a los controles de cada grupo
                        Label labelNombre = (Label)this.Controls["labelNomProd" + (i + 1)];
                        Label labelPrecio = (Label)this.Controls["lblPrecio" + (i + 1)];
                        //Label labelDescripcion = (Label)this.Controls["labelDescripcion" + (i + 1)];
                        PictureBox pictureBox = (PictureBox)this.Controls["pictureBox" + (i + 1)];
                        ComboBox comboBox = (ComboBox)this.Controls["comboBox" + (i + 1)];

                        // Llenar los valores
                        labelNombre.Text = reader["Nombre"].ToString();
                        labelPrecio.Text = "$" + Convert.ToDecimal(reader["precio"]).ToString("F2");
                        //labelDescripcion.Text = reader["Descripcion"].ToString();

                        // Cargar la imagen
                        //pictureBox.ImageLocation = reader["imagen"].ToString();

                        // Configurar el ComboBox con las existencias disponibles
                        comboBox.Items.Clear();
                        int existencias = Convert.ToInt32(reader["existencias"]);
                        for (int j = 1; j <= existencias; j++)
                        {
                            comboBox.Items.Add(j);
                        }
                        comboBox.SelectedIndex = 0; // Por defecto, selecciona la primera cantidad

                        i++; // Incrementar el contador
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCompras1_Load(object sender, EventArgs e)
        {
            CargaProductos();
        }
    }
}
