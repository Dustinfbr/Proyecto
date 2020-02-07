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
    public partial class Secretaria : Form
    {
        public Secretaria()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdmHC_Click(object sender, EventArgs e)
        {
            Admin_Cita_Medica admin_Cita_Medica = new Admin_Cita_Medica();
            admin_Cita_Medica.Show();
            this.Hide();
        }

        private void Secretaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
