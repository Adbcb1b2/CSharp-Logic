using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace CSharpLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Retrieving the ProjectName dynamically
            if (args.Length > 0)
            {
                string commandLineArgument = new(args[0]);
                Console.WriteLine(commandLineArgument);
            }
            else
            {
                Console.WriteLine("No command line argument provided.");
            }

        }
    }
    
    
}