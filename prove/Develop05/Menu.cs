class Menu
{
    public int DisplayMainMenu()
    {
        int response = 0;
        while (response < 1 || response > 6)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            Console.Write("Select a number from the menu: ");
            response = int.Parse(Console.ReadLine());
        }
        return response;
    }
    public int DisplaySubMenu()
    {
        int goalChoice = 0;
        while (goalChoice < 1 || goalChoice > 3)
        {
            Console.WriteLine("The types of goals are as follows: ");
            Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
            Console.Write("Which goal type would you like to create? ");
            goalChoice = int.Parse(Console.ReadLine());
        }
        return goalChoice;
    }
}