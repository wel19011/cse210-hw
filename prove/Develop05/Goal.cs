abstract class Goal
{
    private string _goal;
    private int _points;
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
    public int GetPoints()
    {
        return _points;
    }
    public string GetGoal()
    {
        return _goal;
    }
}