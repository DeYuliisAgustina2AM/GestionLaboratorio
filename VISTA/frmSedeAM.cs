using Entidades;
using Controladora;
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
    public partial class frmSedeAM : Form
    {
        private Sede sede; // variable de tipo Sede para almacenar la sede que se va a modificar
        private bool modificar = false;

        public frmSedeAM()
        {
            InitializeComponent();
        }

        public frmSedeAM(Sede sedeModificar)
        {
            InitializeComponent();
            sede = sedeModificar;
            modificar = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void frmSedeAM_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregaroModificar.Text = "Modificar Sede";
                txtNombreSede.Text = sede.NombreSede;
                txtDireccionSede.Text = sede.DireccionSede;
            }
            else lblAgregaroModificar.Text = "Agregar Sede";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //hacelo como en el ejemplo de abajo  pero con la sede
            if (ValidarCampos())
            {
                if (modificar)
                {
                    var sede = new Sede()
                    {
                        NombreSede = txtNombreSede.Text,
                        DireccionSede = txtDireccionSede.Text,

                    };
                    var mensaje = ControladoraSede.Instancia.ModificarSede(sede);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sede = new Sede()
                    {
                        NombreSede = txtNombreSede.Text,
                        DireccionSede = txtDireccionSede.Text,
                    };
                    var mensaje = ControladoraSede.Instancia.AgregarSede(sede);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreSede.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para la sede", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccionSede.Text))
            {
                MessageBox.Show("Debe ingresar una direccion de la sede", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
