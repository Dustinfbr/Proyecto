namespace MediSoft
{
    partial class Secretaria
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
            this.lblsecre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAdmHC = new System.Windows.Forms.Button();
            this.btnVisualizarAgenda = new System.Windows.Forms.Button();
            this.lblMedisoft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsecre
            // 
            this.lblsecre.AutoSize = true;
            this.lblsecre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblsecre.Location = new System.Drawing.Point(200, 73);
            this.lblsecre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsecre.Name = "lblsecre";
            this.lblsecre.Size = new System.Drawing.Size(126, 20);
            this.lblsecre.TabIndex = 11;
            this.lblsecre.Text = "Menú Secretaria";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(431, 245);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnAdmHC
            // 
            this.btnAdmHC.Location = new System.Drawing.Point(320, 131);
            this.btnAdmHC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmHC.Name = "btnAdmHC";
            this.btnAdmHC.Size = new System.Drawing.Size(88, 46);
            this.btnAdmHC.TabIndex = 8;
            this.btnAdmHC.Text = "Administrar Cita Médica";
            this.btnAdmHC.UseVisualStyleBackColor = true;
            this.btnAdmHC.Click += new System.EventHandler(this.BtnAdmHC_Click);
            // 
            // btnVisualizarAgenda
            // 
            this.btnVisualizarAgenda.Location = new System.Drawing.Point(115, 131);
            this.btnVisualizarAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizarAgenda.Name = "btnVisualizarAgenda";
            this.btnVisualizarAgenda.Size = new System.Drawing.Size(88, 46);
            this.btnVisualizarAgenda.TabIndex = 7;
            this.btnVisualizarAgenda.Text = "Visualizar Agenda";
            this.btnVisualizarAgenda.UseVisualStyleBackColor = true;
            this.btnVisualizarAgenda.Click += new System.EventHandler(this.btnVisualizarAgenda_Click);
            // 
            // lblMedisoft
            // 
            this.lblMedisoft.AutoSize = true;
            this.lblMedisoft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMedisoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMedisoft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMedisoft.Location = new System.Drawing.Point(199, 25);
            this.lblMedisoft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedisoft.Name = "lblMedisoft";
            this.lblMedisoft.Size = new System.Drawing.Size(124, 26);
            this.lblMedisoft.TabIndex = 6;
            this.lblMedisoft.Text = "MEDISOFT";
            // 
            // Secretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblsecre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdmHC);
            this.Controls.Add(this.btnVisualizarAgenda);
            this.Controls.Add(this.lblMedisoft);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Secretaria";
            this.Text = "Secretaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsecre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAdmHC;
        private System.Windows.Forms.Button btnVisualizarAgenda;
        private System.Windows.Forms.Label lblMedisoft;
    }
}