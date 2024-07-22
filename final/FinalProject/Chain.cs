class Chain
{
    // private string _chainName;
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
    public double CalculateTotalMass()
    {
        double total = 0;
        foreach (AminoAcid aminoAcid in _aminoAcids)
        {
            total += aminoAcid.GetMass();
        }
        _totalMass = total;
        Console.WriteLine($"Chain {_chainIdentifier} has a mass: {_totalMass:F5} and has {_aminoAcids.Count} amino acid residues");
        return _totalMass;
    }
}