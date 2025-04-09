using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выбери");
        Console.WriteLine("1 = Ожидать завершения дочернего процесса");
        Console.WriteLine("2 = Принудительно завершить дочерний процесс");

        int choice = int.Parse(Console.ReadLine());

        ProcessStartInfo processStartInfo = new ProcessStartInfo();
        processStartInfo.FileName = "ch.exe";
        Process process = new Process();
        process.StartInfo = processStartInfo;

        process.Start();

        if (choice == 1)
        {
            process.WaitForExit();
            int exitCode = process.ExitCode;
            Console.WriteLine($"off {exitCode}");
        }
        else if (choice == 2)
        {
            process.Kill();
            Console.WriteLine("immediately off");
        }
        else
        {
            Console.WriteLine("?");
        }
    }
}
