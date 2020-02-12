using CapaNegocio;
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
    public partial class CrearPaciente : Form
    {
        public CrearPaciente()
        {
            InitializeComponent();
        }

        String sexo = null;


        private void button2_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente(cedula.Text, nombres.Text, Apellidos.Text, sexo, dateTimePicker1.Value);
            Console.WriteLine(paciente.AgregarPaciente());
            int anios = paciente.CalculoEdad(dateTimePicker1.Value);
            edad.Text = anios.ToString();
            MessageBox.Show("Paciente Agregado", "Mensaje", MessageBoxButtons.OK);
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Femenino";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
