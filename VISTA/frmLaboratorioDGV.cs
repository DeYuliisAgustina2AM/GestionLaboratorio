using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmLaboratorioDGV : Form
    {
        public frmLaboratorioDGV()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmLaboratorioAM frmLaboratorioAM = new frmLaboratorioAM();
            frmLaboratorioAM.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorio.Rows.Count > 0)
            {
                var laboratorio = (Laboratorio)dgvLaboratorio.CurrentRow.DataBoundItem; 
                frmLaboratorioAM frmLaboratoriosAM = new frmLaboratorioAM(laboratorio); //Le paso el avion seleccionado 
                frmLaboratoriosAM.ShowDialog();
                ActualizarGrilla();
            }

        }


        private void ActualizarGrilla()
        {
            dgvLaboratorio.DataSource = null;
            dgvLaboratorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaboratorio.DataSource = ControladoraLaboratorio.Instancia.RecuperarLaboratorios();
        }
    }
}
