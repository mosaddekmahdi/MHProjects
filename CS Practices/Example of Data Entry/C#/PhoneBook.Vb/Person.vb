Imports System.ComponentModel.DataAnnotations

Public Class Person
    ' private field of type int
    Private _ID As Integer
    Private _NAME As String
    Private _SURNAME As String
    Private _TELEPHONENUMBER As String
    Private _MOBILE As String


    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    ' This attribute specifies the field below is required that can not be null or empty
    ' private field of type string
    <Required()> _
    Public Property NAME() As String
        Get
            Return _NAME

        End Get
        Set(value As String)
            _NAME = value
        End Set
    End Property

    ' This attribute specifies the field below is required that can not be null or empty
    ' private field of type string
    <Required()> _
    Public Property SURNAME() As String
        Get
            Return _SURNAME
        End Get
        Set(value As String)
            _SURNAME = value
        End Set
    End Property

    ' This attribute specifies the field below is required that can not be null or empty
    ' private field of type string
    <Required()> _
    Public Property TELEPHONENUMBER() As String
        Get
            Return _TELEPHONENUMBER
        End Get
        Set(value As String)
            _TELEPHONENUMBER = value
        End Set
    End Property

    ' This attribute specifies the field below is required that can not be null or empty
    ' private field of type string
    <Required()> _
    Public Property MOBILE() As String
        Get
            Return _MOBILE
        End Get
        Set(value As String)
            _MOBILE = value
        End Set
    End Property
End Class
