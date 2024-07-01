using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        // Circle myCircle = new Circle(10); // the new keyword denotes a new instance
        // Console.WriteLine($"{myCircle.GetArea()}");

        // Circle unitCircle = new Circle(1);
        // Console.WriteLine($"Circumference: {unitCircle.GetCircumference()}");
        // Console.WriteLine($"Diameter: {unitCircle.GetDiameter()}");

        Person person1 = new Person("bob", "smith", 34, 210);
        Console.WriteLine(person1.PersonInformation());

        Fireman fireman = new Fireman("EMT and paramedic", "Billy", "Tarnish", 24, 190);

        Console.WriteLine(fireman.PersonInformation());
        Console.WriteLine(fireman.FiremanInformation());
    }
}