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
    public string GetGoal()
    {
        return _goal;
    }
}