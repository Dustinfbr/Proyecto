namespace MediSoft
{
    partial class AtenderPaciente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.RtxtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.btnSignos = new System.Windows.Forms.Button();
            this.btnReceta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdmin.Location = new System.Drawing.Point(138, 58);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(243, 20);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Administración de Historia Clínica";
            // 
            // lblMedisoft
            // 
            this.lblMedisoft.AutoSize = true;
            this.lblMedisoft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedisoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedisoft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedisoft.Location = new System.Drawing.Point(199, 9);
            this.lblMedisoft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedisoft.Name = "lblMedisoft";
            this.lblMedisoft.Size = new System.Drawing.Size(124, 26);
            this.lblMedisoft.TabIndex = 6;
            this.lblMedisoft.Text = "MEDISOFT";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(410, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 22);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(50, 84);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(149, 13);
            this.lblIngreso.TabIndex = 49;
            this.lblIngreso.Text = "Ingrese la Cédula de Paciente";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(204, 81);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(160, 20);
            this.txtCedula.TabIndex = 48;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(152, 163);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(0, 13);
            this.lblFechaNac.TabIndex = 47;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(50, 163);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 13);
            this.lblFecha.TabIndex = 46;
            this.lblFecha.Text = "FechaNacimiento";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(152, 140);
            this.lblCI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(0, 13);
            this.lblCI.TabIndex = 45;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(152, 120);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(0, 13);
            this.lblPaciente.TabIndex = 44;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(50, 140);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 43;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(50, 120);
            this.lblNombrePaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(89, 13);
            this.lblNombrePaciente.TabIndex = 42;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(425, 381);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 23);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(500, 381);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(71, 23);
            this.btnRegresar.TabIndex = 52;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // RtxtDiagnostico
            // 
            this.RtxtDiagnostico.Location = new System.Drawing.Point(53, 217);
            this.RtxtDiagnostico.Name = "RtxtDiagnostico";
            this.RtxtDiagnostico.Size = new System.Drawing.Size(476, 145);
            this.RtxtDiagnostico.TabIndex = 54;
            this.RtxtDiagnostico.Text = "";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(50, 192);
            this.lblDiagnostico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(63, 13);
            this.lblDiagnostico.TabIndex = 53;
            this.lblDiagnostico.Text = "Diagnostico";
            this.lblDiagnostico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSignos
            // 
            this.btnSignos.Location = new System.Drawing.Point(425, 187);
            this.btnSignos.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignos.Name = "btnSignos";
            this.btnSignos.Size = new System.Drawing.Size(104, 23);
            this.btnSignos.TabIndex = 55;
            this.btnSignos.Text = "Signos Vitales";
            this.btnSignos.UseVisualStyleBackColor = true;
            this.btnSignos.Click += new System.EventHandler(this.btnSignos_Click);
            // 
            // btnReceta
            // 
            this.btnReceta.Location = new System.Drawing.Point(304, 187);
            this.btnReceta.Margin = new System.Windows.Forms.Padding(2);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(104, 23);
            this.btnReceta.TabIndex = 56;
            this.btnReceta.Text = "Recetar";
            this.btnReceta.UseVisualStyleBackColor = true;
            this.btnReceta.Click += new System.EventHandler(this.btnReceta_Click);
            // 
            // AtenderPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 415);
            this.Controls.Add(this.btnReceta);
            this.Controls.Add(this.btnSignos);
            this.Controls.Add(this.RtxtDiagnostico);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblMedisoft);
            this.Name = "AtenderPaciente";
            this.Text = "AtenderPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblMedisoft;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.RichTextBox RtxtDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Button btnSignos;
        private System.Windows.Forms.Button btnReceta;
    }
}