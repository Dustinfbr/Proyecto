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
    public partial class CrearHC : Form
    {
        public CrearHC()
        {
            InitializeComponent();
        }

        private void BtnReceta_Click(object sender, EventArgs e)
        {
            CrearRecetaMedica crearRecetaMedica = new CrearRecetaMedica();
            crearRecetaMedica.Show();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HistoriaClinica Hc = new HistoriaClinica(RtxtAlergias.Text, RtxtEnfermedades.Text);
            Hc.agregarHC(txtCedula.Text);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Show();
            this.Close();
        }
    }
}
