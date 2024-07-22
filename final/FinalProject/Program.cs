using System;

class Program
{
    static string[] ReadFile()
    {
        // Console.Write("Enter the filename: ");
        // string filename = Console.ReadLine();
        string filename = "1fg9.pdb";

        string[] atomLines = File.ReadLines(filename).Where(line => line.StartsWith("ATOM")).ToArray();

        return atomLines;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Bioinformatics World!");

        string[] atomLines = ReadFile();

        Protein protein = new Protein();
        int index = 0;
        // foreach (string line in atomLines)
        while (index < atomLines.Count())
        {
            string line = atomLines[index];
            string tag = line[0..4];    // to selectthe appropriate columns, take the first parameter - 1, and leave the second parameter as it is written on this website: https://www.cgl.ucsf.edu/chimera/docs/UsersGuide/tutorials/pdbintro.html
            char chainIdentifier = line[21]; // this is a char A, B, C, D, E, etc
            // Console.WriteLine(zCoordinate);

            Chain chain1 = new Chain(chainIdentifier);
            while (tag != "TER") // make a chain
            {
                // Console.WriteLine($"outermost lopp: Tag = {tag}, {index}, {atomLines.Count()}");
                string residueName = line[17..20];
                int residueSequenceNumber = int.Parse(line[22..26]); // this sequence number is relative to the chain it belongs to, after each TER, this should restart
                string tempResName = residueName;
                int tempResNUmber = residueSequenceNumber;
                AminoAcid aminoAcid1 = new AminoAcid(residueName, residueSequenceNumber);
                while (residueName == tempResName && tempResNUmber == residueSequenceNumber)
                {
                    int atomSerialNumber = int.Parse(line[6..11]);
                    string atomName = line[12..16];
                    string atomSymbol = line[13].ToString();
                    double xCoordinate = double.Parse(line[30..38]);
                    double yCoordinate = double.Parse(line[38..46]);
                    double zCoordinate = double.Parse(line[46..54]);
                    Coordinate coordinate = new Coordinate(xCoordinate, yCoordinate, zCoordinate);
                    PeriodicTable ptable = new PeriodicTable();
                    double atomMass = ptable.GetAtomMass(atomSymbol);
                    Console.WriteLine($"Symbol: {atomSymbol}  Mass: {atomMass}");
                    Atom atom = new Atom(atomName, atomSerialNumber, coordinate, atomMass);
                    aminoAcid1.AddAtom(atom);
                    index++;
                    if (index < atomLines.Count())
                    {
                        line = atomLines[index];
                        tag = line[0..4];
                        tempResName = line[17..20];
                        tempResNUmber = int.Parse(line[22..26]);
                        // Console.WriteLine($"Innermost loop: tempResName={tempResName}");
                        // Console.WriteLine($"Innermost loop: tempResNumber={tempResNUmber}");
                    }
                    else
                    {
                        tempResNUmber = -1;
                        tag = "TER";
                    }
                }



                AminoAcid aminoAcid = new AminoAcid(residueName, residueSequenceNumber);
            }
        }
    }
}