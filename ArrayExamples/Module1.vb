'header

Option Strict On
Option Explicit On

Module Module1

    Sub Main()

        'MultiDimensionalArrays()
        TestRandomness()

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
        Dim classes() As String = {"Math", "History", "Art"}
        Dim somethingElse(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim threeDImensionArray(,,) As Integer = {{{1}, {2}, {3}}, {{3}, {2}, {1}}, {{7}, {8}, {9}}}

        students(3, 0) = 67.43
        students(7, 1) = 23.22
        students(9, 2) = 99.999999

        Console.WriteLine()
    End Sub

    Sub TestRandomness()
        Dim beanCounter(20) As Integer

        For i = 1 To 1000000

            beanCounter(randomNumberBetween(5, 16)) += 1 'the return is the pointer for the array


        Next

        For i = LBound(beanCounter) To UBound(beanCounter)

            Console.WriteLine($"{i} hit {beanCounter(i)} times!")

        Next


    End Sub


    Function randomNumberBetween(max As Integer, min As Integer) As Integer 'We need to declare return type
        Dim temp As Single 'The single type helps work with the randomize stuff
        Randomize()
        temp = Rnd()
        'establish range 
        temp *= (max + 1) - min  'supposedly adding the one increase the max by 1. to fix inclusivity of max/min

        temp += min - 1 'This is supposed to shift the min down by 1
        'Return CInt(temp) 'bad randomness
        'Return CInt(Int(temp)) 'Randomness is ok, but max isn't included
        'Return CInt(Math.Floor(temp)) 'randomness is ok, but max isn't included
        Return CInt(Math.Floor(temp)) 'min isn't included
        'Return CInt(Math.Ceiling(temp)) 'Always remember a function needs to return
    End Function


End Module
