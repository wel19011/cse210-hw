using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // this is the way the example had it, the following were how I had attempted it beforehand
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(6);
        f2.GetFractionString();
        double decimalValue = f2.GetDecimalValue();
        Console.WriteLine(decimalValue);

        Fraction f3 = new Fraction(6,7);
        f3.GetFractionString();
        double decimalValue2 = f3.GetDecimalValue();
        Console.WriteLine(decimalValue2);

    }
}