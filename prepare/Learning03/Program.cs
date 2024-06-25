using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        f1.GetFractionString();
        f1.GetDecimalValue();

        Fraction f2 = new Fraction(6);
        f2.GetFractionString();
        f2.GetDecimalValue();

        Fraction f3 = new Fraction(6,7);
        f3.GetFractionString();
        f3.GetDecimalValue();
    }
}