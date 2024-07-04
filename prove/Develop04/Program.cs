using System;

class Program
{
    static int DisplayMenu()
    {
        int response = 0;
        while (response < 1 || response > 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit ");
            response = int.Parse(Console.ReadLine());
            if (response == 4)
            {
                break; 
            }
        }   
            return response;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        // Activity act1 = new Activity("Essay", "Write 10 pages about the American Revolution", 10, "Thank you for completing your assignment");
        // Console.WriteLine(act1.GetActivityName());
        // Console.WriteLine(act1.GetDescription());

        int response = DisplayMenu();
        // Console.WriteLine(response);

        // Activity act2 = new Activity("Sleep", "breath lots", 5, "Thank you for participating");
        // // act2.Animation();
        // act2.Timer();

        if (response == 1)
        {
            // Breating activity
            BreathingActivity ba = new BreathingActivity("Breathing", "This activity will teach you how to breath", 0, "Thank you for participating", "prompt");
            ba.DisplayWelcome();
            ba.Timer();
        }
        else if (response == 2)
        {
            // Reflection activity
        }
        else if (response == 3)
        {
            // Lising Activity
        }
        else if (response == 4)
        {
            // Display goodbye message
        }
    }
}