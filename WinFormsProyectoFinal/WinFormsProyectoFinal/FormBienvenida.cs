using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppIdeaProy;

namespace WinFormsProyectoFinal
{
    public partial class FormBienvenida : Form
    {
        private string usuario;
        public FormBienvenida(string user)
        {
            InitializeComponent();
            usuario = user;
            lblBienvenida.Text = "¡Bienvenido, usuario " + user + "!";
            if (usuario == "guest")
            {
                lblPermisos.Text = "Comprar los productos que la tienda tenga a disposición, o bien, en existencia";
            }
            if (usuario == "admin")
            {
                lblPermisos.Text = "Hacer altas, bajas y cambios de productos.\n Ademas de esto podras consultar la grafica.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntradaSistema login = new EntradaSistema();
            login.Show();
            this.Hide();
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //No sé que error tiene esté evento, no hace nada al presionar el botón
            //Quise revisar su código y me genero otro evento
            //Ese código es el que está aqui abajo
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("El botón ha sido presionado." + usuario);
            if (usuario == "admin")
            {
                FormAdmin1 siguiente = new FormAdmin1();
                siguiente.Show();
                this.Hide();
            }
            else
            {
                FormCompras1 siguiente = new FormCompras1(usuario);
                siguiente.Show();
                this.Hide();
            }
        }
    }
}
