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
            this.LblPatientStatus = new System.Windows.Forms.Label();
            this.LblPatientCode = new System.Windows.Forms.Label();
            this.LblPatientEsattus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblPatientStatus
            // 
            this.LblPatientStatus.AutoSize = true;
            this.LblPatientStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientStatus.Location = new System.Drawing.Point(222, 57);
            this.LblPatientStatus.Name = "LblPatientStatus";
            this.LblPatientStatus.Size = new System.Drawing.Size(353, 39);
            this.LblPatientStatus.TabIndex = 0;
            this.LblPatientStatus.Text = "Estatus del Paciente";
            // 
            // LblPatientCode
            // 
            this.LblPatientCode.AutoSize = true;
            this.LblPatientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientCode.Location = new System.Drawing.Point(209, 161);
            this.LblPatientCode.Name = "LblPatientCode";
            this.LblPatientCode.Size = new System.Drawing.Size(169, 20);
            this.LblPatientCode.TabIndex = 1;
            this.LblPatientCode.Text = "Código del Paciente";
            // 
            // LblPatientEsattus
            // 
            this.LblPatientEsattus.AutoSize = true;
            this.LblPatientEsattus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientEsattus.Location = new System.Drawing.Point(209, 236);
            this.LblPatientEsattus.Name = "LblPatientEsattus";
            this.LblPatientEsattus.Size = new System.Drawing.Size(175, 20);
            this.LblPatientEsattus.TabIndex = 2;
            this.LblPatientEsattus.Text = "Estatus del Paciente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(797, 518);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblPatientEsattus);
            this.Controls.Add(this.LblPatientCode);
            this.Controls.Add(this.LblPatientStatus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPatientStatus;
        private System.Windows.Forms.Label LblPatientCode;
        private System.Windows.Forms.Label LblPatientEsattus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

