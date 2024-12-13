using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppIdeaProy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void personalizarDiseño()
        {
            panelUsuarios.Visible = false;
        }

        private void ocultarPanelUsuarios()
        {
            if (panelUsuarios.Visible == true)
                panelUsuarios.Visible = false;
        }

        private void mostrarPanelUsuarios(Panel usuarios)
        {
            if (usuarios.Visible == false)
            {
                ocultarPanelUsuarios();
                usuarios.Visible = true;
            }
            else
            {
                usuarios.Visible = false;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            mostrarPanelUsuarios(panelUsuarios);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
