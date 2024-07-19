class Chain
{
    // private string _chainName;
    private char _chainIdentifier;
    List<AminoAcid> _aminoAcids;

    public Chain()
    {

    }
    public Chain(char chainIdentifier)
    {
        // _chainName = name;
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