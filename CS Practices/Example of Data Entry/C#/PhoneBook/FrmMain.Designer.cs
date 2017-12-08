namespace PhoneBook
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONENUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOBILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new System.Windows.Forms.Button();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbSurname = new System.Windows.Forms.RadioButton();
            this.rbPhoneNumber = new System.Windows.Forms.RadioButton();
            this.rbMobile = new System.Windows.Forms.RadioButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.gpbNewPerson = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.gbxDetail.SuspendLayout();
            this.gpbNewPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(16, 177);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(38, 13);
            this.lblMobile.TabIndex = 29;
            this.lblMobile.Text = "Mobile";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(16, 151);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 28;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(16, 125);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 27;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(104, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(104, 174);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(204, 20);
            this.txtMobile.TabIndex = 24;
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(104, 148);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(204, 20);
            this.txtTelephoneNumber.TabIndex = 23;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(104, 122);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(204, 20);
            this.txtSurname.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPerson
            // 
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.SURNAME,
            this.PHONENUMBER,
            this.MOBILE});
            this.dgvPerson.Location = new System.Drawing.Point(6, 19);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.Size = new System.Drawing.Size(443, 150);
            this.dgvPerson.TabIndex = 30;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.Name = "NAME";
            // 
            // SURNAME
            // 
            this.SURNAME.HeaderText = "SURNAME";
            this.SURNAME.Name = "SURNAME";
            // 
            // PHONENUMBER
            // 
            this.PHONENUMBER.HeaderText = "PHONE NUMBER";
            this.PHONENUMBER.Name = "PHONENUMBER";
            // 
            // MOBILE
            // 
            this.MOBILE.HeaderText = "MOBILE";
            this.MOBILE.Name = "MOBILE";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(7, 253);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 31;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(6, 185);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(76, 17);
            this.rbName.TabIndex = 32;
            this.rbName.TabStop = true;
            this.rbName.Text = "Find Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbSurname
            // 
            this.rbSurname.AutoSize = true;
            this.rbSurname.Location = new System.Drawing.Point(6, 218);
            this.rbSurname.Name = "rbSurname";
            this.rbSurname.Size = new System.Drawing.Size(92, 17);
            this.rbSurname.TabIndex = 33;
            this.rbSurname.TabStop = true;
            this.rbSurname.Text = "Find SurName";
            this.rbSurname.UseVisualStyleBackColor = true;
            // 
            // rbPhoneNumber
            // 
            this.rbPhoneNumber.AutoSize = true;
            this.rbPhoneNumber.Location = new System.Drawing.Point(146, 185);
            this.rbPhoneNumber.Name = "rbPhoneNumber";
            this.rbPhoneNumber.Size = new System.Drawing.Size(116, 17);
            this.rbPhoneNumber.TabIndex = 34;
            this.rbPhoneNumber.TabStop = true;
            this.rbPhoneNumber.Text = "Find PhoneNumber";
            this.rbPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // rbMobile
            // 
            this.rbMobile.AutoSize = true;
            this.rbMobile.Location = new System.Drawing.Point(146, 218);
            this.rbMobile.Name = "rbMobile";
            this.rbMobile.Size = new System.Drawing.Size(79, 17);
            this.rbMobile.TabIndex = 35;
            this.rbMobile.TabStop = true;
            this.rbMobile.Text = "Find Mobile";
            this.rbMobile.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(88, 255);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(137, 20);
            this.txtFind.TabIndex = 36;
            // 
            // gbxDetail
            // 
            this.gbxDetail.Controls.Add(this.dgvPerson);
            this.gbxDetail.Controls.Add(this.txtFind);
            this.gbxDetail.Controls.Add(this.btnFind);
            this.gbxDetail.Controls.Add(this.rbPhoneNumber);
            this.gbxDetail.Controls.Add(this.rbMobile);
            this.gbxDetail.Controls.Add(this.rbName);
            this.gbxDetail.Controls.Add(this.rbSurname);
            this.gbxDetail.Location = new System.Drawing.Point(352, 29);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(455, 295);
            this.gbxDetail.TabIndex = 37;
            this.gbxDetail.TabStop = false;
            this.gbxDetail.Text = "Detail";
            // 
            // gpbNewPerson
            // 
            this.gpbNewPerson.Controls.Add(this.txtTelephoneNumber);
            this.gpbNewPerson.Controls.Add(this.btnAdd);
            this.gpbNewPerson.Controls.Add(this.lblMobile);
            this.gpbNewPerson.Controls.Add(this.txtName);
            this.gpbNewPerson.Controls.Add(this.lblTelephone);
            this.gpbNewPerson.Controls.Add(this.txtSurname);
            this.gpbNewPerson.Controls.Add(this.lblSurname);
            this.gpbNewPerson.Controls.Add(this.txtMobile);
            this.gpbNewPerson.Controls.Add(this.lblName);
            this.gpbNewPerson.Controls.Add(this.btnExit);
            this.gpbNewPerson.Location = new System.Drawing.Point(12, 29);
            this.gpbNewPerson.Name = "gpbNewPerson";
            this.gpbNewPerson.Size = new System.Drawing.Size(334, 227);
            this.gpbNewPerson.TabIndex = 38;
            this.gpbNewPerson.TabStop = false;
            this.gpbNewPerson.Text = "New Person";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 335);
            this.Controls.Add(this.gpbNewPerson);
            this.Controls.Add(this.gbxDetail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.gbxDetail.ResumeLayout(false);
            this.gbxDetail.PerformLayout();
            this.gpbNewPerson.ResumeLayout(false);
            this.gpbNewPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONENUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOBILE;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbSurname;
        private System.Windows.Forms.RadioButton rbPhoneNumber;
        private System.Windows.Forms.RadioButton rbMobile;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.GroupBox gbxDetail;
        private System.Windows.Forms.GroupBox gpbNewPerson;
    }
}

