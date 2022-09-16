' *****************************************************************
' Team Number: 3
' Team Member 1 Details: Masimba, RT (222015402)
' Team Member 2 Details: Ndlovu, LF (221078299)
' Team Member 3 Details: Hoaeane, K (218105185)
' Team Member 4 Details: Sondezi, N (218000317)
' Practical: Team Project
' Class name: (FrmGenderEqualityIndex)
' *****************************************************************
'Set up options statements

Option Strict On
Option Explicit On
Option Infer Off

Public Class FrmGenderEqualityIndex

    'start declaring variables

    Private Departments() As Department
    Private numfemales, nummales, total As Integer

    'set up a subroutine .

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim Departments(0)
    End Sub

    'set up a button to add a stem department .
    Private Sub btnAddStem_Click(sender As Object, e As EventArgs) Handles btnAddStem.Click
        name = txtsName.Text
        numfemales = CInt(txtsFemales.Text)
        nummales = CInt(txtsMales.Text)
        'check if values are positive
        numfemales = CheckPositive(numfemales)
        nummales = CheckPositive(nummales)
        total = numfemales + nummales

        'resize dept array
        ReDim Preserve Departments(Departments.Length)

        'create stem object
        Departments(Departments.Length - 1) = New Stem(name, numfemales, nummales, total)

        Dim ename, egender As String
        Dim eage As Integer
        'get females' info
        egender = "female"
        For f As Integer = 1 To numfemales
            ename = InputBox("Enter name for female employee " + CStr(f))
            eage = CInt(InputBox("Enter age for " + ename))

            While eage < 18 'for user to input valid age for an employee 
                MsgBox("The person is too young")
                eage = CInt(InputBox("Enter valid age for " + ename))
            End While
            Departments(Departments.Length - 1).addEmployee(ename, egender, eage, f)
        Next f

        'get males' info
        egender = "male"
        For m As Integer = 1 To nummales
            ename = InputBox("Enter name for male employee " + CStr(m))
            eage = CInt(InputBox("Enter age for " + ename))

            While eage < 18 'for user to input valid age for an employee 
                MsgBox("The person is too young")
                eage = CInt(InputBox("Enter valid age for " + ename))
            End While
            Departments(Departments.Length - 1).addEmployee(ename, egender, eage, m)
        Next m

        'check if 1st dept
        checkFirst()

        'clear text boxes
        ClearText()
    End Sub


    'set up a button to add a non stem department .
    Private Sub btnAddNon_Click(sender As Object, e As EventArgs) Handles btnAddNon.Click
        name = txtnName.Text
        numfemales = CInt(txtnFemales.Text)
        nummales = CInt(txtnMales.Text)
        'check for positive numbers
        numfemales = CheckPositive(numfemales)
        nummales = CheckPositive(nummales)

        total = numfemales + nummales

        'resize the deptartment array .
        ReDim Preserve Departments(Departments.Length)

        'create stem object
        Departments(Departments.Length - 1) = New NonStem(name, numfemales, nummales, total)

        Dim ename, egender As String
        Dim eage As Integer
        'get the females' info
        egender = "female"
        For f As Integer = 1 To numfemales
            ename = InputBox("Enter name for female employee " + CStr(f))
            eage = CInt(InputBox("Enter valid age for " + ename))

            While eage < 18 'for user to input valid age for an employee 
                MsgBox("The person is too young")
                eage = CInt(InputBox("Enter valid age for " + ename))
            End While
            Departments(Departments.Length - 1).addEmployee(ename, egender, eage, f)
        Next f

        'get the males' info
        egender = "male"
        For m As Integer = 1 To nummales
            ename = InputBox("Enter name for male employee " + CStr(m))
            eage = CInt(InputBox("Enter age for " + ename))

            While eage < 18 'for user to input valid age for an employee 
                MsgBox("The person is too young")
                eage = CInt(InputBox("Enter valid age for " + ename))
            End While
            Departments(Departments.Length - 1).addEmployee(ename, egender, eage, m)
        Next m

        'check if 1st dept
        checkFirst()
        'clear text boxes
        ClearText()

    End Sub

    'sub to check if 1st department
    Public Sub checkFirst()
        If Departments.Length = 2 Then
            txtdNum.Text = CStr(Departments.Length - 1)
            txtdName.Text = Name
            'polymorphism statements
            txtdEquality.Text = Departments(Departments.Length - 1).CalcEquality
            txtdMessage.Text = Departments(Departments.Length - 1).DetermineMsg
        End If
    End Sub

    'show previous dept
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim index As Integer
        index = CInt(txtdNum.Text)
        If (index > 1) Then
            DisplayDept(index - 1)
        End If
    End Sub

    'show next dept
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim index As Integer
        index = CInt(txtdNum.Text)
        If (index < Departments.Length - 1) Then
            DisplayDept(index + 1)
        End If
    End Sub

    'sub to display dept
    Public Sub DisplayDept(index As Integer)
        txtdNum.Text = CStr(index)
        txtdName.Text = Departments(index).Name
        'polymorphism statements
        txtdEquality.Text = Departments(index).CalcEquality
        txtdMessage.Text = Departments(index).DetermineMsg
    End Sub

    'sub to clear text
    Public Sub ClearText()
        txtnName.Clear()
        txtnFemales.Clear()
        txtnMales.Clear()
        txtsName.Clear()
        txtsFemales.Clear()
        txtsMales.Clear()
    End Sub

    'sub to check if value positive
    Public Function CheckPositive(num As Integer) As Integer
        If num >= 0 Then
            Return num
        Else
            While num < 0
                num = CInt(InputBox("Number " + CStr(num) + " cannot be negative " + "Enter new value"))
            End While
            Return num
        End If
    End Function
End Class
