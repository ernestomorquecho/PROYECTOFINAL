namespace WinFormsProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            mostrarPanelUsuarios(panelUsuarios);
        }
    }
}
