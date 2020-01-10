namespace MediSoft
{
    partial class AgendarCitaMédica
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
        private void InitializeComponent()
        {
            this.lblagenda = new System.Windows.Forms.Label();
            this.lblMedisoft = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblagenda
            // 
            this.lblagenda.AutoSize = true;
            this.lblagenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblagenda.Location = new System.Drawing.Point(197, 83);
            this.lblagenda.Name = "lblagenda";
            this.lblagenda.Size = new System.Drawing.Size(253, 25);
            this.lblagenda.TabIndex = 14;
            this.lblagenda.Text = "Agendación de Cita Médica";
            // 
            // lblMedisoft
            // 
            this.lblMedisoft.AutoSize = true;
            this.lblMedisoft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedisoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedisoft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedisoft.Location = new System.Drawing.Point(255, 36);
            this.lblMedisoft.Name = "lblMedisoft";
            this.lblMedisoft.Size = new System.Drawing.Size(155, 31);
            this.lblMedisoft.TabIndex = 13;
            this.lblMedisoft.Text = "MEDISOFT";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(100, 121);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(117, 17);
            this.lblNombrePaciente.TabIndex = 15;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(100, 167);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(52, 17);
            this.lblCedula.TabIndex = 16;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(104, 213);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(288, 116);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(311, 22);
            this.txtNombrePaciente.TabIndex = 18;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(288, 167);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(311, 22);
            this.txtCedula.TabIndex = 19;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(468, 237);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(187, 17);
            this.lblIngreso.TabIndex = 20;
            this.lblIngreso.Text = "Ingreso De Hora para Turno";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(452, 356);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 33);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(563, 356);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(90, 33);
            this.btnVerificar.TabIndex = 23;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(532, 255);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(44, 22);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // AgendarCitaMédica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 442);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblagenda);
            this.Controls.Add(this.lblMedisoft);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgendarCitaMédica";
            this.Text = "AgendarCitaMédica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblagenda;
        private System.Windows.Forms.Label lblMedisoft;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}