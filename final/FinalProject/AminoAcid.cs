class AminoAcid
{
    private string _name;
    private int _residueSequenceNumber;
    private List<Atom> _atoms;

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
}