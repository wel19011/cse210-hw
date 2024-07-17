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
        string [] atomLines = ReadFile();
        foreach (string line in atomLines)
        {
            // Console.WriteLine(line[2]);
            string tag = line[0..4];    // to selectthe appropriate columns, take the first parameter - 1, and leave the second parameter as it is written on this website: https://www.cgl.ucsf.edu/chimera/docs/UsersGuide/tutorials/pdbintro.html
            int atomSerialNumber = int.Parse(line[6..11]);
            string atomName = line[12..16];
            string residueName = line[17..20];
            char chainIdentifier = line[21];
            Console.WriteLine(chainIdentifier);
        }
    }
}