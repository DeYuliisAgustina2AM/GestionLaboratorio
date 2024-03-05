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
using System.Windows.Forms.VisualStyles;

namespace VISTA
{

    public partial class frmLaboratorioAM : Form
    {
        private Laboratorio laboratorio; //Variable para guardar el avion a modificar
        private bool modificar = false;//Variable para saber si se va a modificar o agregar un avion

        public frmLaboratorioAM()
        {
            InitializeComponent();
        }

        public frmLaboratorioAM(Laboratorio laboratorioModificar)
        {
            InitializeComponent();
            LlenarCMB();
            laboratorio = laboratorioModificar;
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

        //metodo para llenar los combobox
        private void LlenarCMB()
        {
            cmbListadoSedes.DataSource = ControladoraSede.Instancia.RecuperarSedes();
            cmbListadoComputadoras.DataSource = ControladoraComputadora.Instancia.RecuperarComputadoras();
        }

        private void frmLaboratorioAM_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregaroModificar.Text = "Modificar Laboratorio";
                txtNombreLaboratorio.Text = laboratorio.NombreLaboratorio;
                numCapacidadMaxima.Value = laboratorio.CapacidadMaxima;
                cmbListadoSedes.SelectedItem = laboratorio.Sede;
                cmbListadoComputadoras.SelectedItem = laboratorio.Computadoras;
            }
            else
            {
                lblAgregaroModificar.Text = "Agregar Laboratorio";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {
                    var laboratorio = new Laboratorio()
                    {
                        NombreLaboratorio = txtNombreLaboratorio.Text,
                        Sede = (Sede)cmbListadoSedes.SelectedItem,
                        //Computadoras = (Computadora)cmbListadoSedes.SelectedItem,

                    };
                    var mensaje = ControladoraLaboratorio.Instancia.ModificarLaboratorio(laboratorio);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var laboratorio = new Laboratorio()
                    {
                        NombreLaboratorio = txtNombreLaboratorio.Text,
                        Sede = (Sede)cmbListadoSedes.SelectedItem,
                        //Computadoras = (Computadora)cmbListadoSedes.SelectedItem,
                    };
                    var mensaje = ControladoraLaboratorio.Instancia.AgregarLaboratorio(laboratorio);

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }


        private bool ValidarCampos()
        {
            if (numCapacidadMaxima.Value == 0)
            {
                MessageBox.Show("Debe ingresar un número de capacidad máxima.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtNombreLaboratorio.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre para el laboratorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbListadoSedes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una sede", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbListadoComputadoras.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una computadora", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
