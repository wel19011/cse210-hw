class Chain : Molecule
{
    private char _chainIdentifier;
    List<AminoAcid> _aminoAcids;
    private double _totalMass;

    public Chain()
    {}
    public Chain(char chainIdentifier)
    {
        // _chainName = name;
        _chainIdentifier = chainIdentifier;
        _aminoAcids = new List<AminoAcid>();
    }
    public void AddAminoAcid(AminoAcid aminoAcid)
    {
        _aminoAcids.Add(aminoAcid);
    }
    public int CountAminoAcids()
    {
        return _aminoAcids.Count;
    }
    public void CalculateTotalMass()
    {
        double total = 0;
        foreach (AminoAcid aminoAcid in _aminoAcids)
        {
            total += aminoAcid.GetMass();
        }
        _totalMass = total;
        Console.WriteLine($"Chain {_chainIdentifier} has a mass: {_totalMass:F3} Daltons and has {_aminoAcids.Count} amino acid residues");
    }
    public double GetMass()
    {
        return _totalMass;
    }
    public override void DisplayStats()
    {
        Console.WriteLine($"Chain {_chainIdentifier} has a mass: {_totalMass:F3} and has {_aminoAcids.Count} amino acids");
    }
}