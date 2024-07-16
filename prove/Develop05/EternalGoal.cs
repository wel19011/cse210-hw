class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, int numberCompleted, bool status) : base(name, description, points, numberCompleted, status)
    {
        // SetGoal(name);
        // SetPoints(points);
        // SetDescription(description);
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