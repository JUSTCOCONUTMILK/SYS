using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("n1");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("n2");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("choose (+, -, *, /):");
        string operation = Console.ReadLine();

        ProcessStartInfo processStartInfo = new ProcessStartInfo();
        processStartInfo.FileName = "ch.exe";
        processStartInfo.Arguments = $"{num1} {num2} {operation}";

        Process process = new Process();
        process.StartInfo = processStartInfo;

        process.Start();
        process.WaitForExit();
    }
}
