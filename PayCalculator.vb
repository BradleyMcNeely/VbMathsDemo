Module PayCalculator
    'Bradley mcneely
    '10/3/23
    'pay calcualtor

    Sub Main()
        Dim payRate, grossPay, hrsWorked As Double 'These are values we'll get from the user
        Dim input As String 'just used to get input from the user
        Dim valid



        Console.Write("Please enter a pay rate (per hour) -> ")
        input = Console.ReadLine()
        valid = Double.TryParse(input, payRate)
        Console.Write("Please enter the hours you work(ed). -> ")
        input = Console.ReadLine()
        valid = Double.TryParse(input, hrsWorked)
        grossPay = payRate * hrsWorked
        Console.WriteLine(grossPay.ToString("C2"))










        Console.ReadKey()

    End Sub
End Module
