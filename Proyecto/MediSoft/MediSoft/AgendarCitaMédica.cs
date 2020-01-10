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

        private void TxtTurno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Admin_Cita_Medica admin_Cita_Medica = new Admin_Cita_Medica();
            admin_Cita_Medica.Show();
            this.Close();
        }
    }
}
