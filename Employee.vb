'Set up options statements

Option Strict On
Option Explicit On
Option Infer Off

'Name an abstract employee class . 

Public Class Employee

    Private _Name As String
    Private _Gender As String
    Private _Age As Integer

    'constructor
    Public Sub New(name As String, gender As String, age As Integer)
        _Name = name
        _Gender = gender
        _Age = age
    End Sub
End Class
