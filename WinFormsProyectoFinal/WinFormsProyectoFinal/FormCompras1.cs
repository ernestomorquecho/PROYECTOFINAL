using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
        private string usuario;
        private ConexionBD conexionBD;
        public FormCompras1(string user)
        {
            InitializeComponent();
            conexionBD = new ConexionBD();
            usuario = user;
            lblUser.Text = usuario;
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

                    while (reader.Read()) // Asegurarse de no superar los 10 productos
                    {
                        // Asignar valores a los controles de cada grupo
                        Label labelNombre = (Label)this.Controls["labelNomProd" + (i + 1)];
                        Label labelPrecio = (Label)this.Controls["lblPrecio" + (i + 1)];
                        RichTextBox richTextBoxDescripcion = (RichTextBox)this.Controls["rTB" + (i + 1)];
                        PictureBox pictureBox = (PictureBox)this.Controls["pictureBoxProd" + (i + 1)];
                        ComboBox comboBox = (ComboBox)this.Controls["comboBox" + (i + 1)];

                        // Llenar los valores
                        labelNombre.Text = reader["Nombre"].ToString();
                        labelPrecio.Text = Convert.ToInt32(reader["precio"]).ToString();
                        richTextBoxDescripcion.Text = reader["Descripcion"].ToString();

                        // Cargar la imagen
                        //pictureBox.Image = reader["imagen"].ToString();

                        // Configurar el ComboBox con las existencias disponibles
                        comboBox.Items.Clear();
                        int existencias = Convert.ToInt32(reader["existencias"]);
                        for (int j = 0; j <= existencias; j++)
                        {
                            comboBox.Items.Add(j);
                        }
                        comboBox.SelectedIndex = 0; // Por defecto, selecciona la primera cantidad

                        i++; // Incrementar el contador
                    }
                    i++;
                    while (i <= 9)
                    {
                        // Asignar valores a los controles de cada grupo
                        Label labelNombre = (Label)this.Controls["labelNomProd" + (i)];
                        Label labelPrecio = (Label)this.Controls["lblPrecio" + (i)];
                        Label labelAgregar = (Label)this.Controls["label" + (i)];
                        RichTextBox richTextBoxDescripcion = (RichTextBox)this.Controls["rTB" + (i)];
                        PictureBox pictureBox = (PictureBox)this.Controls["pictureBoxProd" + (i)];
                        ComboBox comboBox = (ComboBox)this.Controls["comboBox" + (i)];

                        // Ocultamos los elementos que no reciben datos de la base de datos
                        labelNombre.Hide();
                        labelPrecio.Hide();
                        labelAgregar.Hide();
                        richTextBoxDescripcion.Hide();
                        pictureBox.Visible = false;
                        comboBox.Visible = false;

                        i++;

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

        private void btnComprar_Click(object sender, EventArgs e)
        {
            List<ProductosCompra> Compra = new List<ProductosCompra>();

            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8 };

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                if (comboBoxes[i].SelectedIndex > 0)
                {
                    Label labelNombre = (Label)this.Controls["labelNomProd" + (i + 1).ToString()];
                    Label labelPrecio = (Label)this.Controls["lblPrecio" + (i + 1).ToString()];
                    string producto = labelNombre.Text;
                    Compra.Add(new ProductosCompra
                    {
                        IdCompra = i+1,
                        Producto = producto,
                        Usuario = usuario,
                        Cantidad = Convert.ToInt32(comboBoxes[i].SelectedItem),
                        Precio = Convert.ToInt32(labelPrecio.Text)
                    });
                }
            }


            // Obtener la conexión desde la clase ConexionBD
            MySqlConnection conexion = conexionBD.ObtenerConexion();

            // Consulta para obtener los productos
            string consulta;

            MessageBox.Show($"Productos en la lista: {Compra.Count}", "Compra");
            int contador = 1;
            foreach (var compras in Compra)
            {   
                //Query de Venta
                consulta = "INSERT INTO ventas (Producto, Usuario_Compra, CantidadCompra, PrecioUnitario) VALUES (@Producto, @Usuario_Compra, @CantidadCompra, @PrecioUnitario)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Producto", compras.Producto);
                comando.Parameters.AddWithValue("@Usuario_Compra", compras.Usuario);
                comando.Parameters.AddWithValue("@CantidadCompra", compras.Cantidad);
                comando.Parameters.AddWithValue("@PrecioUnitario", compras.Precio);
                int res = comando.ExecuteNonQuery();

                //Query para eliminar los articulos que se compraron de la tabla productos
                string query = "UPDATE productos SET existencias = existencias - @cantidadVendida WHERE id = @idProducto;";
                MySqlCommand actualiza = new MySqlCommand(query, conexion);
                int idProducto = compras.IdCompra;
                actualiza.Parameters.AddWithValue("@cantidadVendida", compras.Cantidad);
                actualiza.Parameters.AddWithValue("@idProducto", compras.IdCompra);
                int resp = actualiza.ExecuteNonQuery();

                //Query para actualizar montos en tabla de usuarios
                string query2 = "UPDATE cuentas SET Monto = Monto + @cantidadVendida WHERE Nombre = @Usuario_Compra;";
                MySqlCommand actualiza2 = new MySqlCommand(query2, conexion);
                int cantidadVendida = compras.Cantidad * compras.Precio;
                actualiza2.Parameters.AddWithValue("@cantidadVendida", cantidadVendida);
                actualiza2.Parameters.AddWithValue("@Usuario_Compra", compras.Usuario);
                int resp2 = actualiza2.ExecuteNonQuery();

                //Si los tres querys fueron ejecutados, damos un mensaje de confirmación
                if (res > 0 && resp>0 && resp2>0)
                {
                    MessageBox.Show("Venta de primer producto exitosa!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
                contador++;
            }
            GeneradorDeTickets.GenerarPDF(Compra, usuario);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EntradaSistema login = new EntradaSistema();
            login.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FormCompras1 reset = new FormCompras1(usuario);
            reset.Show();
            this.Hide();
        }
    }
}