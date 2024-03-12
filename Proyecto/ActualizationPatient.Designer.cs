namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblEstatusPaciente = new System.Windows.Forms.Label();
            this.LblPatientCode = new System.Windows.Forms.Label();
            this.LblPatientStatus = new System.Windows.Forms.Label();
            this.TxtPatientCode = new System.Windows.Forms.TextBox();
            this.CmbPatientStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblEstatusPaciente
            // 
            this.LblEstatusPaciente.AutoSize = true;
            this.LblEstatusPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstatusPaciente.Location = new System.Drawing.Point(296, 70);
            this.LblEstatusPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEstatusPaciente.Name = "LblEstatusPaciente";
            this.LblEstatusPaciente.Size = new System.Drawing.Size(438, 52);
            this.LblEstatusPaciente.TabIndex = 0;
            this.LblEstatusPaciente.Text = "Estatus del Paciente";
            // 
            // LblPatientCode
            // 
            this.LblPatientCode.AutoSize = true;
            this.LblPatientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientCode.Location = new System.Drawing.Point(279, 198);
            this.LblPatientCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPatientCode.Name = "LblPatientCode";
            this.LblPatientCode.Size = new System.Drawing.Size(206, 25);
            this.LblPatientCode.TabIndex = 1;
            this.LblPatientCode.Text = "Código del Paciente";
            // 
            // LblPatientStatus
            // 
            this.LblPatientStatus.AutoSize = true;
            this.LblPatientStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientStatus.Location = new System.Drawing.Point(279, 290);
            this.LblPatientStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPatientStatus.Name = "LblPatientStatus";
            this.LblPatientStatus.Size = new System.Drawing.Size(209, 25);
            this.LblPatientStatus.TabIndex = 2;
            this.LblPatientStatus.Text = "Estatus del Paciente";
            // 
            // TxtPatientCode
            // 
            this.TxtPatientCode.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPatientCode.Location = new System.Drawing.Point(548, 201);
            this.TxtPatientCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPatientCode.Name = "TxtPatientCode";
            this.TxtPatientCode.Size = new System.Drawing.Size(261, 22);
            this.TxtPatientCode.TabIndex = 3;
            // 
            // CmbPatientStatus
            // 
            this.CmbPatientStatus.BackColor = System.Drawing.SystemColors.Info;
            this.CmbPatientStatus.FormattingEnabled = true;
            this.CmbPatientStatus.Location = new System.Drawing.Point(548, 289);
            this.CmbPatientStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbPatientStatus.Name = "CmbPatientStatus";
            this.CmbPatientStatus.Size = new System.Drawing.Size(261, 24);
            this.CmbPatientStatus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1063, 638);
            this.Controls.Add(this.CmbPatientStatus);
            this.Controls.Add(this.TxtPatientCode);
            this.Controls.Add(this.LblPatientStatus);
            this.Controls.Add(this.LblPatientCode);
            this.Controls.Add(this.LblEstatusPaciente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEstatusPaciente;
        private System.Windows.Forms.Label LblPatientCode;
        private System.Windows.Forms.Label LblPatientStatus;
        private System.Windows.Forms.TextBox TxtPatientCode;
        private System.Windows.Forms.ComboBox CmbPatientStatus;
    }
}

