class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;
    private string filename = "MyGoals.txt";

    public int GetLength()
    {
        return _goals.Count;
    }
    public int GetTotalPoints()
    {

        return _totalPoints;
    }
    public void SaveGoals()
    {
        // logic to write to a file
        // string filename = "MyGoals.txt";
        using StreamWriter outputFile = new StreamWriter(filename);
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.ToString());
            }
        }
        // outputFile.Close();
    }
    public void LoadGoals()
    {
        // logic to read from a file and load into the goals list
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] wholeline = line.Split("#");
            string goalType = wholeline[0];
            string name = wholeline[1];
            string description = wholeline[2];
            int points = int.Parse(wholeline[3]);
            int numberCompleted = int.Parse(wholeline[4]);
            bool status = bool.Parse(wholeline[5]);


            if (goalType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, numberCompleted, status);
                _goals.Add(simpleGoal);
                // Console.WriteLine($"Added simpleGoal {name} {description} {points}");       //remember to comment this out before submitting
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points, numberCompleted, status);
                _goals.Add(eternalGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int timesToCompletion = int.Parse(wholeline[6]);
                int bonusPoints = int.Parse(wholeline[7]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, numberCompleted, status, timesToCompletion, bonusPoints);
                _goals.Add(checklistGoal);
            }
        }
        Console.WriteLine($"{_goals.Count} Goals added to the list");
    }
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }
    public void DisplayGoals()
    {
        Console.WriteLine("List of Goals: ");
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to display");
            return;
        }
        foreach (Goal g in _goals)
        {
            // Console.WriteLine($"{g.DisplayGoal()}");
            g.DisplayGoal();
        }
    }
    public void AddGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }
    public void RecordEvent()
    {
        int i = 1;
        foreach (Goal g1 in _goals)
        {
            Console.WriteLine($"{i}. {g1.GetGoal()}");
            i++;
        }
        Console.WriteLine("Please select which goal to update: ");
        int responseUpdate = int.Parse(Console.ReadLine());
        _totalPoints += _goals[responseUpdate - 1].RecordEvent();
    }
}