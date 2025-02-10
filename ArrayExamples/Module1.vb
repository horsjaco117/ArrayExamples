'header

Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        'arrays are cool 
        Dim fruits(5) As String
        Dim names() As String = {"john", "paul", "ringo", "jeff"} 'w/Brackets everything is automatically assigned
        Dim BeanCounts = New Integer() {12345, 343, 5432, 9876}



        fruits(0) = "banana"
        fruits(3) = "grape"
        'fruits(6) = "apple" This is out of bounds and won't run

        'For i = 0 To 10

        '    Console.WriteLine(names(i))

        'Next 
        'above comments are examples of breaking 

        For i = LBound(names) To UBound(names)
            Console.WriteLine(names(i))
        Next

    End Sub

End Module
