class SimpleGoal : Goal
{
    public SimpleGoal(string goal, string description, int points, bool status = false) //: base(goal, description, points,status)
    {
        SetGoal(goal);
        SetPoints(points);
        SetDescription(description);
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