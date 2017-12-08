' Import the framework of the Libraries
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.Entity

' PhoneBook project
Namespace PhoneBook
    ' class FindPerson
    Class FindPerson
        ' private field of type PhooneBookContext
        Private Property ctxFind() As PhoneBookContext
            Get
                Return m_ctxFind
            End Get
            Set(value As PhoneBookContext)
                m_ctxFind = Value
            End Set
        End Property
        Private m_ctxFind As PhoneBookContext
        ' private field of type bool
        Private Property Find() As Boolean
            Get
                Return m_Find
            End Get
            Set(value As Boolean)
                m_Find = Value
            End Set
        End Property
        Private m_Find As Boolean
        ' private field of type string
        Private Property Charater() As String
            Get
                Return m_Charater
            End Get
            Set(value As String)
                m_Charater = Value
            End Set
        End Property
        Private m_Charater As String
        ' private field of type DataGridView
        Private Property Data() As DataGridView
            Get
                Return m_Data
            End Get
            Set(value As DataGridView)
                m_Data = Value
            End Set
        End Property
        Private m_Data As DataGridView
        ' private field of type string
        Private Property TypeSearch() As String
            Get
                Return m_TypeSearch
            End Get
            Set(value As String)
                m_TypeSearch = Value
            End Set
        End Property
        Private m_TypeSearch As String

        ' LinqToEntities using search function, which returns a DataGridView control containing the search results
        Public Function DetailPerson(ctx As PhoneBookContext, Find As Boolean, charater As String, search As String, data As DataGridView) As DataGridView
            ' Enhance the private variables with the parameters of the function DetailPerson
            Me.ctxFind = ctx
            Me.Find = Find
            Me.Charater = charater
            Me.Data = data
            Me.TypeSearch = search

            ' I declare a new instance of the class PhoneBookContext
            Using ctxFind As New PhoneBookContext()
                ' if the variable find and true charater and the variable is not empty or null
                If Me.Find.Equals(True) AndAlso Not String.IsNullOrEmpty(Me.Charater) Then
                    ' if the value of the variable equal to TypeSearch NAME 
                    If Me.TypeSearch.Equals("NAME") Then
                        ' I run the query LinqToEntities extrapolating the data starting with a certain letter in the variable specified in the entity name charater
						Dim query = From c In ctx.Persons Where c.NAME.StartsWith(Me.Charater)c

                        ' I make the iteration variable in the variable query person
                        For Each person As var In query
                            ' I post all the occurrences found in the variable of type DataGridView Date
                            Me.Data.Rows.Add(person.NAME, person.SURNAME, person.TELEPHONENUMBER, person.MOBILE)
                        Next
                    End If

                    ' if the value of the variable equal to TypeSearch SURNAME 
                    If Me.TypeSearch.Equals("SURNAME") Then
                        ' I run the query LinqToEntities extrapolating the data starting with a certain letter in the variable specified in the entity name charater
						Dim query = From c In ctx.Persons Where c.SURNAME.StartsWith(Me.Charater)c

                        ' I make the iteration variable in the variable query person
                        For Each person As var In query
                            ' I post all the occurrences found in the variable of type DataGridView Date
                            Me.Data.Rows.Add(person.NAME, person.SURNAME, person.TELEPHONENUMBER, person.MOBILE)
                        Next
                    End If

                    ' if the value of the variable equal to TypeSearch TELEPHONENUMBER 
                    If Me.TypeSearch.Equals("TELEPHONENUMBER") Then
                        ' I run the query LinqToEntities extrapolating the data starting with a certain letter in the variable specified in the entity name charater
						Dim query = From c In ctx.Persons Where c.TELEPHONENUMBER.StartsWith(Me.Charater)c

                        ' I make the iteration variable in the variable query person
                        For Each person As var In query
                            ' I post all the occurrences found in the variable of type DataGridView Date
                            Me.Data.Rows.Add(person.NAME, person.SURNAME, person.TELEPHONENUMBER, person.MOBILE)
                        Next
                    End If

                    ' if the value of the variable equal to TypeSearch MOBILE
                    If Me.TypeSearch.Equals("MOBILE") Then
                        ' I run the query LinqToEntities extrapolating the data starting with a certain letter in the variable specified in the entity name charater
						Dim query = From c In ctx.Persons Where c.MOBILE.StartsWith(Me.Charater)c

                        ' I make the iteration variable in the variable query person
                        For Each person As var In query
                            ' I post all the occurrences found in the variable of type DataGridView Date
                            Me.Data.Rows.Add(person.NAME, person.SURNAME, person.TELEPHONENUMBER, person.MOBILE)
                        Next
                    End If
                Else

                    ' In case of missing parameters
                    ' Display message to user
                    MessageBox.Show("Insert a Name,SurName,TelephoneNumber or Mobile for Person", Application.ProductName.ToString())
                End If
            End Using

            ' Returns the result of the function
            Return Me.Data
        End Function
    End Class
End Namespace
