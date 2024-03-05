namespace VISTA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnSedeMenu_Click(object sender, EventArgs e)
        {
            Form sede = new frmSedeDGV();
            sede.Show();
        }

        private void btnLaboratorioMenu_Click(object sender, EventArgs e)
        {
            Form laboratorio = new frmLaboratorioDGV();
            laboratorio.Show();
        }

        private void btnComputadoraMenu_Click(object sender, EventArgs e)
        {
            Form computadora = new frmComputadoraAM();
            computadora.Show();
        }

        private void btnTicketMenu_Click(object sender, EventArgs e)
        {
            Form ticket = new frmCrearTicketAM();
            ticket.Show();
        }

        private void btnHistorialMenu_Click(object sender, EventArgs e)
        {
            Form historial = new frmHistorialDGV();
            historial.Show();
        }
    }
}
