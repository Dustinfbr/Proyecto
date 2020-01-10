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
            Application.Exit();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearHC crearHC = new CrearHC();
            crearHC.Show();
            this.Close();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarHC ModHC = new ModificarHC();
            ModHC.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarHC EliminarHC = new EliminarHC();
            EliminarHC.Show();
            this.Close();
        }

    }
}
