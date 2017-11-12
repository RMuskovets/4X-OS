using System;
using System.Collections.Generic;
using System.IO;
using Sys = Cosmos.System;
using OSLibrary.IO;

namespace _4X_OS
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("4X OS booted. To see help message - type \"help\"");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        protected override void Run()
        {
            Console.Write("~$ ");
            string line = Console.ReadLine();
        }
    }
}
