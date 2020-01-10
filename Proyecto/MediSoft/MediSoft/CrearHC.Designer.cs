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
            this.ChBxAlergias = new System.Windows.Forms.CheckedListBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ChBxEnfermedades = new System.Windows.Forms.CheckedListBox();
            this.lblEnfermedades = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSignosVitales = new System.Windows.Forms.Button();
            this.btnReceta = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdmin.Location = new System.Drawing.Point(253, 86);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(240, 29);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.Text = "Crear Historia Clínica";
            // 
            // lblMedisoft
            // 
            this.lblMedisoft.AutoSize = true;
            this.lblMedisoft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedisoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedisoft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedisoft.Location = new System.Drawing.Point(283, 12);
            this.lblMedisoft.Name = "lblMedisoft";
            this.lblMedisoft.Size = new System.Drawing.Size(181, 37);
            this.lblMedisoft.TabIndex = 6;
            this.lblMedisoft.Text = "MEDISOFT";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(47, 142);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(131, 20);
            this.lblNombrePaciente.TabIndex = 20;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(47, 173);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(59, 20);
            this.lblCedula.TabIndex = 21;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(199, 142);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(152, 20);
            this.lblPaciente.TabIndex = 22;
            this.lblPaciente.Text = "Nombres y Apellidos";
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(199, 173);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(108, 20);
            this.lblCI.TabIndex = 23;
            this.lblCI.Text = "XXXXXXXXX";
            // 
            // lblAlergias
            // 
            this.lblAlergias.AutoSize = true;
            this.lblAlergias.Location = new System.Drawing.Point(47, 250);
            this.lblAlergias.Name = "lblAlergias";
            this.lblAlergias.Size = new System.Drawing.Size(66, 20);
            this.lblAlergias.TabIndex = 24;
            this.lblAlergias.Text = "Alergias";
            this.lblAlergias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChBxAlergias
            // 
            this.ChBxAlergias.FormattingEnabled = true;
            this.ChBxAlergias.Items.AddRange(new object[] {
            "Alergia1",
            "Alergia2",
            "Alergia3",
            "Alergia4",
            "Alergia5",
            "Alergia6",
            "Alergia7",
            "Alergia(",
            "Alergia9",
            "Alergia10",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            "AlergiaN"});
            this.ChBxAlergias.Location = new System.Drawing.Point(51, 273);
            this.ChBxAlergias.Name = "ChBxAlergias";
            this.ChBxAlergias.Size = new System.Drawing.Size(673, 119);
            this.ChBxAlergias.TabIndex = 25;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(47, 208);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(133, 20);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "FechaNacimiento";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 26);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 11, 0, 0, 0, 0);
            // 
            // ChBxEnfermedades
            // 
            this.ChBxEnfermedades.FormattingEnabled = true;
            this.ChBxEnfermedades.Items.AddRange(new object[] {
            "Hipertension",
            "Cancer",
            "Diabetes",
            ".",
            ".",
            ".",
            ".",
            ".",
            "..",
            ".",
            ".",
            "..",
            ".",
            ".",
            "EnferN"});
            this.ChBxEnfermedades.Location = new System.Drawing.Point(51, 433);
            this.ChBxEnfermedades.Name = "ChBxEnfermedades";
            this.ChBxEnfermedades.Size = new System.Drawing.Size(673, 119);
            this.ChBxEnfermedades.TabIndex = 29;
            // 
            // lblEnfermedades
            // 
            this.lblEnfermedades.AutoSize = true;
            this.lblEnfermedades.Location = new System.Drawing.Point(47, 410);
            this.lblEnfermedades.Name = "lblEnfermedades";
            this.lblEnfermedades.Size = new System.Drawing.Size(221, 20);
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
            this.btnGuardar.Location = new System.Drawing.Point(510, 725);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 36);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(622, 725);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(106, 36);
            this.btnRegresar.TabIndex = 35;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // CrearHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 773);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnReceta);
            this.Controls.Add(this.btnSignosVitales);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChBxEnfermedades);
            this.Controls.Add(this.lblEnfermedades);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.ChBxAlergias);
            this.Controls.Add(this.lblAlergias);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblMedisoft);
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
        private System.Windows.Forms.CheckedListBox ChBxAlergias;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox ChBxEnfermedades;
        private System.Windows.Forms.Label lblEnfermedades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSignosVitales;
        private System.Windows.Forms.Button btnReceta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
    }
}