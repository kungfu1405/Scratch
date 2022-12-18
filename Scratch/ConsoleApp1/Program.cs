// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string manyLines = @"This is line one 
                            This is line two
                            Here is line three
                            The penultimate line is line four
                            This is the final, fifth line.";
using (var reader = new StringReader(manyLines))
{
    string? item;
    do
    {
        item = reader.ReadLine();
        Console.WriteLine(item);
    } while ((item != null));
}

 var reader2 = new StringReader(manyLines);
string? item2;
do
{
    item2 = reader2.ReadLine();
    Console.WriteLine(item2);
} while (item2 != null);
string a = "";