' *****************************************************************
' Team Number: 3
' Team Member 1 Details: Masimba, RT (222015402)
' Team Member 2 Details: Ndlovu, LF (221078299)
' Team Member 3 Details: Hoaeane, K (218105185)
' Team Member 4 Details: Sondezi, N (218000317)
' Practical: Team Project
' Class name: (Stem)
' *****************************************************************
'Set up options statements

Option Strict On
Option Explicit On
Option Infer Off
Public Class Stem

    Inherits Department
    Private _Location As String
    Private _MinWomen As Double


    'constructor
    Public Sub New(name As String, numfemales As Integer, nummales As Integer, total As Integer)
        _Name = name
        _NumFemales = numfemales
        _NumMales = nummales
        _MinWomen = 40
        ReDim _Employees(total)
    End Sub

    'propery methods
    Public Property Location As String
        Get
            Return _Location
        End Get
        Set(value As String)
            _Location = value
        End Set
    End Property

    Public Property MinWomen As Double
        Get
            Return _MinWomen
        End Get
        Set(value As Double)
            _MinWomen = value
        End Set
    End Property

    Public Overrides Function CalcEquality() As String
        'calculate % of women
        _percentage = (_NumFemales / (_NumMales + NumFemales)) * 100
        If _percentage >= MinWomen And _percentage <= MinWomen + 20 Then
            _Equality = "Yes"
        Else
            _Equality = "No"
        End If
        Return _Equality
    End Function

    Public Overrides Function DetermineMsg() As String
        Dim toAdd As Double

        If _Equality = "Yes" Then
            _Response = "There is equality in the department"
        Else
            'calculate value to create balance
            If _percentage < MinWomen Then
                toAdd = (MinWomen / 100) * (_NumFemales + _NumMales)
                toAdd -= _NumFemales
                toAdd = Math.Ceiling(toAdd)
                _Response = "There is no equalty, we need " + CStr(toAdd) + " more women"
            ElseIf _percentage > MinWomen + 20 Then
                toAdd = ((MinWomen + 20) / 100) * (_NumFemales + _NumMales)
                toAdd = _NumFemales - toAdd
                toAdd = Math.Ceiling(toAdd)
                _Response = "There is no equalty, there is an excess of " + CStr(toAdd) + " number of women"
            End If

        End If
        Return _Response
    End Function

End Class
