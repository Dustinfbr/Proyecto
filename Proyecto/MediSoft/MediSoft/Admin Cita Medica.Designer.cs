namespace MediSoft
{
    partial class Admin_Cita_Medica
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
            this.lblMedisoft = new System.Windows.Forms.Label();
            this.lblsecre = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMedisoft
            // 
            this.lblMedisoft.AutoSize = true;
            this.lblMedisoft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedisoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedisoft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedisoft.Location = new System.Drawing.Point(213, 34);
            this.lblMedisoft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedisoft.Name = "lblMedisoft";
            this.lblMedisoft.Size = new System.Drawing.Size(124, 26);
            this.lblMedisoft.TabIndex = 7;
            this.lblMedisoft.Text = "MEDISOFT";
            // 
            // lblsecre
            // 
            this.lblsecre.AutoSize = true;
            this.lblsecre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblsecre.Location = new System.Drawing.Point(162, 74);
            this.lblsecre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsecre.Name = "lblsecre";
            this.lblsecre.Size = new System.Drawing.Size(200, 20);
            this.lblsecre.TabIndex = 12;
            this.lblsecre.Text = "Administración Cita Médica";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(218, 146);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 46);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar Cita Médica";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(62, 146);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(88, 46);
            this.btnAgendar.TabIndex = 13;
            this.btnAgendar.Text = "Agendar Cita Médica";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.BtnAgendar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(433, 242);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "Administrar Pacientes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Admin_Cita_Medica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lblsecre);
            this.Controls.Add(this.lblMedisoft);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_Cita_Medica";
            this.Text = "Admin_Cita_Medica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedisoft;
        private System.Windows.Forms.Label lblsecre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button1;
    }
}