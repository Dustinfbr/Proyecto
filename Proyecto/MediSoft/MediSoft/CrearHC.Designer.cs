namespace MediSoft
{
    partial class CrearHC
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblMedisoft = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            this.lblAlergias = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEnfermedades = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.RtxtAlergias = new System.Windows.Forms.RichTextBox();
            this.RtxtEnfermedades = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdmin.Location = new System.Drawing.Point(169, 56);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(156, 20);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.Text = "Crear Historia Clínica";
            // 
            // lblMedisoft
            // 
            this.lblMedisoft.AutoSize = true;
            this.lblMedisoft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedisoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedisoft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedisoft.Location = new System.Drawing.Point(189, 8);
            this.lblMedisoft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedisoft.Name = "lblMedisoft";
            this.lblMedisoft.Size = new System.Drawing.Size(124, 26);
            this.lblMedisoft.TabIndex = 6;
            this.lblMedisoft.Text = "MEDISOFT";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(31, 92);
            this.lblNombrePaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(89, 13);
            this.lblNombrePaciente.TabIndex = 20;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(31, 112);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 21;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(133, 92);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(102, 13);
            this.lblPaciente.TabIndex = 22;
            this.lblPaciente.Text = "Nombres y Apellidos";
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(133, 112);
            this.lblCI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(70, 13);
            this.lblCI.TabIndex = 23;
            this.lblCI.Text = "XXXXXXXXX";
            // 
            // lblAlergias
            // 
            this.lblAlergias.AutoSize = true;
            this.lblAlergias.Location = new System.Drawing.Point(31, 162);
            this.lblAlergias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlergias.Name = "lblAlergias";
            this.lblAlergias.Size = new System.Drawing.Size(44, 13);
            this.lblAlergias.TabIndex = 24;
            this.lblAlergias.Text = "Alergias";
            this.lblAlergias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(31, 135);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 13);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "FechaNacimiento";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEnfermedades
            // 
            this.lblEnfermedades.AutoSize = true;
            this.lblEnfermedades.Location = new System.Drawing.Point(31, 266);
            this.lblEnfermedades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnfermedades.Name = "lblEnfermedades";
            this.lblEnfermedades.Size = new System.Drawing.Size(145, 13);
            this.lblEnfermedades.TabIndex = 28;
            this.lblEnfermedades.Text = "Enfermedades Pre-Existentes";
            this.lblEnfermedades.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Diagnostico";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(51, 607);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(673, 96);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // btnSignosVitales
            // 
            this.btnSignosVitales.Location = new System.Drawing.Point(539, 565);
            this.btnSignosVitales.Name = "btnSignosVitales";
            this.btnSignosVitales.Size = new System.Drawing.Size(185, 36);
            this.btnSignosVitales.TabIndex = 32;
            this.btnSignosVitales.Text = "Ingresar Signos Vitales";
            this.btnSignosVitales.UseVisualStyleBackColor = true;
            // 
            // btnReceta
            // 
            this.btnReceta.Location = new System.Drawing.Point(321, 725);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(183, 36);
            this.btnReceta.TabIndex = 33;
            this.btnReceta.Text = "Crear Receta Medica";
            this.btnReceta.UseVisualStyleBackColor = true;
            this.btnReceta.Click += new System.EventHandler(this.BtnReceta_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(363, 392);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 23);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(438, 392);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(71, 23);
            this.btnRegresar.TabIndex = 35;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(133, 135);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(70, 13);
            this.lblFechaNac.TabIndex = 36;
            this.lblFechaNac.Text = "XXXXXXXXX";
            // 
            // RtxtAlergias
            // 
            this.RtxtAlergias.Location = new System.Drawing.Point(35, 182);
            this.RtxtAlergias.Name = "RtxtAlergias";
            this.RtxtAlergias.Size = new System.Drawing.Size(460, 81);
            this.RtxtAlergias.TabIndex = 37;
            this.RtxtAlergias.Text = "";
            // 
            // RtxtEnfermedades
            // 
            this.RtxtEnfermedades.Location = new System.Drawing.Point(35, 282);
            this.RtxtEnfermedades.Name = "RtxtEnfermedades";
            this.RtxtEnfermedades.Size = new System.Drawing.Size(460, 86);
            this.RtxtEnfermedades.TabIndex = 38;
            this.RtxtEnfermedades.Text = "";
            // 
            // CrearHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 426);
            this.Controls.Add(this.RtxtEnfermedades);
            this.Controls.Add(this.RtxtAlergias);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEnfermedades);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblAlergias);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblMedisoft);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearHC";
            this.Text = "CrearHC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblMedisoft;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label lblAlergias;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEnfermedades;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.RichTextBox RtxtAlergias;
        private System.Windows.Forms.RichTextBox RtxtEnfermedades;
    }
}