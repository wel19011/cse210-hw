abstract class Goal
{
    private string _goal;
    private string _description;
    private int _points;
    private int _numberCompleted;
    private bool _status;

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
    public void IncrementNumberCompleted()
    {
        _numberCompleted ++;
    }
    public int GetNumberCompleted()
    {
        return _numberCompleted;
    }
    public string GetStatus()
    {
        if (_status)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }
    public void SetStatus()
    {
        _status = true;
        Console.WriteLine($"Congrats! you've added {_points} points to your score!");
    }
    public override string ToString()
    {
        return $"{base.ToString()}#{_goal}#{_description}#{_points}#{_status}";
    }
    public abstract int RecordEvent();
    
}
