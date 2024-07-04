using System;

class Program
{
    static int DisplayMenu()
    {
        int response = 0;
        while (response < 1 || response > 4)
        {
            // Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit ");
            response = int.Parse(Console.ReadLine());
        }   
        return response;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Activity act1 = new Activity("Essay", "Write 10 pages about the American Revolution", 10, "Thank you for completing your assignment");
        Console.WriteLine(act1.GetActivityName());
        Console.WriteLine(act1.GetDescription());

        int response = DisplayMenu();
        Console.WriteLine(response);
    }
}