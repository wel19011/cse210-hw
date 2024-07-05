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
        }   
            return response;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        // Activity act1 = new Activity("Essay", "Write 10 pages about the American Revolution", 10, "Thank you for completing your assignment");
        // Console.WriteLine(act1.GetActivityName());
        // Console.WriteLine(act1.GetDescription());

        // Console.WriteLine(response);

        // Activity act2 = new Activity("Sleep", "breath lots", 5, "Thank you for participating");
        // // act2.Animation();
        // act2.Timer();
        int response = 0;
        // while ((response = DisplayMenu()) != 4)
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
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectionActivity ra = new ReflectionActivity(name, description);
                ra.DisplayWelcome();
                string prompt = ra.ChoosePrompt();
                string question = ra.ChooseQuestion();
                Console.WriteLine(prompt + question);
                ra.DisplayEndingMessage();
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
}