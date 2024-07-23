class AminoAcid : Molecule
{
    private string _name;
    private int _residueSequenceNumber;
    private List<Atom> _atoms;
    private Dictionary<string, double> _aminoAcidHydrogens; // the code below that creates this dictionary was generated by ChatGPT
    // private double _totalMass;

    public AminoAcid()
    {
        
    }
    public AminoAcid(string name, int residueSequenceNumber)
    {
        _name = name;
        _residueSequenceNumber = residueSequenceNumber;
        _atoms = new List<Atom>();
    }
    public void AddAtom(Atom atom)
    {
        _atoms.Add(atom);
    }
    public override int CountComponents()
    {
        return _atoms.Count;
    }
    public double CalculateTotalMass()
    {
        double total = 0;
        foreach (Atom atom in _atoms)
        {
            total += atom.GetMass();
        }
        total += GetHydrogenMass(_name);
        SetMass(total);
        return GetMass();
    }
    public override void DisplayStats()
    {
        Console.WriteLine($"Amino Acid {_name} has a mass: {GetMass():F3} and has {_atoms.Count} atoms");
    }
    private double GetHydrogenMass(string key)
    {
        double massHydrogens = 0;
        _aminoAcidHydrogens = new Dictionary<string, double>
        {
            { "ALA", 7 },
            { "ARG", 14 },
            { "ASN", 8 },
            { "ASP", 7 },
            { "CYS", 7 },
            { "GLN", 10 },
            { "GLU", 9 },
            { "GLY", 5 },
            { "HIS", 9 },
            { "ILE", 13 },
            { "LEU", 13 },
            { "LYS", 14 },
            { "MET", 11 },
            { "PHE", 11 },
            { "PRO", 9 },
            { "SER", 7 },
            { "THR", 9 },
            { "TRP", 12 },
            { "TYR", 11 },
            { "VAL", 11 }
        };
        if (_aminoAcidHydrogens.TryGetValue(key, out double value))
        {
            // Console.WriteLine($"The number of hydrogens in {key} is {value}.");
            massHydrogens = value * 1.008;
            return massHydrogens;
        }
        else
        {
            Console.WriteLine($"The key '{key}' was not found in the dictionary.");
            return 0;
        }
    }
}