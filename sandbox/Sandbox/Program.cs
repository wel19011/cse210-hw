using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello SB World!");
        Console.WriteLine("This is a test of working with C# syntax");
        Console.WriteLine("The following are examples the syntax");

        int x = 10;
        double y = 10.5624;
        string a = "bob";

        Console.WriteLine($"My integer: {x}, my double: {y}, the string: {a}");

        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine(j);
        }

        // string response = Console.Read("Input your age: ");
    }
}