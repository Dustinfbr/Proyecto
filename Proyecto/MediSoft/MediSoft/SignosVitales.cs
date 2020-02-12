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
    public partial class SignosVitales : Form
    {
        public SignosVitales()
        {
            InitializeComponent();
        }

        public SignosVitales(String Cedu)
        {
            InitializeComponent1(Cedu);
        }

        SignoVital sgn = new SignoVital();
        int u = 1;
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (u == 1)
            {
                if (!String.IsNullOrEmpty(txtRitmo.Text))
                {
                    DialogResult resultado = MessageBox.Show("Lo cambios no se han Guardado. ¿Desea Guardarlos?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        SignoVital sig = new SignoVital(txtAltura.Text, txtPeso.Text, txtTemp.Text, txtPAS.Text, txtPAD.Text, txtRitmo.Text, txtOx.Text);
                        sig.agregarSignos(lblCI.Text);
                        MessageBox.Show("Informacion Guardada", "Mensaje", MessageBoxButtons.OK);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SignoVital sig = new SignoVital(txtAltura.Text,txtPeso.Text,txtTemp.Text,txtPAS.Text,txtPAD.Text,txtRitmo.Text,txtOx.Text);
            sig.agregarSignos(lblCI.Text);
            u = 0;
            DialogResult resultado = MessageBox.Show("Informacion Guardada", "Mensaje", MessageBoxButtons.OK);
            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPeso.Text))
            {
                double imc = sgn.CalculoIMC(txtAltura.Text, txtPeso.Text);
                if (imc < 18.5)
                {
                    lblIMC.Text = "Peso Inferior al Normal";
                }
                else
                {
                    if (imc >= 18.5 & imc <= 24.9)
                    {
                        lblIMC.Text = "Peso Normal";
                    }
                    else
                    {
                        if (imc >= 25.0 & imc <= 29.9)
                        {
                            lblIMC.Text = "Peso Superior al Normal";
                        }
                        else
                        {
                            lblIMC.Text = "Sobrepeso";
                        }
                    }
                }
            }

            double P1 = Convert.ToDouble(txtPAS.Text);
            if (P1 < 120)
            {
                lblPAS.Text = "Optima";
                lblPAS.BackColor = Color.Green;
            }
            else
            {
                if (P1 >= 120 & P1 <= 129)
                {
                    lblPAS.Text = "Normal";
                    lblPAS.BackColor = Color.LightGreen;
                }
                else
                {
                    if (P1 >= 130 & P1 <= 139)
                    {
                        lblPAS.Text = "Normal Alta";
                        lblPAS.BackColor = Color.Yellow;
                    }
                    else
                    {
                        if (P1 >= 140 & P1 <= 159)
                        {
                            lblPAS.Text = "HTA grado 1";
                            lblPAS.BackColor = Color.Orange;
                        }
                        else
                        {
                            if (P1 >= 160 & P1 <= 179)
                            {
                                lblPAS.Text = "HTA grado 2";
                                lblPAS.BackColor = Color.OrangeRed;
                            }
                            else
                            {
                                lblPAS.Text = "HTA grado 3";
                                lblPAS.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }

            double P = Convert.ToDouble(txtPAD.Text);
            if (P < 80)
            {
                lblPAD.Text = "Optima";
                lblPAD.BackColor = Color.Green;
            }
            else
            {
                if (P >= 80 & P <= 84)
                {
                    lblPAD.Text = "Normal";
                    lblPAD.BackColor = Color.LightGreen;
                }
                else
                {
                    if (P >= 85 & P <= 89)
                    {
                        lblPAD.Text = "Normal Alta";
                        lblPAD.BackColor = Color.Yellow;
                    }
                    else
                    {
                        if (P >= 90 & P <= 99)
                        {
                            lblPAD.Text = "HTA grado 1";
                            lblPAD.BackColor = Color.Orange;
                        }
                        else
                        {
                            if (P >= 100 & P <= 109)
                            {
                                lblPAD.Text = "HTA grado 2";
                                lblPAD.BackColor = Color.OrangeRed;
                            }
                            else
                            {
                                lblPAD.Text = "HTA grado 3";
                                lblPAD.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }

            double Ox = Convert.ToDouble(txtOx.Text);
            if (Ox > 95)
            {
                lblOx.Text = "Normal";
                lblOx.BackColor = Color.Green;
            }
            else
            {
                lblOx.Text = "Bajo";
                lblOx.BackColor = Color.Red;
            }


            double tem = Convert.ToDouble(txtTemp.Text);
            if (tem < 36.5)
            {
                lblTemp.Text = "Baja";
                lblTemp.BackColor = Color.OrangeRed;
            }
            else
            {
                if (tem >= 36.6 & tem <=37.5 )
                {
                    lblTemp.Text = "Normal";
                    lblTemp.BackColor = Color.Green;
                }
                else
                {
                    lblTemp.Text = "Fiebre";
                    lblTemp.BackColor = Color.Red;
                }
            }


            double rit = Convert.ToDouble(txtRitmo.Text);
            if (rit >= 60 & rit <=100)
            {
                lblRitmo.Text = "Normal";
                lblRitmo.BackColor = Color.Green;
            }
            else
            {
                if (rit < 60)
                {
                    lblRitmo.Text = "Peligro";
                    lblRitmo.BackColor = Color.Red;
                }
                else
                {
                    lblRitmo.Text = "Taquicardia";
                    lblRitmo.BackColor = Color.OrangeRed;
                }
            }

        }

        private void SignosVitales_Load(object sender, EventArgs e)
        {

        }
    }
}
