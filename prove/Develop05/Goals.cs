class Goals 
{
    private List<Goal> _goals;

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
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g);
        }
    }
}