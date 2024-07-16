class Menu
{
    Goals goals = new Goals();
    public int DisplayMainMenu()
    {
        int response = 0;

        while (response < 1 || response > 6)
        {
            Console.WriteLine($"\nYou have {goals.GetTotalPoints()} points.\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            Console.Write("Select a number from the menu: ");
            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch (FormatException fm)
            {
                Console.WriteLine($"Format Exception: {fm} \nPlease enter correct input format");
            }

        }
        if (response == 1)
        {
            DisplaySubMenu();
        }
        else if (response == 2)
        {
            // list goals
            goals.DisplayGoals();
        }
        else if (response == 3)
        {
            // save goals
            goals.SaveGoals();
        }
        else if (response == 4)
        {
            // load goals
            // Console.Write("Enter the file to load from: ");
            // string filename = Console.ReadLine();
            goals.LoadGoals();
        }
        else if (response == 5)                                 // how can I get this to work? and how to keep track of the total points earned? 
        {
            // Record Event
            goals.RecordEvent();
        }
        else if (response == 6)
        {
            Console.WriteLine("Come back soon to review your goals and gain more points! ");
        }
        return response;
    }
    private int DisplaySubMenu()
    {
        int goalChoice = 0;
        while (goalChoice < 1 || goalChoice > 3)
        {
            Console.WriteLine("The types of goals are as follows: ");
            Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
            Console.Write("Which goal type would you like to create? ");
            try
            {
                goalChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Format Exception: {fe} \nPease enter the correct format to choose a type of goal.\n");
            }

            if (goalChoice == 1)
            {
                // Simple goal
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string description = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                int points = int.Parse(Console.ReadLine());
                int numberCompleted = 0;
                bool status = false;
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, numberCompleted, status);
                goals.AddGoal(simpleGoal);
            }
            else if (goalChoice == 2)
            {
                // Eternal Goal
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string description = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                int points = int.Parse(Console.ReadLine());
                int numberCompleted = 0;
                bool status = false;
                EternalGoal eternalGoal = new EternalGoal(name, description, points, numberCompleted, status);
                goals.AddGoal(eternalGoal);
            }
            else if (goalChoice == 3)
            {
                // Checklist Goal
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string description = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("How many times do you want to complete this goal? ");
                int timesToCompletion = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points for when you accomplish this goal? ");
                int bonus = int.Parse(Console.ReadLine());
                int numberCompleted = 0;
                bool status = false;
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, numberCompleted, status, timesToCompletion, bonus);
                goals.AddGoal(checklistGoal);
            }
        }
        return goalChoice;
    }
}