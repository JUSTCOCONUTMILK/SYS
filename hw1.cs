using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        ProcessStartInfo processStartInfo = new ProcessStartInfo();
        processStartInfo.FileName = "ch.exe";
        Process process = new Process();
        process.StartInfo = processStartInfo;
        process.Start();
        process.WaitForExit(); 

        int exitCode = process.ExitCode;
        Console.WriteLine($"off:{exitCode}");
    }
}
