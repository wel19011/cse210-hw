class Goals 
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;


    public int GetTotalPoints()
    {

        return _totalPoints;
    }
    public void SaveGoals()
    {
        // logic to write to a file
    }
    public void LoadGoals()
    {
        // logic to read from a file and load into the goals list
    }
    public void DisplayGoals()
    {
        Console.WriteLine("List of Goals: ");
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