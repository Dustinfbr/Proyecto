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
    public partial class ModificarHC : Form
    {
        public ModificarHC()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HistoriaClinica historiaClinica = new HistoriaClinica();
            RtxtAlergias.Text = historiaClinica.MostrarA(txtCedula.Text);
            RtxtEnfermedades.Text = historiaClinica.MostrarE(txtCedula.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HistoriaClinica historiaClinica = new HistoriaClinica(RtxtAlergias.Text, RtxtEnfermedades.Text);
            historiaClinica.modificarHC(txtCedula.Text);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Show();
            this.Close();
        }
    }
}
