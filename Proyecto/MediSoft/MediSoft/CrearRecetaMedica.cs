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
    public partial class CrearRecetaMedica : Form
    {
        List<Medicamento> medicinas = new List<Medicamento>();
        public CrearRecetaMedica()
        {
            InitializeComponent();
        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            


            medicinas.Add(new Medicamento(1, textBox1.Text, textBox2.Text));
            
            Medicamento newmed = new Medicamento(1, textBox1.Text, textBox2.Text);
            Console.WriteLine(newmed.ingresarMed());

            DataTable dtmeds = newmed.listaMedicinas();
            dataGridView1.DataSource = dtmeds;
            
          
            MessageBox.Show("Medicamento Ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            medicinas.Add(new Medicamento(1, textBox4.Text, textBox5.Text));

            Medicamento newmed = new Medicamento(1, textBox4.Text, textBox5.Text);
            Console.WriteLine(newmed.actualizarMed());

            DataTable dtmeds = newmed.listaMedicinas();
            dataGridView1.DataSource = dtmeds;

            MessageBox.Show("Medicicamento Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            medicinas.Add(new Medicamento(1, textBox3.Text, "sa"));

            Medicamento newmed = new Medicamento(1, textBox3.Text,"sa");
            Console.WriteLine(newmed.eliminarMed());

            DataTable dtmeds = newmed.listaMedicinas();
            dataGridView1.DataSource = dtmeds;



            MessageBox.Show("Medicamento Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}