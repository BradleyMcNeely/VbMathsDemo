Module Module1
    'Bradley Mcneely
    '10/3/23
    'maths demo 1
    Sub Main()
        Dim num1, num2 As Integer
        Dim added, subtracted, multiplied As Integer
        Dim divided As Double
        Dim valid As Boolean
        Dim input As String
        Console.Write("Please enter the first number -> ")
        input = Console.ReadLine
        'the following method takes a string and tries
        'to convert it to an ineger. if it cant
        'it stores 0 in the integer variable passed in
        'it returns true for a valid conversion, false otherwise
        valid = Integer.TryParse(input, num1)
        Console.WriteLine(valid & ":" & num1)
        Console.ReadKey()

        Console.Write("Please enter the second number -> ")
        input = Console.ReadLine
        valid = Integer.TryParse(input, num2)
        Console.WriteLine(valid & ":" & num2)
        Console.ReadKey()
        added = num1 + num2
        subtracted = num1 - num2
        multiplied = num1 * num2
        divided = num1 / num2
        Console.WriteLine("{0} + {1} = {2}", num1, num2, added)
        Console.WriteLine("{0} - {1} = {2}", num1, num2, subtracted)
        Console.WriteLine("{0} * {1} = {2}", num1, num2, multiplied)
        Console.WriteLine("{0} \ {1} = {2} <- WHAT?! Thats integer divsion?", num1, num2, divided)
        Console.WriteLine("{0} / {1} = {2} <- floating point division", num1, num2, divided.ToString("N2"))
        'format the double to be a numbre with 2 decimal places

        Console.ReadLine()
    End Sub


End Module
