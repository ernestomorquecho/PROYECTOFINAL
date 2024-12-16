using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using WinFormsProyectoFinal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace WinFormsAppIdeaProy
{
    public partial class FormAdmin1 : Form
    {
        private Dictionary<int, Label> labelMapping = new Dictionary<int, Label>();

        public FormAdmin1()
        {
            InitializeComponent();
            InicializarLabels();
            CargarProductos(); // Cargar productos desde la base de datos al iniciar el formulario
        }

        // Inicializa los Labels con texto predeterminado
        private void InicializarLabels()
        {
            labelMapping.Add(1, labelNomProd1);
            labelMapping.Add(2, labelNomProd2);
            labelMapping.Add(3, labelNomProd3);
            labelMapping.Add(4, labelNomProd4);
            labelMapping.Add(5, labelNomProd5);
            labelMapping.Add(6, labelNomProd6);
            labelMapping.Add(7, labelNomProd7);
            labelMapping.Add(8, labelNomProd8);

            foreach (var kvp in labelMapping)
            {
                kvp.Value.Text = $"Producto indefinido {kvp.Key}";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización adicional si es necesario
        }


        // Evento para modificar un producto existente
        private void buttonModificar_Click(object sender, EventArgs e)
        {
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }


        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.FlatAppearance.BorderColor = Color.Gray;
            button10.BackColor = Color.DarkSlateGray;
            button10.ForeColor = Color.White;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.FlatAppearance.BorderColor = Color.White;
            button10.BackColor = Color.Gray;
            button10.ForeColor = Color.White;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                // Consulta para obtener montos de ventas por usuario
                string consulta = "SELECT Nombre, Monto FROM cuentas WHERE rol != 'admin'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion.GetConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                // Diccionario para almacenar datos de ventas
                Dictionary<string, decimal> datosVentas = new Dictionary<string, decimal>();

                while (reader.Read())
                {
                    string nombre = reader["Nombre"].ToString();
                    decimal monto = Convert.ToDecimal(reader["Monto"]);
                    datosVentas[nombre] = monto;
                }

                reader.Close();

                if (datosVentas.Count > 0)
                {
                    // Genera la gráfica con los datos obtenidos
                    GenerarGraficaConOxyPlot(datosVentas);
                }
                else
                {
                    MessageBox.Show("No se encontraron ventas registradas.", "Ventas Totales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la gráfica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Disconnect();
            }
        }

        private void GenerarGraficaConOxyPlot(Dictionary<string, decimal> datosVentas)
        {
            // Crear el modelo de gráfica
            PlotModel plotModel = new PlotModel { Title = "Distribución de Ventas" };

            // Crear la serie de pastel
            var pieSeries = new PieSeries
            {
                InsideLabelFormat = "{1:C}", // Formato para etiquetas internas (monto)
                OutsideLabelFormat = "{0}", // Formato para etiquetas externas (nombre del usuario)
                StrokeThickness = 2.0, // Grosor de los bordes
                AngleSpan = 360, // Cobertura total del pastel
                StartAngle = 0 // Ángulo inicial
            };

            // Agregar datos a la serie
            foreach (var dato in datosVentas)
            {
                pieSeries.Slices.Add(new PieSlice(dato.Key, (double)dato.Value)
                {
                    IsExploded = false // No separa las porciones (opcional)
                });
            }

            // Agregar la serie al modelo de gráfica
            plotModel.Series.Add(pieSeries);

            // Crear el control PlotView
            PlotView plotView = new PlotView
            {
                Model = plotModel,
                Dock = DockStyle.Fill
            };

            // Crear un formulario nuevo para mostrar la gráfica
            Form formGrafica = new Form
            {
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.Gray,
                Text = "Gráfica de Ventas",
                ForeColor = Color.White,
                Width = 800, // Ancho del formulario
                Height = 600 // Alto del formulario
            };

            // Botón para regresar al formulario principal
            System.Windows.Forms.Button buttonRegresar = new System.Windows.Forms.Button
            {
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Font = new Font("Tahoma", 12),
                Text = "Regresar",
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right, // Posición en la esquina inferior derecha
                Width = 110,
                Height = 41,
                Top = formGrafica.ClientSize.Height - 50, // Ajustar posición vertical
                Left = formGrafica.ClientSize.Width - 120 // Ajustar posición horizontal
            };

            buttonRegresar.FlatAppearance.BorderColor = Color.White;

            // Evento del botón "Regresar"
            buttonRegresar.Click += (sender, args) =>
            {
                formGrafica.Close(); // Cierra el formulario de la gráfica
            };

            buttonRegresar.MouseEnter += (sender, args) =>
            {
                buttonRegresar.FlatAppearance.BorderColor = Color.Gray;
                buttonRegresar.BackColor = Color.DarkSlateGray;
                buttonRegresar.ForeColor = Color.White;

            };

            buttonRegresar.MouseLeave += (sender, args) =>
            {
                buttonRegresar.FlatAppearance.BorderColor = Color.White;
                buttonRegresar.BackColor = Color.Gray;
                buttonRegresar.ForeColor = Color.White;
            };

            // Redimensionar controles dinámicamente con el formulario
            formGrafica.Controls.Add(buttonRegresar);
            formGrafica.Controls.Add(plotView);

            // Mostrar el formulario como modal
            formGrafica.ShowDialog();
        }

        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            btnVentas.FlatAppearance.BorderColor = Color.Gray;
            btnVentas.BackColor = Color.DarkSlateGray;
            btnVentas.ForeColor = Color.White;
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.FlatAppearance.BorderColor = Color.White;
            btnVentas.BackColor = Color.Gray;
            btnVentas.ForeColor = Color.White;
        }

        private void CargarProductos()
        {
            ConexionBD conexion = new ConexionBD();

            try
            {
                // Obtener los productos de la base de datos
                List<ProductosTienda> productos = conexion.ObtenerProductos();

                // Mostrar los productos en los controles
                for (int i = 0; i < productos.Count && i < 8; i++) // Máximo 8 productos
                {
                    ProductosTienda producto = productos[i];

                    // Asignar el nombre del producto a las etiquetas
                    if (labelMapping.ContainsKey(i + 1))
                    {
                        labelMapping[i + 1].Text = producto.Nombre;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosProducto(int idProducto)
        {
            ConexionBD conexion = new ConexionBD();
            List<ProductosTienda> productos = conexion.ObtenerProductos();

            // Buscar el producto por ID
            ProductosTienda producto = productos.Find(p => p.Id == idProducto);
            if (producto != null)
            {
                string datosProducto = $"ID: {producto.Id}\n" +
                                       $"Nombre: {producto.Nombre}\n" +
                                       $"Descripción: {producto.Descripcion}\n" +
                                       $"Precio: {producto.Precio:C}\n" +
                                       $"Existencias: {producto.Existencias}";

                MessageBox.Show(datosProducto, "Información del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se encontró el producto con ID {idProducto}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonModificar_MouseEnter(object sender, EventArgs e)
        {
            buttonModificar.FlatAppearance.BorderColor = Color.Gray;
            buttonModificar.BackColor = Color.DarkSlateGray;
            buttonModificar.ForeColor = Color.White;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarDatosProducto(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EntradaSistema entradaSistema = new EntradaSistema();
            entradaSistema.Show();
            this.Close();
        }

        private void buttonAnadir_MouseLeave(object sender, EventArgs e)
        {
            buttonAnadir.FlatAppearance.BorderColor = Color.White;
            buttonAnadir.BackColor = Color.Gray;
            buttonAnadir.ForeColor = Color.White;
        }

        private void buttonAnadir_MouseEnter(object sender, EventArgs e)
        {
            buttonAnadir.FlatAppearance.BorderColor = Color.Gray;
            buttonAnadir.BackColor = Color.DarkSlateGray;
            buttonAnadir.ForeColor = Color.White;
        }

        private void buttonModificar_MouseLeave(object sender, EventArgs e)
        {
            buttonModificar.FlatAppearance.BorderColor = Color.White;
            buttonModificar.BackColor = Color.Gray;
            buttonModificar.ForeColor = Color.White;
        }

        private void buttonEliminar_MouseEnter(object sender, EventArgs e)
        {
            buttonEliminar.FlatAppearance.BorderColor = Color.Gray;
            buttonEliminar.BackColor = Color.DarkSlateGray;
            buttonEliminar.ForeColor = Color.White;
        }

        private void buttonEliminar_MouseLeave(object sender, EventArgs e)
        {
            buttonEliminar.FlatAppearance.BorderColor = Color.White;
            buttonEliminar.BackColor = Color.Gray;
            buttonEliminar.ForeColor = Color.White;
        }
    }
}
