using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace MediSoft
{
    public partial class AtenderPaciente : Form
    {
        public AtenderPaciente()
        {
            InitializeComponent();
        }
        int u = 1;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            if (String.IsNullOrEmpty(txtCedula.Text))
            {
                Console.WriteLine("Error");
                MessageBox.Show("Debe Ingresar un Cedula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (String.IsNullOrEmpty(paciente.ObtenerNombres(txtCedula.Text)))
                {
                    Console.WriteLine("Error");
                    MessageBox.Show("Paciente Inexistente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblPaciente.Text = (paciente.ObtenerNombres(txtCedula.Text));
                    lblCI.Text = txtCedula.Text;
                    lblFechaNac.Text = paciente.ObtenerFecha(txtCedula.Text);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (u == 1)
            {
                if (!String.IsNullOrEmpty(RtxtDiagnostico.Text))
                {
                    DialogResult resultado = MessageBox.Show("Lo cambios no se han Guardado. ¿Desea Guardarlos?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        Diagnostico Dg = new Diagnostico(RtxtDiagnostico.Text);
                        Dg.AgregarDiagnostico(txtCedula.Text);
                        MessageBox.Show("Informacion Guardada", "Mensaje", MessageBoxButtons.OK);
                        if (resultado == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Diagnostico Dg = new Diagnostico(RtxtDiagnostico.Text);
            Dg.AgregarDiagnostico(txtCedula.Text);
            u = 0;
            DialogResult resultado = MessageBox.Show("Informacion Guardada", "Mensaje", MessageBoxButtons.OK);
            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSignos_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignosVitales signos = new SignosVitales(txtCedula.Text);
            signos.ShowDialog();
            this.Show();
        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearRecetaMedica receta = new CrearRecetaMedica();
            receta.ShowDialog();
            this.Show();
        }
    }
}
