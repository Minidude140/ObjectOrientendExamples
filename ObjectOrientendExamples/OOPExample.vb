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
    Dim idCount As Integer = 0
    Sub Main()
        Dim personOne As New Person("Billy", 45)
        Dim studentOne As New Student("Sally", 21)
        Dim StudentTwo As New Student("Bob", 25)
        Dim SoapGuy As New IrishMan("Aiofe", 30)

        Console.WriteLine(personOne.Name & vbLf & personOne.Age & vbLf)
        Console.WriteLine()
        Console.WriteLine(studentOne.Name & vbLf & studentOne.Age & vbLf & studentOne.idNumber & vbLf)
        Console.WriteLine(StudentTwo.Name & vbLf & StudentTwo.Age & vbLf & StudentTwo.idNumber & vbLf)
        Console.WriteLine(SoapGuy.Name & vbLf & SoapGuy.Age & vbLf & SoapGuy.irishComment & vbLf)
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
        Public idNumber As Integer
        Public Sub New(Name As String, Age As Integer)
            MyBase.New(Name, Age)
            Me.idNumber = idCount
            idCount += 1

        End Sub
        Public StudentID As Integer

    End Class

    Class IrishMan
        Inherits Person
        Public irishComment As String
        Public Sub New(Name As String, Age As Integer)
            MyBase.New(Name, Age)
            Me.irishComment = "Good to be at the top the mountain"
        End Sub
    End Class

End Module
