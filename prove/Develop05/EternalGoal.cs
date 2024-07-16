class EternalGoal : Goal
{
    public EternalGoal(string goal, string description, int points)
    {
        SetGoal(goal);
        SetPoints(points);
        SetDescription(description);
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[NA] {GetGoal()} {GetDescription()} {GetPoints()} ");
    }
    public override int RecordEvent()
    {
        IncrementNumberCompleted();
        Console.WriteLine("Well done!");
        return GetPoints();
    }
}