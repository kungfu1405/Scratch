using System;
using System.IO;

namespace ConsoleApp_Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string manyLines = @"This is line one 
                            This is line two
                            Here is line three
                            The penultimate line is line four
                            This is the final, fifth line.";
            using (var reader = new StringReader(manyLines)) {
                string? item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                }while((item  != null)); 
            }
            Console.WriteLine("Hello World!");
        }
    }
}
