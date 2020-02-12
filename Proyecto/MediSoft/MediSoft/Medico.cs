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
            this.Hide();
            crearHC.ShowDialog();
            this.Show();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarHC ModHC = new ModificarHC();
            this.Hide();
            ModHC.ShowDialog();
            this.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarHC EliminarHC = new EliminarHC();
            this.Hide();
            EliminarHC.ShowDialog();
            this.Show();
        }


        private void btnAtender_Click(object sender, EventArgs e)
        {
            AtenderPaciente atender = new AtenderPaciente();
            this.Hide();
            atender.ShowDialog();
            this.Show();
        }
    }
}
