using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Bioinformatics World!");

        // Console.Write("Enter the filename: ");
        // string filename = Console.ReadLine();
        string filename = "1fg9.pdb";
        // string [] lines = System.IO.File.ReadAllLines(filename);

        var atomLines = File.ReadLines(filename).Where(line => line.StartsWith("ATOM"));
        int atoms = 0;
        foreach (var line in atomLines)
        {
            atoms++;
        }
        Console.WriteLine(atoms);
    }
}