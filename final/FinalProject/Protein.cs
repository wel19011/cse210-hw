class Protein : Molecule
{
    private string _proteinName;
    private List<Chain> _chains;
    // private double _totalMass;
    public Protein(string proteinName)
    {
        _proteinName = proteinName;
        _chains = new List<Chain> ();
    }
    public void AddChain(Chain chain)
    {
        _chains.Add(chain);
    }
    public override int CountComponents()
    {
        return _chains.Count;
    }
    public void CalculateTotalMass()
    {
        double total = 0;
        foreach (Chain chain in _chains)
        {
            total += chain.GetMass();
        }
        SetMass(total);
        // Console.WriteLine($"Total weight of {_proteinName}: {GetMass():F3} Da");
        DisplayStats();
    }
    public override void DisplayStats()
    {
        Console.WriteLine($"Protein {_proteinName} has a mass: {GetMass():F3} Daltons and has {_chains.Count} chains");
    }
}