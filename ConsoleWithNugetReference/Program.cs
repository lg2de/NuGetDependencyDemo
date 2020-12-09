using System;
using System.IO;
using System.Runtime.Loader;
using DependentLibrary;

namespace ConsoleWithNugetReference
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World with NuGet!");

            var location = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            AssemblyLoadContext.Default.LoadFromAssemblyPath(Path.Combine(location!, "BaseLibrary.dll"));

            var dependentClass = new DependentClass();
            dependentClass.Method();
        }
    }
}
