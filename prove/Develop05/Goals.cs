class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private int _lengthOfGoalsList;
    private int _totalPoints;
    private string filename = "MyGoals.txt";

    public int GetLength()
    {
        return _lengthOfGoalsList;
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
        _lengthOfGoalsList = 0;

        foreach (string line in lines)
        {
            string[] wholeline = line.Split("#");
            string goalType = wholeline[0];
            string name = wholeline[1];
            string description = wholeline[2];
            int points = int.Parse(wholeline[3]);
            _lengthOfGoalsList ++;


            if (goalType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                Console.WriteLine($"Added simpleGoal {name} {description} {points}");
            }
            // else if (goalType == "Eternal Goal")
            // {
            //     EternalGoal eternalGoal = new EternalGoal(name, description, points);
            //     _goals.Add(eternalGoal);
            // }
        }
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
}