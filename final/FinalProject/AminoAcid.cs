class AminoAcid
{
    private string _name;
    private int _serialNumber;
    private List<Atom> _atoms;

    public AminoAcid(string name, int serialNumber)
    {
        _name = name;
        _serialNumber = serialNumber;
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