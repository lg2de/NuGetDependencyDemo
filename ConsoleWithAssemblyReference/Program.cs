using System;
using DependentLibrary;

namespace ConsoleWithAssemblyReference
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World with Assembly Reference!");

            var dependentClass = new DependentClass();
            dependentClass.Method();
        }
    }
}
