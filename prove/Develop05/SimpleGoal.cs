class SimpleGoal : Goal
{
    public SimpleGoal(string goal, int points)
    {
        SetGoal(goal);
        SetPoints(points);
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetGoal()} -- {GetPoints()} points");
    }
}