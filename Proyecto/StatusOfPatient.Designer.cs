namespace Proyecto
{
    partial class StatusOfPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusOfPatient));
            this.LblPatientStatus = new System.Windows.Forms.Label();
            this.LblPatientNumber = new System.Windows.Forms.Label();
            this.LlbPatientCode = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtPatientCode = new System.Windows.Forms.TextBox();
            this.TxtPatientNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblPatientStatus
            // 
            this.LblPatientStatus.AutoSize = true;
            this.LblPatientStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientStatus.Location = new System.Drawing.Point(22, 7);
            this.LblPatientStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPatientStatus.Name = "LblPatientStatus";
            this.LblPatientStatus.Size = new System.Drawing.Size(157, 17);
            this.LblPatientStatus.TabIndex = 23;
            this.LblPatientStatus.Text = "Estatus del Paciente";
            // 
            // LblPatientNumber
            // 
            this.LblPatientNumber.AutoSize = true;
            this.LblPatientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientNumber.Location = new System.Drawing.Point(22, 58);
            this.LblPatientNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPatientNumber.Name = "LblPatientNumber";
            this.LblPatientNumber.Size = new System.Drawing.Size(239, 17);
            this.LblPatientNumber.TabIndex = 24;
            this.LblPatientNumber.Text = "Número de Control del Paciente";
            // 
            // LlbPatientCode
            // 
            this.LlbPatientCode.AutoSize = true;
            this.LlbPatientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlbPatientCode.Location = new System.Drawing.Point(22, 112);
            this.LlbPatientCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LlbPatientCode.Name = "LlbPatientCode";
            this.LlbPatientCode.Size = new System.Drawing.Size(272, 17);
            this.LlbPatientCode.TabIndex = 25;
            this.LlbPatientCode.Text = "Código (Proporcionado por hospital)";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(217, 203);
            this.LblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(0, 17);
            this.LblResult.TabIndex = 26;
            // 
            // TxtPatientCode
            // 
            this.TxtPatientCode.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPatientCode.Location = new System.Drawing.Point(275, 112);
            this.TxtPatientCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPatientCode.Name = "TxtPatientCode";
            this.TxtPatientCode.Size = new System.Drawing.Size(104, 20);
            this.TxtPatientCode.TabIndex = 27;
            // 
            // TxtPatientNumber
            // 
            this.TxtPatientNumber.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPatientNumber.Location = new System.Drawing.Point(263, 58);
            this.TxtPatientNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPatientNumber.Name = "TxtPatientNumber";
            this.TxtPatientNumber.Size = new System.Drawing.Size(152, 20);
            this.TxtPatientNumber.TabIndex = 28;
            // 
            // StatusOfPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TxtPatientNumber);
            this.Controls.Add(this.TxtPatientCode);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LlbPatientCode);
            this.Controls.Add(this.LblPatientNumber);
            this.Controls.Add(this.LblPatientStatus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StatusOfPatient";
            this.Text = "StatusOfPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPatientStatus;
        private System.Windows.Forms.Label LblPatientNumber;
        private System.Windows.Forms.Label LlbPatientCode;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxtPatientCode;
        private System.Windows.Forms.TextBox TxtPatientNumber;
    }
}