class AminoAcid
{
    private string _name;
    private int _residueSequenceNumber;
    private List<Atom> _atoms;
    private double _totalMass;

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
    public int CountAtoms()
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
        // Console.WriteLine($"Amino Acid {_name} has a mass: {total:F5} and has {_atoms.Count} atoms");
        _totalMass = total;
        return _totalMass;
    }
    public double GetMass()
    {
        return _totalMass;
    }
}