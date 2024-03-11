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
            this.LblPatientStatus.Location = new System.Drawing.Point(29, 9);
            this.LblPatientStatus.Name = "LblPatientStatus";
            this.LblPatientStatus.Size = new System.Drawing.Size(183, 20);
            this.LblPatientStatus.TabIndex = 23;
            this.LblPatientStatus.Text = "Estatus del Paciente";
            // 
            // LblPatientNumber
            // 
            this.LblPatientNumber.AutoSize = true;
            this.LblPatientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientNumber.Location = new System.Drawing.Point(29, 71);
            this.LblPatientNumber.Name = "LblPatientNumber";
            this.LblPatientNumber.Size = new System.Drawing.Size(277, 20);
            this.LblPatientNumber.TabIndex = 24;
            this.LblPatientNumber.Text = "Número de Control del Paciente";
            // 
            // LlbPatientCode
            // 
            this.LlbPatientCode.AutoSize = true;
            this.LlbPatientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlbPatientCode.Location = new System.Drawing.Point(29, 138);
            this.LlbPatientCode.Name = "LlbPatientCode";
            this.LlbPatientCode.Size = new System.Drawing.Size(313, 20);
            this.LlbPatientCode.TabIndex = 25;
            this.LlbPatientCode.Text = "Código (Proporcionado por hospital)";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(289, 250);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(0, 20);
            this.LblResult.TabIndex = 26;
            // 
            // TxtPatientCode
            // 
            this.TxtPatientCode.Location = new System.Drawing.Point(367, 138);
            this.TxtPatientCode.Name = "TxtPatientCode";
            this.TxtPatientCode.Size = new System.Drawing.Size(137, 22);
            this.TxtPatientCode.TabIndex = 27;
            // 
            // TxtPatientNumber
            // 
            this.TxtPatientNumber.Location = new System.Drawing.Point(351, 71);
            this.TxtPatientNumber.Name = "TxtPatientNumber";
            this.TxtPatientNumber.Size = new System.Drawing.Size(202, 22);
            this.TxtPatientNumber.TabIndex = 28;
            // 
            // StatusOfPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPatientNumber);
            this.Controls.Add(this.TxtPatientCode);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LlbPatientCode);
            this.Controls.Add(this.LblPatientNumber);
            this.Controls.Add(this.LblPatientStatus);
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