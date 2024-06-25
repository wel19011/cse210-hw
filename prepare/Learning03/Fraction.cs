class Fraction
{
    private double _numerator;
    private double _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }
    public Fraction(double top, double bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }
    public void GetTop()
    {
        Console.WriteLine($"Numerator: {_numerator}");
    }
    public void SetTop(int top)
    {
        _numerator = top;
    }
    public void GetBottom()
    {
        Console.WriteLine($"Denominator: {_denominator}");
    }
    public void SetBottom(int bottom)
    {
        _denominator = bottom;
    }
    public void GetFractionString()
    {
        string top = _numerator.ToString();
        string bottom = _denominator.ToString();
        Console.WriteLine($"the fraction is: {top}/{bottom}");
        // return top;
    }
    public double GetDecimalValue()
    {
        double fraction = (_numerator / _denominator);
        return fraction;
    }
}