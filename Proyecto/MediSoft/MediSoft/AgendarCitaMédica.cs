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
    public partial class AgendarCitaMédica : Form
    {
        public AgendarCitaMédica()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearPaciente crearPaciente = new CrearPaciente();
            this.Hide();
            crearPaciente.ShowDialog();
            this.Show();
        }
    }
}
