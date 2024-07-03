using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Activity act1 = new Activity("Essay", "Write 10 pages about the American Revolution", 10, "Thank you for completing your assignment");
        Console.WriteLine(act1.GetActivityName());
        Console.WriteLine(act1.GetDescription());
    }
}