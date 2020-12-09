using System;
using DependentLibrary;

namespace ConsoleWithNugetReference
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World with NuGet!");

            var dependentClass = new DependentClass();
            dependentClass.Method();
        }
    }
}
