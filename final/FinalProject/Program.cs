using System;

class Program
{
    static string [] ReadFile()
    {
        // Console.Write("Enter the filename: ");
        // string filename = Console.ReadLine();
        string filename = "1fg9.pdb";

        string [] atomLines = File.ReadLines(filename).Where(line => line.StartsWith("ATOM")).ToArray();
        return atomLines;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Bioinformatics World!");


    }
}