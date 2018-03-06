using System;

namespace dotnetcoreapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            var firstName = Console.ReadLine();

            Console.WriteLine($"Hello {firstName}, welcome to .NET Core.");
        }
    }
}
