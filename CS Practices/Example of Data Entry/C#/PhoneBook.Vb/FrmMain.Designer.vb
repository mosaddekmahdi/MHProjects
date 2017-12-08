<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.rbPhoneNumber = New System.Windows.Forms.RadioButton()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.rbMobile = New System.Windows.Forms.RadioButton()
        Me.rbName = New System.Windows.Forms.RadioButton()
        Me.PHONENUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbSurname = New System.Windows.Forms.RadioButton()
        Me.gbxDetail = New System.Windows.Forms.GroupBox()
        Me.dgvPerson = New System.Windows.Forms.DataGridView()
        Me.NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SURNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gpbNewPerson = New System.Windows.Forms.GroupBox()
        Me.gbxDetail.SuspendLayout()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbNewPerson.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(88, 255)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(137, 20)
        Me.txtFind.TabIndex = 36
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(7, 253)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 31
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'rbPhoneNumber
        '
        Me.rbPhoneNumber.AutoSize = True
        Me.rbPhoneNumber.Location = New System.Drawing.Point(146, 185)
        Me.rbPhoneNumber.Name = "rbPhoneNumber"
        Me.rbPhoneNumber.Size = New System.Drawing.Size(116, 17)
        Me.rbPhoneNumber.TabIndex = 34
        Me.rbPhoneNumber.TabStop = True
        Me.rbPhoneNumber.Text = "Find PhoneNumber"
        Me.rbPhoneNumber.UseVisualStyleBackColor = True
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(16, 177)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblMobile.TabIndex = 29
        Me.lblMobile.Text = "Mobile"
        '
        'rbMobile
        '
        Me.rbMobile.AutoSize = True
        Me.rbMobile.Location = New System.Drawing.Point(146, 218)
        Me.rbMobile.Name = "rbMobile"
        Me.rbMobile.Size = New System.Drawing.Size(79, 17)
        Me.rbMobile.TabIndex = 35
        Me.rbMobile.TabStop = True
        Me.rbMobile.Text = "Find Mobile"
        Me.rbMobile.UseVisualStyleBackColor = True
        '
        'rbName
        '
        Me.rbName.AutoSize = True
        Me.rbName.Location = New System.Drawing.Point(6, 185)
        Me.rbName.Name = "rbName"
        Me.rbName.Size = New System.Drawing.Size(76, 17)
        Me.rbName.TabIndex = 32
        Me.rbName.TabStop = True
        Me.rbName.Text = "Find Name"
        Me.rbName.UseVisualStyleBackColor = True
        '
        'PHONENUMBER
        '
        Me.PHONENUMBER.HeaderText = "PHONE NUMBER"
        Me.PHONENUMBER.Name = "PHONENUMBER"
        '
        'rbSurname
        '
        Me.rbSurname.AutoSize = True
        Me.rbSurname.Location = New System.Drawing.Point(6, 218)
        Me.rbSurname.Name = "rbSurname"
        Me.rbSurname.Size = New System.Drawing.Size(92, 17)
        Me.rbSurname.TabIndex = 33
        Me.rbSurname.TabStop = True
        Me.rbSurname.Text = "Find SurName"
        Me.rbSurname.UseVisualStyleBackColor = True
        '
        'gbxDetail
        '
        Me.gbxDetail.Controls.Add(Me.dgvPerson)
        Me.gbxDetail.Controls.Add(Me.txtFind)
        Me.gbxDetail.Controls.Add(Me.btnFind)
        Me.gbxDetail.Controls.Add(Me.rbPhoneNumber)
        Me.gbxDetail.Controls.Add(Me.rbMobile)
        Me.gbxDetail.Controls.Add(Me.rbName)
        Me.gbxDetail.Controls.Add(Me.rbSurname)
        Me.gbxDetail.Location = New System.Drawing.Point(351, 20)
        Me.gbxDetail.Name = "gbxDetail"
        Me.gbxDetail.Size = New System.Drawing.Size(455, 295)
        Me.gbxDetail.TabIndex = 39
        Me.gbxDetail.TabStop = False
        Me.gbxDetail.Text = "Detail"
        '
        'dgvPerson
        '
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAME, Me.SURNAME, Me.PHONENUMBER})
        Me.dgvPerson.Location = New System.Drawing.Point(6, 19)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.Size = New System.Drawing.Size(443, 150)
        Me.dgvPerson.TabIndex = 30
        '
        'NAME
        '
        Me.NAME.HeaderText = "NAME"
        Me.NAME.Name = "NAME"
        '
        'SURNAME
        '
        Me.SURNAME.HeaderText = "SURNAME"
        Me.SURNAME.Name = "SURNAME"
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(104, 148)
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(204, 20)
        Me.txtTelephoneNumber.TabIndex = 23
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(17, 31)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(104, 96)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(204, 20)
        Me.txtName.TabIndex = 21
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(16, 151)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(58, 13)
        Me.lblTelephone.TabIndex = 28
        Me.lblTelephone.Text = "Telephone"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(104, 122)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(204, 20)
        Me.txtSurname.TabIndex = 22
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(16, 125)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 27
        Me.lblSurname.Text = "Surname"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(104, 174)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(204, 20)
        Me.txtMobile.TabIndex = 24
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(16, 99)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "Name"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(104, 31)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gpbNewPerson
        '
        Me.gpbNewPerson.Controls.Add(Me.txtTelephoneNumber)
        Me.gpbNewPerson.Controls.Add(Me.btnAdd)
        Me.gpbNewPerson.Controls.Add(Me.lblMobile)
        Me.gpbNewPerson.Controls.Add(Me.txtName)
        Me.gpbNewPerson.Controls.Add(Me.lblTelephone)
        Me.gpbNewPerson.Controls.Add(Me.txtSurname)
        Me.gpbNewPerson.Controls.Add(Me.lblSurname)
        Me.gpbNewPerson.Controls.Add(Me.txtMobile)
        Me.gpbNewPerson.Controls.Add(Me.lblName)
        Me.gpbNewPerson.Controls.Add(Me.btnExit)
        Me.gpbNewPerson.Location = New System.Drawing.Point(11, 20)
        Me.gpbNewPerson.Name = "gpbNewPerson"
        Me.gpbNewPerson.Size = New System.Drawing.Size(334, 227)
        Me.gpbNewPerson.TabIndex = 40
        Me.gpbNewPerson.TabStop = False
        Me.gpbNewPerson.Text = "New Person"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 335)
        Me.Controls.Add(Me.gbxDetail)
        Me.Controls.Add(Me.gpbNewPerson)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gbxDetail.ResumeLayout(False)
        Me.gbxDetail.PerformLayout()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbNewPerson.ResumeLayout(False)
        Me.gpbNewPerson.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents MOBILE As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents txtFind As System.Windows.Forms.TextBox
    Private WithEvents btnFind As System.Windows.Forms.Button
    Private WithEvents rbPhoneNumber As System.Windows.Forms.RadioButton
    Private WithEvents lblMobile As System.Windows.Forms.Label
    Private WithEvents rbMobile As System.Windows.Forms.RadioButton
    Private WithEvents rbName As System.Windows.Forms.RadioButton
    Private WithEvents PHONENUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents rbSurname As System.Windows.Forms.RadioButton
    Private WithEvents gbxDetail As System.Windows.Forms.GroupBox
    Private WithEvents dgvPerson As System.Windows.Forms.DataGridView
    Private WithEvents NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents SURNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents txtTelephoneNumber As System.Windows.Forms.TextBox
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents lblTelephone As System.Windows.Forms.Label
    Private WithEvents txtSurname As System.Windows.Forms.TextBox
    Private WithEvents lblSurname As System.Windows.Forms.Label
    Private WithEvents txtMobile As System.Windows.Forms.TextBox
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents gpbNewPerson As System.Windows.Forms.GroupBox

End Class
