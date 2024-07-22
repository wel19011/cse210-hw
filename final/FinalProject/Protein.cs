class Protein : Molecule
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
    public override void DisplayStats()
    {
        Console.WriteLine($"Protein {_proteinName} has a mass: {_totalMass:F3} and has {_chains.Count} chains");
    }
}