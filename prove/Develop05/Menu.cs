class Menu
{
    public void DisplayMainMenu()
    {
        int response = 0;
        while (response < 1 || response > 6)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            Console.Write("Select a number from the menu: ");
            response = int.Parse(Console.ReadLine());
        }
        if (response == 1)
        {
            int goalChoice = DisplaySubMenu();
        }
        else if (response == 2)
        {
            // list goals
        }
        else if (response == 3)
        {
            // save goals
        }
        else if (response == 4)
        {
            // load goals
        }
        else if (response == 5)
        {
            // Record Event
        }
        else if (response == 6)
        {
            Console.WriteLine("Come back soon to review your goals and gain more points! ");
        }
        // return response;
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
        }
        return goalChoice;
    }
}