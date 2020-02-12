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
    public partial class EliminarHC : Form
    {
        public EliminarHC()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HistoriaClinica historiaClinica = new HistoriaClinica();
            dataGridView1.DataSource = historiaClinica.buscarHC(txtCI.Text);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            HistoriaClinica historiaClinica = new HistoriaClinica();
            historiaClinica.eliminarHC(txtCI.Text);
            dataGridView1.DataSource = historiaClinica.listarHC();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
