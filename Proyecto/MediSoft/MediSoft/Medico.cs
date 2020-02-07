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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearHC crearHC = new CrearHC();
            crearHC.Show();
            this.Hide();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarHC ModHC = new ModificarHC();
            ModHC.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarHC EliminarHC = new EliminarHC();
            EliminarHC.Show();
            this.Hide();
        }

        private void Medico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
