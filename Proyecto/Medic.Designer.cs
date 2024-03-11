namespace Proyecto
{
    partial class Medic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medic));
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblProfessionalLicense = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtProfessionalLicense = new System.Windows.Forms.TextBox();
            this.LblDoctorResponsibleForThePatient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(169, 196);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(87, 25);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.BackColor = System.Drawing.Color.Transparent;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(169, 268);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(90, 25);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Apellido";
            // 
            // LblProfessionalLicense
            // 
            this.LblProfessionalLicense.AutoSize = true;
            this.LblProfessionalLicense.BackColor = System.Drawing.Color.Transparent;
            this.LblProfessionalLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfessionalLicense.Location = new System.Drawing.Point(169, 341);
            this.LblProfessionalLicense.Name = "LblProfessionalLicense";
            this.LblProfessionalLicense.Size = new System.Drawing.Size(204, 25);
            this.LblProfessionalLicense.TabIndex = 2;
            this.LblProfessionalLicense.Text = "Licencia profesional";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtName.Location = new System.Drawing.Point(413, 199);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(323, 22);
            this.TxtName.TabIndex = 3;
            // 
            // TxtLastName
            // 
            this.TxtLastName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtLastName.Location = new System.Drawing.Point(413, 268);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(323, 22);
            this.TxtLastName.TabIndex = 4;
            this.TxtLastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtProfessionalLicense
            // 
            this.TxtProfessionalLicense.BackColor = System.Drawing.SystemColors.Info;
            this.TxtProfessionalLicense.Location = new System.Drawing.Point(413, 344);
            this.TxtProfessionalLicense.Name = "TxtProfessionalLicense";
            this.TxtProfessionalLicense.Size = new System.Drawing.Size(323, 22);
            this.TxtProfessionalLicense.TabIndex = 5;
            // 
            // LblDoctorResponsibleForThePatient
            // 
            this.LblDoctorResponsibleForThePatient.AutoSize = true;
            this.LblDoctorResponsibleForThePatient.BackColor = System.Drawing.Color.Transparent;
            this.LblDoctorResponsibleForThePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoctorResponsibleForThePatient.Location = new System.Drawing.Point(169, 93);
            this.LblDoctorResponsibleForThePatient.Name = "LblDoctorResponsibleForThePatient";
            this.LblDoctorResponsibleForThePatient.Size = new System.Drawing.Size(329, 25);
            this.LblDoctorResponsibleForThePatient.TabIndex = 6;
            this.LblDoctorResponsibleForThePatient.Text = "Medico responsable del paciente";
            // 
            // Medic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1033, 592);
            this.Controls.Add(this.LblDoctorResponsibleForThePatient);
            this.Controls.Add(this.TxtProfessionalLicense);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblProfessionalLicense);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Medic";
            this.Text = "Medic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblProfessionalLicense;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtProfessionalLicense;
        private System.Windows.Forms.Label LblDoctorResponsibleForThePatient;
    }
}