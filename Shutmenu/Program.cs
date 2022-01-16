using System;
namespace Powermenu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select an option to proceed\n");
            Console.WriteLine("a. Shutdown\n");
            Console.WriteLine("b. Reboot\n");
            Console.WriteLine("c. Cancel\n");
            string input;
            input = Console.ReadLine();
            if (input == "a")
            {
                string cmdexec;
                cmdexec = "shutdown -s -t 0";
                System.Diagnostics.Process.Start("CMD.exe /C", cmdexec);
            }
            if (input == "b")
            {
                string cmdexec;
                cmdexec = "shutdown -r -t 0";
                System.Diagnostics.Process.Start("CMD.exe /C", cmdexec);
            }
            if (input == "c")
            {
                Environment.Exit(1);
            }    
        }
    }
}