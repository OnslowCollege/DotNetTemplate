using System;

namespace DotNet // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Hello, {name}!");
        }
    }
}