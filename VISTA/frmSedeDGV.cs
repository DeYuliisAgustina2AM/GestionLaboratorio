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
    public partial class frmSedeDGV : Form
    {
        public frmSedeDGV()
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
            Form sedeAbm = new frmSedeAM();
            sedeAbm.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvSede.Rows.Count > 0) //Verifico que haya al menos una fila seleccionada
            {
                var sede = (Sede)dgvSede.CurrentRow.DataBoundItem;
                frmSedeAM frmSedeAM = new frmSedeAM(sede);
                frmSedeAM.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //hacelo como en el de abajo
            if (dgvSede.Rows.Count > 0)
            {
                var sede = (Sede)dgvSede.CurrentRow.DataBoundItem;
                var mensaje = ControladoraSede.Instancia.EliminarSede(sede);
                MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
        }


        private void frmSedeDGV_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        //actualizo la grilla
        private void ActualizarGrilla()
        {
            dgvSede.DataSource = null;
            dgvSede.DataSource = ControladoraSede.Instancia.RecuperarSedes();
            dgvSede.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnBuscarSede_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarSede.Text))
            {
                MessageBox.Show("No ha ingresado ningún valor de búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvSede.DataSource = ControladoraSede.Instancia.RecuperarSedes().Where(x => x.SedeId.ToString().Contains(txtBuscarSede.Text) || x.NombreSede.Contains(txtBuscarSede.Text)).ToList();
            }
        }
    }
}
