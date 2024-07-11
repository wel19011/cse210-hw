class ChecklistGoal : Goal
{
    private int _timesToCompletion;
    private int _bonusPoints;

    public ChecklistGoal(string goal, string description, int points, int timesToCompletion, int bonusPoints)
    {
        SetGoal(goal);
        SetPoints(points);
        SetDescription(description);
        _timesToCompletion = timesToCompletion;
        _bonusPoints = bonusPoints;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{GetGoal()} {GetDescription()}. Points: {GetPoints()} Completed: {GetNumberCompleted()}/{_timesToCompletion}");
    }

}