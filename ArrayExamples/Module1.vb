'header

Option Strict On
Option Explicit On

Module Module1

    Sub Main()

        MultiDimensionalArrays()

    End Sub

    Sub simplearrays()

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

    Sub MultiDimensionalArrays()

        Dim students(14, 2) As Single 'Plots 45 points. two from zero to 14

        students(3, 0) = 67.43
        students(7, 1) = 23.22
        students(9, 2) = 99.999999

        Console.WriteLine()
    End Sub


End Module
