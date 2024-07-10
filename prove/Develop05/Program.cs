using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Eternal Quest World!");

        // ChecklistGoal check = new ChecklistGoal();
        // check.DisplayGoal();

        // EternalGoal eg = new EternalGoal();
        // SimpleGoal sg = new SimpleGoal();

        // List<Goal> goals = new List<Goal>();
        // goals.Add(check);
        // goals.Add(eg);
        // goals.Add(sg);

        // foreach (Goal g in goals)
        // {
        //     g.DisplayGoal();
        // }

        // Console.Write("Add your Goal");
        // string tempGoalString = Console.ReadLine();
        // SimpleGoal sg2 = new SimpleGoal();
        // sg2.SetGoal(tempGoalString);
        // Goals goals1 = new Goals();
        // goals1.AddGoal(sg2);

        // goals1.DisplayGoals();

        Menu m = new Menu();
        int response = m.DisplayMainMenu();
        if (response == 1)
        {
            int goalChoice = m.DisplaySubMenu();
        }
    }
}