abstract class Goal
{
    private string _goal;
    private string _description;
    private int _points;
    private int _numberCompleted { get; set; }
    private bool _status;

    public Goal(string name, string description, int points, int numberCompleted = 0, bool status = false)
    {
        _goal = name;
        _description = description;
        _points = points;
        _numberCompleted = numberCompleted;
        _status = status;
    }
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
    public void SetPoints()
    {
        Console.Write("Enter the number of points for this goal: ");
        _points = int.Parse(Console.ReadLine());
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
    public void SetNumberCompleted(int number)
    {
        _numberCompleted = number;
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
    public void InitializeStatus()
    {
        _status = false;
    }
    public override string ToString()
    {
        // entered in this order: 0-type # 1-goalname # 2-description # 3-points # 4-status # 5-numberCompleted
        return $"{base.ToString()}#{_goal}#{_description}#{_points}#{_numberCompleted}#{_status}";
    }
    public abstract int RecordEvent();
    
}
