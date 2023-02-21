Imports System
'Modules are logic procedures gathering that simplyfies Console programs organization
Module Program
    'Sub defines a procedure
    'Main is the entry point of the program
    Sub Main(args As String())

        'Dim defines a variable As defines the type
        Dim text As String = "Hello World"
        Dim trueOrFalse As Boolean = True
        Dim numberInt As Integer = 123
        Dim numberDecimal As Decimal = 7.5
        Dim varChar As Char = "a"

        'VB is not case sensitive: text == TEXT

        Console.Write("Write your name: ")
        Dim name As String = Console.ReadLine()

        Console.WriteLine("Your name is {0}", name)

        'Math operations

        Dim number1, number2 As Integer

        Console.Write("Please enter a number: ")
        number1 = Console.ReadLine()
        Console.Write("Please enter another number: ")
        number2 = Console.ReadLine()

        Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2)
        Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2)
        Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2)
        Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2)
        Console.WriteLine("{0} mod {1} = {2}", number1, number2, number1 Mod number2)
        Console.WriteLine("{0} ^ {1} = {2}", number1, number2, number1 ^ number2)
    End Sub

End Module
