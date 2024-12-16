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
using MySql.Data.MySqlClient;

namespace WinFormsProyectoFinal
{
    public partial class EntradaSistema : Form
    {
        public EntradaSistema()
        {
            InitializeComponent();
        }

        /*
        private void MostrarFormularioUsuario(string usuario)
        {
            // Limpia controles previos si es necesario
            foreach (Control ctrl in this.Controls.OfType<Label>().Concat(this.Controls.OfType<TextBox>()))
            {
                this.Controls.Remove(ctrl);
            }

            // Crea un Label para mostrar el usuario seleccionado
            Label lblUsuario = new Label();
            lblUsuario.Text = $"Usuario seleccionado: {usuario}";
            lblUsuario.Location = new Point(200, 150); // Ajusta la posición según el diseño
            lblUsuario.AutoSize = true;
            this.Controls.Add(lblUsuario);

            // Crea un TextBox para ingresar la contraseña
            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(200, 180); // Ajusta la posición según el diseño
            txtPassword.Width = 200; // Ajusta el tamaño
            txtPassword.UseSystemPasswordChar = true; // Oculta el texto (modo contraseña)
            this.Controls.Add(txtPassword);

            // Opcional: Guarda una referencia al TextBox si necesitas validar la contraseña
            txtPassword.Name = "txtPassword"; // Nombre para búsqueda posterior
        }
        */

        private void btnCerrar_MouseEnter(object sender, EventArgs e) //Todos esos eventos hacen que el boton se pinte al poner el mouse sobre el
        {
            btnCerrar.FlatAppearance.BorderColor = Color.Gray;
            btnCerrar.BackColor = Color.DarkSlateGray;
            btnCerrar.ForeColor = Color.White;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.FlatAppearance.BorderColor = Color.White;
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.ForeColor = Color.White;
        }

        private void btnCerrar_Click(object sender, EventArgs e) //Cierra el programa
        {
            Application.Exit();
        }

        private void btnPortada_MouseEnter(object sender, EventArgs e)
        {
            btnPortada.FlatAppearance.BorderColor = Color.Gray;
            btnPortada.BackColor = Color.DarkSlateGray;
            btnPortada.ForeColor = Color.White;
        }

        private void btnPortada_MouseLeave(object sender, EventArgs e)
        {
            btnPortada.FlatAppearance.BorderColor = Color.White;
            btnPortada.BackColor = Color.Gray;
            btnPortada.ForeColor = Color.White;
        }

        private void btnPortada_Click(object sender, EventArgs e) //Regresa a la portada
        {
            PortadaProyecto portada = new PortadaProyecto();
            portada.Show();
            this.Close();
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.FlatAppearance.BorderColor = Color.Gray;
            btnIngresar.BackColor = Color.DarkSlateGray;
            btnIngresar.ForeColor = Color.White;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.FlatAppearance.BorderColor = Color.White;
            btnIngresar.BackColor = Color.Gray;
            btnIngresar.ForeColor = Color.White;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContra.Text.Trim();//Guarda lo que hay en la caja de texto sin espacios para evitr errores

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                //Si las cajas de texto estan vacias manda una alerta
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConexionBD db = new ConexionBD();
            string resultado = db.validarUsuario(usuario, contrasena);

            if (!string.IsNullOrEmpty(resultado))
            {
                string[] partes = resultado.Split(';');/*Separa la cadena de resultado separandolos en donde encuentre ";" 
                                                        para guardarla en diferentes partes y poder imprimirla despues*/
                string rol = partes[0];
                string nombre = partes[1];

                MessageBox.Show($"Bienvenido, {rol}. Usuario: {nombre}.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (rol.Equals("admin", StringComparison.OrdinalIgnoreCase))//Si el usuario es "admin" abre esa ventana
                {
                    FormBienvenida bienvenidaForm = new FormBienvenida("admin");
                    bienvenidaForm.Show();
                    this.Hide();
                }
                else if (rol.Equals("guest", StringComparison.OrdinalIgnoreCase))//Si es "guest" abre la ventana de usuario
                {
                    FormBienvenida bienvenidaForm = new FormBienvenida("guest");
                    bienvenidaForm.Show();
                    this.Hide();
                }
                else
                {
                    FormBienvenida bienvenidaForm = new FormBienvenida(nombre);//Si es cuenta de nosotros tambien abre la ventana usuario
                    bienvenidaForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
