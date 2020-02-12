using CapaNegocio;
namespace MediSoft
{
    partial class SignosVitales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent1(string CI)
        {
            this.lblMedisoft = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblSignosVitales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtOx = new System.Windows.Forms.TextBox();
            this.txtPAS = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblIMCtxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPAD = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblPAD = new System.Windows.Forms.Label();
            this.lblPAS = new System.Windows.Forms.Label();
            this.lblOx = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblRitmo = new System.Windows.Forms.Label();
            this.txtRitmo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMedisoft
            // 
            this.lblMedisoft.AutoSize = true;
            this.lblMedisoft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedisoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedisoft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedisoft.Location = new System.Drawing.Point(189, 15);
            this.lblMedisoft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedisoft.Name = "lblMedisoft";
            this.lblMedisoft.Size = new System.Drawing.Size(124, 26);
            this.lblMedisoft.TabIndex = 7;
            this.lblMedisoft.Text = "MEDISOFT";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(19, 134);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 13);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "FechaNacimiento";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // Load Datos HC
            //
            Paciente p = new Paciente();
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(136, 111);
            this.lblCI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(70, 13);
            this.lblCI.TabIndex = 32;
            this.lblCI.Text = CI;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(136, 91);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(102, 13);
            this.lblPaciente.TabIndex = 31;
            this.lblPaciente.Text = p.ObtenerNombres(CI);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(136, 134);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(0, 13);
            this.lblFechaNac.TabIndex = 56;
            this.lblFechaNac.Text = p.ObtenerFecha(CI);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(19, 111);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 30;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(19, 91);
            this.lblNombrePaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(89, 13);
            this.lblNombrePaciente.TabIndex = 29;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // lblSignosVitales
            // 
            this.lblSignosVitales.AutoSize = true;
            this.lblSignosVitales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSignosVitales.Location = new System.Drawing.Point(190, 51);
            this.lblSignosVitales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignosVitales.Name = "lblSignosVitales";
            this.lblSignosVitales.Size = new System.Drawing.Size(110, 20);
            this.lblSignosVitales.TabIndex = 28;
            this.lblSignosVitales.Text = "Signos Vitales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Saturacion de oxigeno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Presion Arterial Sistólica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Temperatura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(139, 163);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(84, 20);
            this.txtAltura.TabIndex = 40;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(139, 247);
            this.txtTemp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(84, 20);
            this.txtTemp.TabIndex = 41;
            // 
            // txtOx
            // 
            this.txtOx.Location = new System.Drawing.Point(139, 226);
            this.txtOx.Margin = new System.Windows.Forms.Padding(2);
            this.txtOx.Name = "txtOx";
            this.txtOx.Size = new System.Drawing.Size(84, 20);
            this.txtOx.TabIndex = 42;
            // 
            // txtPAS
            // 
            this.txtPAS.Location = new System.Drawing.Point(139, 205);
            this.txtPAS.Margin = new System.Windows.Forms.Padding(2);
            this.txtPAS.Name = "txtPAS";
            this.txtPAS.Size = new System.Drawing.Size(84, 20);
            this.txtPAS.TabIndex = 43;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(139, 184);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(84, 20);
            this.txtPeso.TabIndex = 44;
            // 
            // lblIMCtxt
            // 
            this.lblIMCtxt.AutoSize = true;
            this.lblIMCtxt.Location = new System.Drawing.Point(23, 314);
            this.lblIMCtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIMCtxt.Name = "lblIMCtxt";
            this.lblIMCtxt.Size = new System.Drawing.Size(26, 13);
            this.lblIMCtxt.TabIndex = 45;
            this.lblIMCtxt.Text = "IMC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Presion Arterial Diastólica";
            // 
            // txtPAD
            // 
            this.txtPAD.Location = new System.Drawing.Point(447, 205);
            this.txtPAD.Margin = new System.Windows.Forms.Padding(2);
            this.txtPAD.Name = "txtPAD";
            this.txtPAD.Size = new System.Drawing.Size(84, 20);
            this.txtPAD.TabIndex = 47;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIMC.Location = new System.Drawing.Point(62, 314);
            this.lblIMC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(86, 15);
            this.lblIMC.TabIndex = 48;
            this.lblIMC.Text = "Click en Evaluar";
            // 
            // lblPAD
            // 
            this.lblPAD.AutoSize = true;
            this.lblPAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPAD.Location = new System.Drawing.Point(541, 207);
            this.lblPAD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPAD.Name = "lblPAD";
            this.lblPAD.Size = new System.Drawing.Size(2, 15);
            this.lblPAD.TabIndex = 49;
            // 
            // lblPAS
            // 
            this.lblPAS.AutoSize = true;
            this.lblPAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPAS.Location = new System.Drawing.Point(225, 205);
            this.lblPAS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPAS.Name = "lblPAS";
            this.lblPAS.Size = new System.Drawing.Size(2, 15);
            this.lblPAS.TabIndex = 50;
            // 
            // lblOx
            // 
            this.lblOx.AutoSize = true;
            this.lblOx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOx.Location = new System.Drawing.Point(244, 229);
            this.lblOx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(2, 15);
            this.lblOx.TabIndex = 51;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemp.Location = new System.Drawing.Point(225, 247);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(2, 15);
            this.lblTemp.TabIndex = 52;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(523, 345);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(71, 23);
            this.btnRegresar.TabIndex = 55;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(438, 345);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 23);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblRitmo
            // 
            this.lblRitmo.AutoSize = true;
            this.lblRitmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRitmo.Location = new System.Drawing.Point(225, 271);
            this.lblRitmo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRitmo.Name = "lblRitmo";
            this.lblRitmo.Size = new System.Drawing.Size(2, 15);
            this.lblRitmo.TabIndex = 59;
            // 
            // txtRitmo
            // 
            this.txtRitmo.Location = new System.Drawing.Point(139, 271);
            this.txtRitmo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRitmo.Name = "txtRitmo";
            this.txtRitmo.Size = new System.Drawing.Size(84, 20);
            this.txtRitmo.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Ritmo Cardiaco";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(351, 345);
            this.btnEvaluar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(71, 23);
            this.btnEvaluar.TabIndex = 60;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "%";
            // 
            // SignosVitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 381);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.lblRitmo);
            this.Controls.Add(this.txtRitmo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblOx);
            this.Controls.Add(this.lblPAS);
            this.Controls.Add(this.lblPAD);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txtPAD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIMCtxt);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPAS);
            this.Controls.Add(this.txtOx);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblSignosVitales);
            this.Controls.Add(this.lblMedisoft);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignosVitales";
            this.Text = "SignosVitales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeComponent()
        {
            this.lblMedisoft = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblSignosVitales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtOx = new System.Windows.Forms.TextBox();
            this.txtPAS = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblIMCtxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPAD = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblPAD = new System.Windows.Forms.Label();
            this.lblPAS = new System.Windows.Forms.Label();
            this.lblOx = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblRitmo = new System.Windows.Forms.Label();
            this.txtRitmo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMedisoft
            // 
            this.lblMedisoft.AutoSize = true;
            this.lblMedisoft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedisoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedisoft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedisoft.Location = new System.Drawing.Point(189, 15);
            this.lblMedisoft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedisoft.Name = "lblMedisoft";
            this.lblMedisoft.Size = new System.Drawing.Size(124, 26);
            this.lblMedisoft.TabIndex = 7;
            this.lblMedisoft.Text = "MEDISOFT";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(19, 134);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 13);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "FechaNacimiento";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(136, 111);
            this.lblCI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(0, 13);
            this.lblCI.TabIndex = 32;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(136, 91);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(0, 13);
            this.lblPaciente.TabIndex = 31;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(19, 111);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 30;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(19, 91);
            this.lblNombrePaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(89, 13);
            this.lblNombrePaciente.TabIndex = 29;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // lblSignosVitales
            // 
            this.lblSignosVitales.AutoSize = true;
            this.lblSignosVitales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSignosVitales.Location = new System.Drawing.Point(190, 51);
            this.lblSignosVitales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignosVitales.Name = "lblSignosVitales";
            this.lblSignosVitales.Size = new System.Drawing.Size(110, 20);
            this.lblSignosVitales.TabIndex = 28;
            this.lblSignosVitales.Text = "Signos Vitales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Saturacion de oxigeno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Presion Arterial Sistólica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Temperatura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(139, 163);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(84, 20);
            this.txtAltura.TabIndex = 40;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(139, 247);
            this.txtTemp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(84, 20);
            this.txtTemp.TabIndex = 41;
            // 
            // txtOx
            // 
            this.txtOx.Location = new System.Drawing.Point(139, 226);
            this.txtOx.Margin = new System.Windows.Forms.Padding(2);
            this.txtOx.Name = "txtOx";
            this.txtOx.Size = new System.Drawing.Size(84, 20);
            this.txtOx.TabIndex = 42;
            // 
            // txtPAS
            // 
            this.txtPAS.Location = new System.Drawing.Point(139, 205);
            this.txtPAS.Margin = new System.Windows.Forms.Padding(2);
            this.txtPAS.Name = "txtPAS";
            this.txtPAS.Size = new System.Drawing.Size(84, 20);
            this.txtPAS.TabIndex = 43;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(139, 184);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(84, 20);
            this.txtPeso.TabIndex = 44;
            // 
            // lblIMCtxt
            // 
            this.lblIMCtxt.AutoSize = true;
            this.lblIMCtxt.Location = new System.Drawing.Point(23, 314);
            this.lblIMCtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIMCtxt.Name = "lblIMCtxt";
            this.lblIMCtxt.Size = new System.Drawing.Size(26, 13);
            this.lblIMCtxt.TabIndex = 45;
            this.lblIMCtxt.Text = "IMC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Presion Arterial Diastólica";
            // 
            // txtPAD
            // 
            this.txtPAD.Location = new System.Drawing.Point(447, 205);
            this.txtPAD.Margin = new System.Windows.Forms.Padding(2);
            this.txtPAD.Name = "txtPAD";
            this.txtPAD.Size = new System.Drawing.Size(84, 20);
            this.txtPAD.TabIndex = 47;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIMC.Location = new System.Drawing.Point(62, 314);
            this.lblIMC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(86, 15);
            this.lblIMC.TabIndex = 48;
            this.lblIMC.Text = "Click en Evaluar";
            // 
            // lblPAD
            // 
            this.lblPAD.AutoSize = true;
            this.lblPAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPAD.Location = new System.Drawing.Point(541, 207);
            this.lblPAD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPAD.Name = "lblPAD";
            this.lblPAD.Size = new System.Drawing.Size(2, 15);
            this.lblPAD.TabIndex = 49;
            // 
            // lblPAS
            // 
            this.lblPAS.AutoSize = true;
            this.lblPAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPAS.Location = new System.Drawing.Point(225, 205);
            this.lblPAS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPAS.Name = "lblPAS";
            this.lblPAS.Size = new System.Drawing.Size(2, 15);
            this.lblPAS.TabIndex = 50;
            // 
            // lblOx
            // 
            this.lblOx.AutoSize = true;
            this.lblOx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOx.Location = new System.Drawing.Point(244, 229);
            this.lblOx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(2, 15);
            this.lblOx.TabIndex = 51;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemp.Location = new System.Drawing.Point(225, 247);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(2, 15);
            this.lblTemp.TabIndex = 52;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(523, 345);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(71, 23);
            this.btnRegresar.TabIndex = 55;
            this.btnRegresar.Text = "c";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(438, 345);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 23);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(136, 134);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(0, 13);
            this.lblFechaNac.TabIndex = 56;
            // 
            // lblRitmo
            // 
            this.lblRitmo.AutoSize = true;
            this.lblRitmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRitmo.Location = new System.Drawing.Point(225, 271);
            this.lblRitmo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRitmo.Name = "lblRitmo";
            this.lblRitmo.Size = new System.Drawing.Size(2, 15);
            this.lblRitmo.TabIndex = 59;
            // 
            // txtRitmo
            // 
            this.txtRitmo.Location = new System.Drawing.Point(139, 271);
            this.txtRitmo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRitmo.Name = "txtRitmo";
            this.txtRitmo.Size = new System.Drawing.Size(84, 20);
            this.txtRitmo.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Ritmo Cardiaco";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(351, 345);
            this.btnEvaluar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(71, 23);
            this.btnEvaluar.TabIndex = 60;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "%";
            // 
            // SignosVitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 381);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.lblRitmo);
            this.Controls.Add(this.txtRitmo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblOx);
            this.Controls.Add(this.lblPAS);
            this.Controls.Add(this.lblPAD);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txtPAD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIMCtxt);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPAS);
            this.Controls.Add(this.txtOx);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblSignosVitales);
            this.Controls.Add(this.lblMedisoft);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignosVitales";
            this.Text = "SignosVitales";
            this.Load += new System.EventHandler(this.SignosVitales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedisoft;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblSignosVitales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtOx;
        private System.Windows.Forms.TextBox txtPAS;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblIMCtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPAD;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblPAD;
        private System.Windows.Forms.Label lblPAS;
        private System.Windows.Forms.Label lblOx;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblRitmo;
        private System.Windows.Forms.TextBox txtRitmo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label label6;
    }
}