using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Drawing;
using WinFormsProyectoFinal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppIdeaProy
{
    public partial class FormAdmin1 : Form
    {
        private List<ProductoInfo> productos = new List<ProductoInfo>(); // Lista de productos
        private Dictionary<string, int> comboBoxMapping = new Dictionary<string, int>(); // Relación ComboBox - ID
        private Dictionary<int, Label> labelMapping = new Dictionary<int, Label>(); // Relación ID - Label

        public FormAdmin1()
        {
            InitializeComponent();
            InicializarProductosPorDefecto();
            InicializarLabels();
            InicializarComboBox();
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

        // Inicializa la lista de productos con valores predeterminados
        private void InicializarProductosPorDefecto()
        {
            for (int i = 1; i <= 8; i++)
            {
                productos.Add(new ProductoInfo(i, $"Producto {i}", "Sin descripcion", 0m, 0, "Sin categoría"));
            }
        }

        // Llena el ComboBox con los nombres de los productos y mapea sus IDs
        private void InicializarComboBox()
        {
            comboBoxMapping.Clear();
            comboBox1.Items.Clear();

            foreach (var producto in productos)
            {
                string productoNombre = producto.Nombre;
                comboBoxMapping.Add(productoNombre, producto.Id);
                comboBox1.Items.Add(productoNombre);
            }
        }

        // Actualiza el Label asociado a un producto
        private void ActualizarLabelProducto(int idProducto, string nuevoNombre)
        {
            if (labelMapping.TryGetValue(idProducto, out Label label))
            {
                label.Text = string.IsNullOrWhiteSpace(nuevoNombre)
                    ? $"Producto indefinido {idProducto}"
                    : nuevoNombre;
            }
        }

        // Evento para añadir o editar un producto
        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un Producto válido antes de añadir o modificar.");
                return;
            }

            string selectedName = comboBox1.SelectedItem.ToString();

            if (!comboBoxMapping.TryGetValue(selectedName, out int productID))
            {
                MessageBox.Show("El producto seleccionado no tiene un ID asignado.");
                return;
            }// creo esta advertencia no salta

            ProductoInfo productoSeleccionado = productos.FirstOrDefault(p => p.Id == productID);

            FormSubirPorducto form2 = new FormSubirPorducto(productoSeleccionado.Id);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ProductoInfo nuevoProducto = form2.ProductoCreado;
                productoSeleccionado.Nombre = nuevoProducto.Nombre;
                productoSeleccionado.Descripcion = nuevoProducto.Descripcion;
                productoSeleccionado.Precio = nuevoProducto.Precio;
                productoSeleccionado.Stock = nuevoProducto.Stock;
                productoSeleccionado.Categoria = nuevoProducto.Categoria;

                ActualizarLabelProducto(productID, productoSeleccionado.Nombre);

                MessageBox.Show($"Producto {productoSeleccionado.Nombre} actualizado correctamente.");
            }

            InicializarComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización adicional si es necesario
        }

        // Retorna el PictureBox asociado a un producto por su ID
        private PictureBox ObtenerPictureBox(int idProducto)
        {
            return idProducto switch
            {
                1 => pictureBoxProd1,
                2 => pictureBoxProd2,
                3 => pictureBoxProd3,
                4 => pictureBoxProd4,
                5 => pictureBoxProd5,
                6 => pictureBoxProd6,
                7 => pictureBoxProd7,
                8 => pictureBoxProd8,
                _ => null,
            };
        }

        // Evento para modificar un producto existente
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un producto válido a modificar.");
                return;
            }

            string selectedName = comboBox1.SelectedItem.ToString();

            if (!comboBoxMapping.TryGetValue(selectedName, out int productID))
            {
                MessageBox.Show("El producto seleccionado no tiene un ID asignado.");
                return;
            }

            ProductoInfo productoSeleccionado = productos.FirstOrDefault(p => p.Id == productID);

            if (productoSeleccionado == null || string.IsNullOrWhiteSpace(productoSeleccionado.Nombre))
            {
                MessageBox.Show("El producto no está registrado. Por favor, añádelo antes de modificar.");
                return;
            }

            FormModificaProducto formMod = new FormModificaProducto(productoSeleccionado);
            if (formMod.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Producto modificado con éxito.");
            }

            InicializarComboBox();
        }

        private void labelNomProd1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Verifica que se haya seleccionado un producto en el ComboBox
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un producto válido para eliminar o modificar.");
                return;
            }

            // Obtén el nombre del producto seleccionado
            string selectedName = comboBox1.SelectedItem.ToString();

            // Obtén el ID del producto a partir del mapeo
            if (!comboBoxMapping.TryGetValue(selectedName, out int productID))
            {
                MessageBox.Show("El producto seleccionado no tiene un ID asignado.");
                return;
            }

            // Encuentra el producto en la lista
            ProductoInfo productoSeleccionado = productos.FirstOrDefault(p => p.Id == productID);

            if (productoSeleccionado == null)
            {
                MessageBox.Show("El producto seleccionado no está registrado en el sistema.");
                return;
            }

            // Muestra los datos del producto
            string datosProducto = $"ID: {productoSeleccionado.Id}\n" +
                                   $"Nombre: {productoSeleccionado.Nombre}\n" +
                                    $"Descripcion: {productoSeleccionado.Descripcion}\n" +
                                   $"Precio: {productoSeleccionado.Precio:C}\n" +
                                   $"Stock: {productoSeleccionado.Stock}\n" +
                                   $"Categoría: {productoSeleccionado.Categoria}";

            DialogResult resultado = MessageBox.Show(
                $"Datos del producto:\n\n{datosProducto}\n\n¿Deseas modificar este producto antes de eliminarlo?",
                "Confirmación de Modificación",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Abrir el formulario para modificar el producto
                FormModificaProducto formMod = new FormModificaProducto(productoSeleccionado);
                if (formMod.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Producto modificado con éxito. No se eliminó el producto.");
                }
            }
            else if (resultado == DialogResult.No)
            {
                // Restablecer los valores predeterminados del producto
                productoSeleccionado.Nombre = $"Producto {productoSeleccionado.Id}";
                productoSeleccionado.Descripcion = $"Sin descripcion ";
                productoSeleccionado.Precio = 0m;
                productoSeleccionado.Stock = 0;
                productoSeleccionado.Categoria = "Sin categoría";

                MessageBox.Show($"Producto {productoSeleccionado.Id} eliminado y restablecido a valores predeterminados.");
            }
            else
            {
                // Cancelar la operación
                MessageBox.Show("Operación cancelada. El producto no fue modificado ni eliminado.");
            }

            // Actualiza el ComboBox para reflejar los cambios
            InicializarComboBox();
        }

        private void MostrarDatosProducto(int productID)
        {
            // Encuentra el producto correspondiente en la lista
            ProductoInfo productoSeleccionado = productos.FirstOrDefault(p => p.Id == productID);

            if (productoSeleccionado == null)
            {
                MessageBox.Show("El producto no se encuentra registrado.");
                return;
            }

            // Muestra los datos del producto
            string datosProducto = $"ID: {productoSeleccionado.Id}\n" +
                                   $"Nombre: {productoSeleccionado.Nombre}\n" +
                                   $"Descripcion: {productoSeleccionado.Descripcion}\n" +
                                   $"Precio: {productoSeleccionado.Precio:C}\n" +
                                   $"Stock: {productoSeleccionado.Stock}\n" +
                                   $"Categoría: {productoSeleccionado.Categoria}";

            MessageBox.Show(datosProducto, "Información del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int productID = 1; // ID del producto que este botón siempre mostrará
            MostrarDatosProducto(productID); // Llama a la función reutilizable
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int productID = 2; // ID del producto que este botón siempre mostrará
            MostrarDatosProducto(productID); // Llama a la función reutilizable
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int productID = 3; // ID del producto que este botón siempre mostrará
            MostrarDatosProducto(productID); // Llama a la función reutilizable
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int productID = 4; // ID del producto que este botón siempre mostrará
            MostrarDatosProducto(productID); // Llama a la función reutilizable
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int productID = 5; // ID del producto que este botón siempre mostrará
            MostrarDatosProducto(productID); // Llama a la función reutilizable
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int productID = 6; // ID del producto que este botón siempre mostrará
            MostrarDatosProducto(productID); // Llama a la función reutilizable
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int productID = 7; // ID del producto que este botón siempre mostrará
            MostrarDatosProducto(productID); // Llama a la función reutilizable
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int productID = 8; // ID del producto que este botón siempre mostrará
            MostrarDatosProducto(productID); // Llama a la función reutilizable
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            EntradaSistema login = new EntradaSistema();
            login.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*FormModificaProducto Modifica = new FormModificaProducto();
            Modifica.Show();
            this.Hide();*/
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
    }
}
