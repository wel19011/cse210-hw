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
            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input Error: {ex}");
            }
        }   
            return response;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        int response = 0;
        while (response != 4)
        {
            response = DisplayMenu();

            if (response == 1)
            {
                // Breating activity
                string name = "Breathing";
                string description = "This activity will help you to calm and focus your mind. Prepare to breath deeply.";
                BreathingActivity ba = new BreathingActivity(name, description);
                ba.DisplayWelcome();
                ba.GiveInstructions();
                ba.DisplayEndingMessage();
            }
            else if (response == 2)
            {
                // Reflection activity
                string name = "Reflection";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. \nIf you would prefer, you're invited to get out a paper and pencil and record your thoughts.";
                ReflectionActivity ra = new ReflectionActivity(name, description);
                ra.DisplayWelcome();
                ra.DisplayReflection();
                ra.DisplayEndingMessage();
            }
            else if (response == 3)
            {
                // Lising Activity
                string name = "Listing";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. \nAccording to your preference, you are welcome to use a paper and pencil to record some of your thoughts.";
                ListingActivity la = new ListingActivity(name, description);
                la.DisplayWelcome();
                la.DisplayListing();
                la.DisplayEndingMessage();
            }
            else if (response == 4)
            {
                // Display goodbye message
                Console.Clear();
                Console.WriteLine("Thank you for taking time for Mindfulness Today.");
                Thread.Sleep(3000);
                Console.WriteLine("\nHave a wonderful rest of your day!");
                Console.WriteLine("\n");
            }
        }
    }
}