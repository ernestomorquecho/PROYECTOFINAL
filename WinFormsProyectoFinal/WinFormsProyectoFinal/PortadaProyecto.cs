namespace WinFormsProyectoFinal
{
    public partial class PortadaProyecto : Form
    {
        public PortadaProyecto()
        {

            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.FlatAppearance.BorderColor = Color.Gray;
            btnSalir.BackColor = Color.DarkSlateGray;
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.BackColor = Color.Gray;
            btnSalir.ForeColor = Color.White;
        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            btnIniciar.FlatAppearance.BorderColor = Color.Gray;
            btnIniciar.BackColor = Color.DarkSlateGray;
            btnIniciar.ForeColor = Color.White;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            btnIniciar.FlatAppearance.BorderColor = Color.White;
            btnIniciar.BackColor = Color.Gray;
            btnIniciar.ForeColor = Color.White;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            EntradaSistema entrada = new EntradaSistema();
            entrada.Show();
            this.Hide();
        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
