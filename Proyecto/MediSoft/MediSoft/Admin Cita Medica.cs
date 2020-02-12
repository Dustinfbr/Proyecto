using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediSoft
{
    public partial class Admin_Cita_Medica : Form
    {
        public Admin_Cita_Medica()
        {
            InitializeComponent();
        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            AgendarCitaMédica agendarCitaMédica = new AgendarCitaMédica();
            this.Hide();
            agendarCitaMédica.ShowDialog();
            this.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCita cita = new ModificarCita();
            this.Hide();
            cita.ShowDialog();
            this.Show();
        }

    }
}
