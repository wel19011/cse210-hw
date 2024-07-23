class Molecule
{
    private double _totalMass;
    // public Molecule(double mass)
    // {
    //     _totalMass = mass;
    // }
    // public void CalculateTotalMass()
    public double SetMass(double mass)
    {
        _totalMass = mass;
        return _totalMass;
    }
    public virtual int CountComponents()
    {
        return 0;
    }  
    public double GetMass()
    {
        return _totalMass;
    }
    public virtual void DisplayStats()
    {
        Console.WriteLine("There are no stats to display.");
    }
}