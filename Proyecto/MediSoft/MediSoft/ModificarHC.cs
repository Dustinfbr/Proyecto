﻿using System;
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
    public partial class ModificarHC : Form
    {
        public ModificarHC()
        {
            InitializeComponent();
        }
        int u = 1;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            HistoriaClinica historiaClinica = new HistoriaClinica();
            if (String.IsNullOrEmpty(txtCedula.Text))
            {
                Console.WriteLine("Error");
                MessageBox.Show("Debe Ingresar un Cedula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (String.IsNullOrEmpty(paciente.ObtenerNombres(txtCedula.Text)))
                {
                    Console.WriteLine("Error");
                    MessageBox.Show("Paciente Inexistente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblPaciente.Text = (paciente.ObtenerNombres(txtCedula.Text));
                    lblCI.Text = txtCedula.Text;
                    lblFechaNac.Text = paciente.ObtenerFecha(txtCedula.Text);
                    RtxtAlergias.Text = historiaClinica.MostrarA(txtCedula.Text);
                    RtxtEnfermedades.Text = historiaClinica.MostrarE(txtCedula.Text);
                }
            }        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HistoriaClinica historiaClinica = new HistoriaClinica(RtxtAlergias.Text, RtxtEnfermedades.Text);
            historiaClinica.modificarHC(txtCedula.Text);
            u = 0;
            DialogResult resultado = MessageBox.Show("Informacion Actualizada", "Mensaje", MessageBoxButtons.OK);
            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (u == 1)
            {
                if (!String.IsNullOrEmpty(RtxtAlergias.Text) || !String.IsNullOrEmpty(RtxtEnfermedades.Text))
                {
                    DialogResult resultado = MessageBox.Show("Lo cambios no se han Guardado. ¿Desea Guardarlos?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        HistoriaClinica Hc = new HistoriaClinica(RtxtAlergias.Text, RtxtEnfermedades.Text);
                        Hc.agregarHC(txtCedula.Text);
                        MessageBox.Show("Informacion", "Mensaje", MessageBoxButtons.OK);
                        if (resultado == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
