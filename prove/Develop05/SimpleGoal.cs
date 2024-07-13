class SimpleGoal : Goal
{
    public SimpleGoal(string goal, string description, int points)
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
}