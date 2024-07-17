class Chain
{
    private string _chainName;
    private int _chainIdentifier;
    List<AminoAcid> _aminoAcids;

    public Chain(string name, int chainIdentifier)
    {
        _chainName = name;
        _chainIdentifier = chainIdentifier;
    }
    public void AddAminoAcid(AminoAcid aminoAcid)
    {
        _aminoAcids.Add(aminoAcid);
    }
    public int CountAminoAcids()
    {
        return _aminoAcids.Count;
    }
}