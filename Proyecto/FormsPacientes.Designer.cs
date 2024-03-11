namespace Proyecto
{
    partial class FrmPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatient));
            this.LblName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.LblMaritalStatus = new System.Windows.Forms.Label();
            this.CmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.LblCountry = new System.Windows.Forms.Label();
            this.CmbCountry = new System.Windows.Forms.ComboBox();
            this.LblState = new System.Windows.Forms.Label();
            this.CmbState = new System.Windows.Forms.ComboBox();
            this.LblMunicipality = new System.Windows.Forms.Label();
            this.TxtMunicipality = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblWeight = new System.Windows.Forms.Label();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.LblSocialSecurityNumber = new System.Windows.Forms.Label();
            this.LblZipCode = new System.Windows.Forms.Label();
            this.TxtZipCode = new System.Windows.Forms.TextBox();
            this.TxtSocialSecurityNumber = new System.Windows.Forms.TextBox();
            this.LblCurp = new System.Windows.Forms.Label();
            this.TxtCurp = new System.Windows.Forms.TextBox();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.LblBirthPlace = new System.Windows.Forms.Label();
            this.TxtBirthPlace = new System.Windows.Forms.TextBox();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.BttSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Location = new System.Drawing.Point(9, 19);
            this.LblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtFirstName.Location = new System.Drawing.Point(56, 16);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFirstName.MaxLength = 25;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(76, 20);
            this.TxtFirstName.TabIndex = 1;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.BackColor = System.Drawing.Color.Transparent;
            this.LblLastName.Location = new System.Drawing.Point(9, 46);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(44, 13);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "Apellido";
            // 
            // TxtLastName
            // 
            this.TxtLastName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtLastName.Location = new System.Drawing.Point(56, 43);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtLastName.MaxLength = 25;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(76, 20);
            this.TxtLastName.TabIndex = 3;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.BackColor = System.Drawing.Color.Transparent;
            this.LblGender.Location = new System.Drawing.Point(9, 72);
            this.LblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(42, 13);
            this.LblGender.TabIndex = 4;
            this.LblGender.Text = "Género";
            // 
            // CmbGender
            // 
            this.CmbGender.BackColor = System.Drawing.SystemColors.Info;
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.CmbGender.Location = new System.Drawing.Point(52, 70);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(92, 21);
            this.CmbGender.TabIndex = 5;
            // 
            // LblMaritalStatus
            // 
            this.LblMaritalStatus.AutoSize = true;
            this.LblMaritalStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblMaritalStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblMaritalStatus.Location = new System.Drawing.Point(9, 100);
            this.LblMaritalStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMaritalStatus.Name = "LblMaritalStatus";
            this.LblMaritalStatus.Size = new System.Drawing.Size(61, 13);
            this.LblMaritalStatus.TabIndex = 6;
            this.LblMaritalStatus.Text = "Estado civil";
            // 
            // CmbMaritalStatus
            // 
            this.CmbMaritalStatus.BackColor = System.Drawing.SystemColors.Info;
            this.CmbMaritalStatus.FormattingEnabled = true;
            this.CmbMaritalStatus.Items.AddRange(new object[] {
            "Casado(a)",
            "Soltero(a)",
            "Divorciado(a)",
            "Viudo(a)"});
            this.CmbMaritalStatus.Location = new System.Drawing.Point(70, 98);
            this.CmbMaritalStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbMaritalStatus.Name = "CmbMaritalStatus";
            this.CmbMaritalStatus.Size = new System.Drawing.Size(92, 21);
            this.CmbMaritalStatus.TabIndex = 7;
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.BackColor = System.Drawing.Color.Transparent;
            this.LblCountry.Location = new System.Drawing.Point(9, 127);
            this.LblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(29, 13);
            this.LblCountry.TabIndex = 8;
            this.LblCountry.Text = "País";
            // 
            // CmbCountry
            // 
            this.CmbCountry.BackColor = System.Drawing.SystemColors.Info;
            this.CmbCountry.FormattingEnabled = true;
            this.CmbCountry.Items.AddRange(new object[] {
            "Argentina",
            "Bolivia",
            "Brasil",
            "Chile",
            "Colombia",
            "Costa Rica",
            "Cuba",
            "Ecuador",
            "El Salvador",
            "Guatemala",
            "Haití",
            "Honduras",
            "México",
            "Nicaragua",
            "Panamá",
            "Paraguay",
            "Perú",
            "República Dominicana",
            "Uruguay",
            "Venezuela",
            "Fuera de latinoamerica"});
            this.CmbCountry.Location = new System.Drawing.Point(39, 124);
            this.CmbCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbCountry.Name = "CmbCountry";
            this.CmbCountry.Size = new System.Drawing.Size(92, 21);
            this.CmbCountry.TabIndex = 9;
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.BackColor = System.Drawing.Color.Transparent;
            this.LblState.Location = new System.Drawing.Point(9, 155);
            this.LblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(40, 13);
            this.LblState.TabIndex = 10;
            this.LblState.Text = "Estado";
            // 
            // CmbState
            // 
            this.CmbState.BackColor = System.Drawing.SystemColors.Info;
            this.CmbState.FormattingEnabled = true;
            this.CmbState.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Coahuila de Zaragoza",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán de Ocampo",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz de Ignacio de la Llave",
            "Yucatán",
            "Zacatecas",
            "Fuera de la republica mexicana"});
            this.CmbState.Location = new System.Drawing.Point(51, 153);
            this.CmbState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(92, 21);
            this.CmbState.TabIndex = 11;
            // 
            // LblMunicipality
            // 
            this.LblMunicipality.AutoSize = true;
            this.LblMunicipality.BackColor = System.Drawing.Color.Transparent;
            this.LblMunicipality.Location = new System.Drawing.Point(9, 183);
            this.LblMunicipality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMunicipality.Name = "LblMunicipality";
            this.LblMunicipality.Size = new System.Drawing.Size(52, 13);
            this.LblMunicipality.TabIndex = 12;
            this.LblMunicipality.Text = "Municipio";
            // 
            // TxtMunicipality
            // 
            this.TxtMunicipality.BackColor = System.Drawing.SystemColors.Info;
            this.TxtMunicipality.Location = new System.Drawing.Point(62, 180);
            this.TxtMunicipality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMunicipality.MaxLength = 30;
            this.TxtMunicipality.Name = "TxtMunicipality";
            this.TxtMunicipality.Size = new System.Drawing.Size(101, 20);
            this.TxtMunicipality.TabIndex = 13;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.BackColor = System.Drawing.Color.Transparent;
            this.LblAddress.Location = new System.Drawing.Point(9, 210);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(52, 13);
            this.LblAddress.TabIndex = 14;
            this.LblAddress.Text = "Dirección";
            // 
            // TxtAddress
            // 
            this.TxtAddress.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAddress.Location = new System.Drawing.Point(62, 208);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtAddress.MaxLength = 95;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(101, 20);
            this.TxtAddress.TabIndex = 15;
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.BackColor = System.Drawing.Color.Transparent;
            this.LblWeight.Location = new System.Drawing.Point(9, 238);
            this.LblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(55, 13);
            this.LblWeight.TabIndex = 16;
            this.LblWeight.Text = "Peso (KG)";
            // 
            // TxtWeight
            // 
            this.TxtWeight.BackColor = System.Drawing.SystemColors.Info;
            this.TxtWeight.Location = new System.Drawing.Point(70, 238);
            this.TxtWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtWeight.MaxLength = 6;
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(38, 20);
            this.TxtWeight.TabIndex = 17;
            // 
            // LblSocialSecurityNumber
            // 
            this.LblSocialSecurityNumber.AutoSize = true;
            this.LblSocialSecurityNumber.BackColor = System.Drawing.Color.Transparent;
            this.LblSocialSecurityNumber.Location = new System.Drawing.Point(241, 43);
            this.LblSocialSecurityNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSocialSecurityNumber.Name = "LblSocialSecurityNumber";
            this.LblSocialSecurityNumber.Size = new System.Drawing.Size(124, 13);
            this.LblSocialSecurityNumber.TabIndex = 18;
            this.LblSocialSecurityNumber.Text = "Número de seguro social";
            this.LblSocialSecurityNumber.Click += new System.EventHandler(this.LblSocialSecurityNumber_Click);
            // 
            // LblZipCode
            // 
            this.LblZipCode.AutoSize = true;
            this.LblZipCode.BackColor = System.Drawing.Color.Transparent;
            this.LblZipCode.Location = new System.Drawing.Point(241, 19);
            this.LblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblZipCode.Name = "LblZipCode";
            this.LblZipCode.Size = new System.Drawing.Size(72, 13);
            this.LblZipCode.TabIndex = 19;
            this.LblZipCode.Text = "Código Postal";
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.BackColor = System.Drawing.SystemColors.Info;
            this.TxtZipCode.Location = new System.Drawing.Point(314, 16);
            this.TxtZipCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtZipCode.MaxLength = 5;
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(76, 20);
            this.TxtZipCode.TabIndex = 20;
            // 
            // TxtSocialSecurityNumber
            // 
            this.TxtSocialSecurityNumber.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSocialSecurityNumber.Location = new System.Drawing.Point(364, 43);
            this.TxtSocialSecurityNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSocialSecurityNumber.MaxLength = 11;
            this.TxtSocialSecurityNumber.Name = "TxtSocialSecurityNumber";
            this.TxtSocialSecurityNumber.Size = new System.Drawing.Size(93, 20);
            this.TxtSocialSecurityNumber.TabIndex = 21;
            // 
            // LblCurp
            // 
            this.LblCurp.AutoSize = true;
            this.LblCurp.BackColor = System.Drawing.Color.Transparent;
            this.LblCurp.Location = new System.Drawing.Point(241, 72);
            this.LblCurp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCurp.Name = "LblCurp";
            this.LblCurp.Size = new System.Drawing.Size(29, 13);
            this.LblCurp.TabIndex = 22;
            this.LblCurp.Text = "Curp";
            // 
            // TxtCurp
            // 
            this.TxtCurp.BackColor = System.Drawing.SystemColors.Info;
            this.TxtCurp.Location = new System.Drawing.Point(272, 70);
            this.TxtCurp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCurp.MaxLength = 18;
            this.TxtCurp.Name = "TxtCurp";
            this.TxtCurp.Size = new System.Drawing.Size(109, 20);
            this.TxtCurp.TabIndex = 23;
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.LblPhoneNumber.Location = new System.Drawing.Point(241, 100);
            this.LblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(100, 13);
            this.LblPhoneNumber.TabIndex = 24;
            this.LblPhoneNumber.Text = "Número de telefono";
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPhoneNumber.Location = new System.Drawing.Point(339, 98);
            this.TxtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPhoneNumber.MaxLength = 16;
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(118, 20);
            this.TxtPhoneNumber.TabIndex = 25;
            // 
            // LblBirthPlace
            // 
            this.LblBirthPlace.AutoSize = true;
            this.LblBirthPlace.BackColor = System.Drawing.Color.Transparent;
            this.LblBirthPlace.Location = new System.Drawing.Point(241, 127);
            this.LblBirthPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBirthPlace.Name = "LblBirthPlace";
            this.LblBirthPlace.Size = new System.Drawing.Size(103, 13);
            this.LblBirthPlace.TabIndex = 26;
            this.LblBirthPlace.Text = "Lugar de nacimiento";
            // 
            // TxtBirthPlace
            // 
            this.TxtBirthPlace.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBirthPlace.Location = new System.Drawing.Point(341, 124);
            this.TxtBirthPlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBirthPlace.MaxLength = 50;
            this.TxtBirthPlace.Name = "TxtBirthPlace";
            this.TxtBirthPlace.Size = new System.Drawing.Size(116, 20);
            this.TxtBirthPlace.TabIndex = 27;
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.LblBirthDate.Location = new System.Drawing.Point(241, 155);
            this.LblBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(106, 13);
            this.LblBirthDate.TabIndex = 28;
            this.LblBirthDate.Text = "Fecha de nacimiento";
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.DtpBirthDate.Location = new System.Drawing.Point(344, 151);
            this.DtpBirthDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(231, 20);
            this.DtpBirthDate.TabIndex = 29;
            this.DtpBirthDate.ValueChanged += new System.EventHandler(this.DtpBirthDate_ValueChanged);
            // 
            // BttSend
            // 
            this.BttSend.BackColor = System.Drawing.Color.Silver;
            this.BttSend.Location = new System.Drawing.Point(618, 371);
            this.BttSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BttSend.Name = "BttSend";
            this.BttSend.Size = new System.Drawing.Size(100, 23);
            this.BttSend.TabIndex = 30;
            this.BttSend.Text = "Enviar";
            this.BttSend.UseVisualStyleBackColor = false;
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 404);
            this.Controls.Add(this.BttSend);
            this.Controls.Add(this.DtpBirthDate);
            this.Controls.Add(this.LblBirthDate);
            this.Controls.Add(this.TxtBirthPlace);
            this.Controls.Add(this.LblBirthPlace);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.TxtCurp);
            this.Controls.Add(this.LblCurp);
            this.Controls.Add(this.TxtSocialSecurityNumber);
            this.Controls.Add(this.TxtZipCode);
            this.Controls.Add(this.LblZipCode);
            this.Controls.Add(this.LblSocialSecurityNumber);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.LblWeight);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.TxtMunicipality);
            this.Controls.Add(this.LblMunicipality);
            this.Controls.Add(this.CmbState);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.CmbCountry);
            this.Controls.Add(this.LblCountry);
            this.Controls.Add(this.CmbMaritalStatus);
            this.Controls.Add(this.LblMaritalStatus);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPatient";
            this.Text = "Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label LblMaritalStatus;
        private System.Windows.Forms.ComboBox CmbMaritalStatus;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.ComboBox CmbCountry;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.ComboBox CmbState;
        private System.Windows.Forms.Label LblMunicipality;
        private System.Windows.Forms.TextBox TxtMunicipality;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.Label LblSocialSecurityNumber;
        private System.Windows.Forms.Label LblZipCode;
        private System.Windows.Forms.TextBox TxtZipCode;
        private System.Windows.Forms.TextBox TxtSocialSecurityNumber;
        private System.Windows.Forms.Label LblCurp;
        private System.Windows.Forms.TextBox TxtCurp;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.Label LblBirthPlace;
        private System.Windows.Forms.TextBox TxtBirthPlace;
        private System.Windows.Forms.Label LblBirthDate;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.Button BttSend;
    }
}