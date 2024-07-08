using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("blue", 10);
        Console.WriteLine($"{square.GetColor()}{square.GetArea()}");

        Rectangle rectangle = new Rectangle("Red", 5,3);
        Console.WriteLine($"{rectangle.GetColor()} {rectangle.GetArea()}");

        Circle circle = new Circle("Purple", 10);
        Console.WriteLine($"{circle.GetColor()}{circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("The for-loop reads as follows: ");
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"{s.GetColor()}{s.GetArea()}");
        }
    }
}