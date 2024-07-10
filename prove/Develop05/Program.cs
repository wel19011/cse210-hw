using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Eternal Quest World!");

        ChecklistGoal check = new ChecklistGoal();
        check.DisplayGoal();

        EternalGoal eg = new EternalGoal();
        SimpleGoal sg = new SimpleGoal();

        List<Goal> goals = new List<Goal>();
        goals.Add(check);
        goals.Add(eg);
        goals.Add(sg);

        foreach (Goal g in goals)
        {
            g.DisplayGoal();
        }
    }
}