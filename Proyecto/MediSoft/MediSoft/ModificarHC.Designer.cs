namespace MediSoft
{
    partial class ModificarHC
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
            this.RtxtEnfermedades = new System.Windows.Forms.RichTextBox();
            this.RtxtAlergias = new System.Windows.Forms.RichTextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEnfermedades = new System.Windows.Forms.Label();
            this.lblAlergias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdmin.Location = new System.Drawing.Point(166, 57);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(227, 20);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.Text = "Modificación de Historia Clínica";
            // 
            // lblMedisoft
            // 
            this.lblMedisoft.AutoSize = true;
            this.lblMedisoft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedisoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedisoft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedisoft.Location = new System.Drawing.Point(205, 9);
            this.lblMedisoft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedisoft.Name = "lblMedisoft";
            this.lblMedisoft.Size = new System.Drawing.Size(124, 26);
            this.lblMedisoft.TabIndex = 6;
            this.lblMedisoft.Text = "MEDISOFT";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(416, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 22);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(56, 94);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(149, 13);
            this.lblIngreso.TabIndex = 43;
            this.lblIngreso.Text = "Ingrese la Cédula de Paciente";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(210, 91);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(160, 20);
            this.txtCedula.TabIndex = 42;
            // 
            // RtxtEnfermedades
            // 
            this.RtxtEnfermedades.Location = new System.Drawing.Point(59, 256);
            this.RtxtEnfermedades.Name = "RtxtEnfermedades";
            this.RtxtEnfermedades.Size = new System.Drawing.Size(460, 86);
            this.RtxtEnfermedades.TabIndex = 49;
            this.RtxtEnfermedades.Text = "";
            // 
            // RtxtAlergias
            // 
            this.RtxtAlergias.Location = new System.Drawing.Point(59, 156);
            this.RtxtAlergias.Name = "RtxtAlergias";
            this.RtxtAlergias.Size = new System.Drawing.Size(460, 81);
            this.RtxtAlergias.TabIndex = 48;
            this.RtxtAlergias.Text = "";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(463, 347);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(71, 23);
            this.btnRegresar.TabIndex = 47;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(388, 347);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 23);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblEnfermedades
            // 
            this.lblEnfermedades.AutoSize = true;
            this.lblEnfermedades.Location = new System.Drawing.Point(55, 240);
            this.lblEnfermedades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnfermedades.Name = "lblEnfermedades";
            this.lblEnfermedades.Size = new System.Drawing.Size(145, 13);
            this.lblEnfermedades.TabIndex = 45;
            this.lblEnfermedades.Text = "Enfermedades Pre-Existentes";
            this.lblEnfermedades.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAlergias
            // 
            this.lblAlergias.AutoSize = true;
            this.lblAlergias.Location = new System.Drawing.Point(56, 140);
            this.lblAlergias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlergias.Name = "lblAlergias";
            this.lblAlergias.Size = new System.Drawing.Size(44, 13);
            this.lblAlergias.TabIndex = 50;
            this.lblAlergias.Text = "Alergias";
            this.lblAlergias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModificarHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 385);
            this.Controls.Add(this.lblAlergias);
            this.Controls.Add(this.RtxtEnfermedades);
            this.Controls.Add(this.RtxtAlergias);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEnfermedades);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblMedisoft);
            this.Name = "ModificarHC";
            this.Text = "ModificarHC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblMedisoft;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.RichTextBox RtxtEnfermedades;
        private System.Windows.Forms.RichTextBox RtxtAlergias;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEnfermedades;
        private System.Windows.Forms.Label lblAlergias;
    }
}