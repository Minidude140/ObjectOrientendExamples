'Zachary Christensen
'RCET 2265
'Fall 2023
'Object Oriented Programing
'https://github.com/Minidude140


Option Explicit On
Option Strict On


'Generic object class system
'developed to organize..
Module OOPExample

    Sub Main()
        Dim personOne As New Person("Billy", 45)
        Dim Student As New Student("Sally", 21)

        Console.WriteLine(personOne.Name & vbLf & personOne.Age & vbLf)
        Console.WriteLine()
        Console.WriteLine(Student.Name & vbLf & Student.Age & vbLf & Student.idNumber)
        Console.Read()
    End Sub

    Class Person
        Public Name As String
        Public Age As Integer
        Public Sub New(ByVal Name As String, ByVal Age As Integer)
            Me.Name = Name
            Me.Age = Age
        End Sub
    End Class

    Class Student
        Inherits Person
        Public idNumber As String
        Public Sub New(Name As String, Age As Integer)
            MyBase.New(Name, Age)
            Me.idNumber = "1234"

        End Sub
        Public StudentID As Integer

    End Class

End Module
