'Set up options statements

Option Strict On
Option Explicit On
Option Infer Off

'Set up parent class Department .

Public MustInherit Class Department

    'Start declaring variables .

    Protected _Name As String
    Protected _NumMales As Integer
    Protected _NumFemales As Integer
    Protected _Equality As String
    Protected _percentage As Double
    Protected _Response As String
    Protected _Employees() As Employee



    Public Sub New()

    End Sub

    'start setting property methods
    Public Property Equality As String
        Get
            Return _Equality
        End Get
        Set(value As String)
            _Equality = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property NumMales As Integer
        Get
            Return _NumMales
        End Get
        Set(value As Integer)
            _NumMales = value
        End Set
    End Property

    Public Property NumFemales As Integer
        Get
            Return _NumFemales
        End Get
        Set(value As Integer)
            _NumFemales = value
        End Set
    End Property

    Public Property Response As String
        Get
            Return _Response
        End Get
        Set(value As String)
            _Response = value
        End Set
    End Property

    ' Start setting up methods methods

    'add employee for the user onterface
    Public Sub addEmployee(name As String, gender As String, age As Integer, index As Integer)
        _Employees(index) = New Employee(name, gender, age)
    End Sub

    'set up must overidde functions

    Public MustOverride Function CalcEquality() As String

    Public MustOverride Function DetermineMsg() As String

End Class