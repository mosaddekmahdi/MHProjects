
Public Class FrmMain

    ' Button's click event btnAdd
    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        ' I declare a new instance of the class PhoneBookContext
        Using pnctx As New PhoneBookContext
            ' I declare a new instance of the class Person
            Dim NewPerson As New Person()
            ' Enhance the name field of the Person class with the contents of txtName
            NewPerson.NAME = Me.txtName.Text
            ' Enhance the surname field of the Person class with the contents of txtSurName
            NewPerson.SURNAME = Me.txtSurname.Text
            ' Enhance the telephonenumber field of the Person class with the contents of txtTelephoneNumber
            NewPerson.TELEPHONENUMBER = Me.txtTelephoneNumber.Text
            ' Enhance the mobile field of the Person class with the contents of txtMobile
            NewPerson.MOBILE = Me.txtMobile.Text
            ' Adds the given entity to the context the Added state. 
            'When the changes are being saved, the entities in the Added states are inserted into the database. 
            'After the changes are saved, the object state changes to Unchanged.
            pnctx.Persons.Add(NewPerson)

            ' Iterates to check the validation of input data in the database, 
            'in case of validation errors will be displayed to the user a message or invalid fields.
            For Each validationResult As DbEntityValidationResult In pnctx.GetValidationErrors()
                For Each validationerror As DbValidationError In validationResult.ValidationErrors
                    MessageBox.Show(validationerror.PropertyName + ":" & validationerror.ErrorMessage.ToString())
                    ' go to exit label
                    GoTo [exit]
                Next
            Next

            ' Saves all changes made in this context, to the underlying in database
            pnctx.SaveChanges()
[exit]:

            ' exit label


        End Using
    End Sub

    ' Button's click event btnFind
    Private Sub btnFind_Click(sender As Object, e As EventArgs)
        ' Clear all rows the dgvPerson
        Me.dgvPerson.Rows.Clear()

        ' I declare a new instance of the class PhoneBookContext
        Using ctx As New PhoneBookContext()
            ' I declare a new instance of the class FindPerson
            Dim person As New FindPerson()
            If True Then
                ' and true if checkbox rbName
                If rbName.Checked.Equals(True) Then
                    ' Cheque by reference to the function result dgvPerson DetailPerson depending on the type of research performed
                    Me.dgvPerson = person.DetailPerson(ctx, Me.rbName.Checked, Me.txtFind.Text, "NAME", Me.dgvPerson)
                End If

                ' and true if checkbox rbSurname
                If rbSurname.Checked.Equals(True) Then
                    ' Cheque by reference to the function result dgvPerson DetailPerson depending on the type of research performed
                    Me.dgvPerson = person.DetailPerson(ctx, Me.rbSurname.Checked, Me.txtFind.Text, "SURNAME", Me.dgvPerson)
                End If

                ' and true if checkbox rbPhoneNumber
                If rbPhoneNumber.Checked.Equals(True) Then
                    ' Cheque by reference to the function result dgvPerson DetailPerson depending on the type of research performed
                    Me.dgvPerson = person.DetailPerson(ctx, Me.rbPhoneNumber.Checked, Me.txtFind.Text, "TELEPHONENUMBER", Me.dgvPerson)
                End If

                ' and true if checkbox rbMobile
                If rbMobile.Checked.Equals(True) Then
                    ' Cheque by reference to the function result dgvPerson DetailPerson depending on the type of research performed
                    Me.dgvPerson = person.DetailPerson(ctx, Me.rbMobile.Checked, Me.txtFind.Text, "MOBILE", Me.dgvPerson)
                End If
            End If
        End Using
    End Sub

    Private Sub btnAdd_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub gbxDetail_Enter(sender As System.Object, e As System.EventArgs) Handles gbxDetail.Enter

    End Sub
End Class
