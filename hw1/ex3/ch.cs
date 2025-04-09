using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(args[0]);
        int num2 = int.Parse(args[1]);
        string operation = args[2];

        Console.WriteLine($" {num1}, {num2}, {operation}");

        int result = 0;
        if (operation == "+")
        {
            result = num1 + num2;
        }
        else if (operation == "-")
        {
            result = num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        {
            result = num1 / num2;
        }
        Console.WriteLine($"Результат: {result}");
    }
}
