Module Demo2
    'Bradley Mcneely
    '10/3/23
    'fahrenheit to celsius calculator

    Sub Main()
        'accept input from the user. 
        'convert it to an double - (double.tryparse(str, double)
        'convert the int from a f temp to a c temp 
        'formula is F - 32 * 59
        Dim F As Double
        Dim C As Double
        Dim input As String
        Console.Write("Please enter a ferenheit number >> ")
        input = Console.ReadLine()
        Double.TryParse(input, F)
        C = ((F - 32) * 5) / 9
        Console.WriteLine(C.ToString("N3"))








    End Sub
End Module
