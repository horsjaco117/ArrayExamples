'header

Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        'arrays are cool 
        Dim fruits(5) As String

        fruits(0) = "banana"
        fruits(3) = "grape"
        'fruits(6) = "apple" This is out of bounds and won't run

        Console.WriteLine()

    End Sub

End Module
