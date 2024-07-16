class Atom
{
    private string _atomName;
    private int _serialNumber;
    private Coordinate _position;

    public Atom(string name, int serialNumber, Coordinate position)
    {
        _atomName = name;
        _serialNumber = serialNumber;
        _position = position;
    }
}