class Residue
{
    private string _name;
    private int _serialNumber;
    List<AminoAcid> _aminoAcids;

    public Residue(string name, int serialNumber)
    {
        _name = name;
        _serialNumber = serialNumber;
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