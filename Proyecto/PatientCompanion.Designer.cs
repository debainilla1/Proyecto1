namespace Proyecto
{
    partial class PatientCompanion
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblCellPhoneNumber = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtCellPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.LblPatientCompanion = new System.Windows.Forms.Label();
            this.BttSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(181, 117);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(79, 22);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.BackColor = System.Drawing.Color.Transparent;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(181, 163);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(92, 22);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Apellidos";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.LblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoneNumber.Location = new System.Drawing.Point(181, 210);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(172, 22);
            this.LblPhoneNumber.TabIndex = 2;
            this.LblPhoneNumber.Text = "Número telefónico";
            // 
            // LblCellPhoneNumber
            // 
            this.LblCellPhoneNumber.AutoSize = true;
            this.LblCellPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.LblCellPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCellPhoneNumber.Location = new System.Drawing.Point(181, 260);
            this.LblCellPhoneNumber.Name = "LblCellPhoneNumber";
            this.LblCellPhoneNumber.Size = new System.Drawing.Size(173, 22);
            this.LblCellPhoneNumber.TabIndex = 3;
            this.LblCellPhoneNumber.Text = "Número de celular";
            this.LblCellPhoneNumber.Click += new System.EventHandler(this.LblCellPhoneNumber_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(181, 308);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(59, 22);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.BackColor = System.Drawing.Color.Transparent;
            this.LblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAge.Location = new System.Drawing.Point(181, 352);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(56, 22);
            this.LblAge.TabIndex = 5;
            this.LblAge.Text = "Edad";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.BackColor = System.Drawing.Color.Transparent;
            this.LblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.Location = new System.Drawing.Point(181, 396);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(76, 22);
            this.LblGender.TabIndex = 6;
            this.LblGender.Text = "Género";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.LemonChiffon;
            this.TxtName.Location = new System.Drawing.Point(385, 117);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(357, 22);
            this.TxtName.TabIndex = 7;
            // 
            // TxtLastName
            // 
            this.TxtLastName.BackColor = System.Drawing.Color.LemonChiffon;
            this.TxtLastName.Location = new System.Drawing.Point(385, 163);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(357, 22);
            this.TxtLastName.TabIndex = 8;
            // 
            // TxtCellPhoneNumber
            // 
            this.TxtCellPhoneNumber.BackColor = System.Drawing.Color.LemonChiffon;
            this.TxtCellPhoneNumber.Location = new System.Drawing.Point(386, 260);
            this.TxtCellPhoneNumber.Name = "TxtCellPhoneNumber";
            this.TxtCellPhoneNumber.Size = new System.Drawing.Size(357, 22);
            this.TxtCellPhoneNumber.TabIndex = 9;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.BackColor = System.Drawing.Color.LemonChiffon;
            this.TxtPhoneNumber.Location = new System.Drawing.Point(385, 210);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(357, 22);
            this.TxtPhoneNumber.TabIndex = 10;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.LemonChiffon;
            this.TxtEmail.Location = new System.Drawing.Point(386, 308);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(357, 22);
            this.TxtEmail.TabIndex = 11;
            // 
            // TxtAge
            // 
            this.TxtAge.BackColor = System.Drawing.Color.LemonChiffon;
            this.TxtAge.Location = new System.Drawing.Point(386, 352);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(357, 22);
            this.TxtAge.TabIndex = 12;
            // 
            // TxtGender
            // 
            this.TxtGender.BackColor = System.Drawing.Color.LemonChiffon;
            this.TxtGender.Location = new System.Drawing.Point(386, 396);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(357, 22);
            this.TxtGender.TabIndex = 13;
            // 
            // LblPatientCompanion
            // 
            this.LblPatientCompanion.AutoSize = true;
            this.LblPatientCompanion.BackColor = System.Drawing.Color.Transparent;
            this.LblPatientCompanion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientCompanion.Location = new System.Drawing.Point(270, 35);
            this.LblPatientCompanion.Name = "LblPatientCompanion";
            this.LblPatientCompanion.Size = new System.Drawing.Size(396, 29);
            this.LblPatientCompanion.TabIndex = 14;
            this.LblPatientCompanion.Text = "Acompañante Legal del Paciente";
            this.LblPatientCompanion.Click += new System.EventHandler(this.label1_Click);
            // 
            // BttSend
            // 
            this.BttSend.BackColor = System.Drawing.Color.Silver;
            this.BttSend.Location = new System.Drawing.Point(689, 472);
            this.BttSend.Name = "BttSend";
            this.BttSend.Size = new System.Drawing.Size(133, 28);
            this.BttSend.TabIndex = 31;
            this.BttSend.Text = "Enviar";
            this.BttSend.UseVisualStyleBackColor = false;
            // 
            // PatientCompanion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(985, 585);
            this.Controls.Add(this.BttSend);
            this.Controls.Add(this.LblPatientCompanion);
            this.Controls.Add(this.TxtGender);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.TxtCellPhoneNumber);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCellPhoneNumber);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.Name = "PatientCompanion";
            this.Text = "PatientCompanion";
            this.Load += new System.EventHandler(this.PatientCompanion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.Label LblCellPhoneNumber;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtCellPhoneNumber;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtGender;
        private System.Windows.Forms.Label LblPatientCompanion;
        private System.Windows.Forms.Button BttSend;
    }
}