class Protein
{
    private string _proteinName;
    private List<Chain> _chains;
    private double _totalMass;
    public Protein(string proteinName)
    {
        _proteinName = proteinName;
        _chains = new List<Chain> ();
    }
    public void AddChain(Chain chain)
    {
        _chains.Add(chain);
    }
    public void CalculateTotalMass()
    {
        double total = 0;
        foreach (Chain chain in _chains)
        {
            total += chain.GetMass();
        }
        _totalMass = total;
        Console.WriteLine($"Total weight of {_proteinName}: {_totalMass:F3} Da");
    }
}