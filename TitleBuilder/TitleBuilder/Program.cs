using System;

namespace TitleBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Title Builder\n");

            ConsoleHelper consoleHelper = new ConsoleHelper();
            Console.WriteLine(consoleHelper.GenerateTitle("Hello and Welcome to the second grade"));
        }
    }
}
