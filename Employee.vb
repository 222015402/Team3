' *****************************************************************
' Team Number: 3
' Team Member 1 Details: Masimba, RT (222015402)
' Team Member 2 Details: Ndlovu, LF (221078299)
' Team Member 3 Details: Hoaeane, K (218105185)
' Team Member 4 Details: Sondezi, N (218000317)
' Practical: Team Project
' Class name: (Employee)
' *****************************************************************
'Set up options statements
Option Strict On
Option Explicit On
Option Infer Off

'Name an abstract employee class . 
Public Class Employee
    Private _Name As String
    Private _Gender As String
    Private _Age As Integer
    'property method for name 
    Public Property name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property
    'property method for gender 
    Public Property gender As String
        Get
            Return _Gender
        End Get
        Set(value As String)
            _Gender = value
        End Set
    End Property
    'property method for age 
    Public Property age As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            _Age = value
        End Set
    End Property

    'constructor
    Public Sub New(name As String, gender As String, age As Integer)
        _Name = name
        _Gender = gender
        _Age = age
    End Sub
End Class
