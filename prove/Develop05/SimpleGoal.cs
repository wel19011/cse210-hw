class SimpleGoal : Goal
{
    public SimpleGoal(string goal, string description, int points, int numberCompleted, bool status = false) : base(goal, description, points, numberCompleted, status)
    {
        // SetGoal(goal);
        // SetPoints(points);
        // SetDescription(description);
    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        SetNumberCompleted(0);
        InitializeStatus();
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{GetStatus()}] {GetGoal()} {GetDescription()} {GetPoints()}");
        // ToString();
    }
    public override int RecordEvent()
    {
        SetStatus();
        return GetPoints();
    }
}