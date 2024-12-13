using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsProyectoFinal;

namespace WinFormsAppIdeaProy
{
    public partial class FormModificaProducto : Form
    {

        ProductoInfo producto;

        private string productoSeleccionado;
        public FormModificaProducto(ProductoInfo producto)
        {
            InitializeComponent();

            labelOption.Text = productoSeleccionado; // Si tienes un Label para mostrarlo
            this.producto = producto;

            textBoxNomProd.Text = producto.Nombre;
            textBoxDescrp.Text = producto.Descripcion;
            textBoxPrecioUn.Text = producto.Precio.ToString();
            textBoxStock.Text = producto.Stock.ToString();
            comboBoxCategoriaModf.Text = producto.Categoria;
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategoriaModf.Items.Add("Escritura");
            comboBoxCategoriaModf.Items.Add("Oficina");
            comboBoxCategoriaModf.Items.Add("Papeleria escolar");
            comboBoxCategoriaModf.Items.Add("Tecnologia");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void buttonModf_Click(object sender, EventArgs e)
        {
            producto.Nombre = textBoxNomProd.Text;
            producto.Descripcion = textBoxDescrp.Text;
            producto.Precio = decimal.Parse(textBoxPrecioUn.Text);
            producto.Stock = int.Parse(textBoxStock.Text);
            producto.Categoria = comboBoxCategoriaModf.Text;

            this.DialogResult = DialogResult.OK; // Marca que se realizó una acción
            this.Close();
        }

        private void textBoxNomProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin1 regreso = new FormAdmin1();
            regreso.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntradaSistema login = new EntradaSistema();
            login.Show();
            this.Hide();
        }
    }
}
