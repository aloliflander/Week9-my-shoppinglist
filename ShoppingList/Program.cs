using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Alo\Samples";
            Console.WriteLine("Enter directory name.");
            string newDirectory = Console.ReadLine().ToLower();
            Console.WriteLine("Enter file name.");
            string fileName = Console.ReadLine().ToLower();
            if (Directory.Exists($"{rootDirectory}//{newDirectory}") && File.Exists($"{rootDirectory}//{newDirectory}//{fileName}"))
            {
                Console.WriteLine("Directory and file allready exist.");
                Console.WriteLine("Would you like to add a wish?");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}//{newDirectory}");
                File.Create($"{rootDirectory}//{newDirectory}//{fileName}");
            }
        }
    }
}
