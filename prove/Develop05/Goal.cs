abstract class Goal
{
    private string _goal;
    private string _description;
    private int _points;
    private int _numberCompleted;
    private bool _goalIsCompleted;

    public abstract void DisplayGoal();
    public void SetGoal(string newGoal)
    {
        _goal = newGoal;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetGoal()
    {
        return _goal;
    }
    public int GetNumberCompleted()
    {
        return _numberCompleted;
    }
}