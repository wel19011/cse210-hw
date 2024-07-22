class Atom
{
    private string _atomName;
    private int _serialNumber;
    private Coordinate _position;
    private double _molecularMass;

    public Atom(string name, int serialNumber, Coordinate position, double mass)
    {
        _atomName = name;
        _serialNumber = serialNumber;
        _position = position;
        _molecularMass = mass;
    }
}