﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using master;

namespace MediSoft
{
    public partial class Login : Form
    {
        Usuario Doctor = new Usuario("Jaime", "12345678");
        public Login()
        {
            InitializeComponent();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        public void VerificarUsuario()
        {

            if ( txtUsuario.Text == "Ramiro" && txtContra.Text == "12345")
            {
                MessageBox.Show("Ingreso Exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Medico medico = new Medico();
                this.Close();
                medico.Show();
            }
            else if(txtUsuario.Text == "Karla" && txtContra.Text == "12345")
            {
                MessageBox.Show("Ingreso Exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Secretaria secre = new Secretaria();
                this.Close();
                secre.Show();
            }
            else
            {
                MessageBox.Show("Ingreso Incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BntLogin_Click(object sender, EventArgs e)
        {
            VerificarUsuario();
        }

        private void LblMEDISOFT_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}