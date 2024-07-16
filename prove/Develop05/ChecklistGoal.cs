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
        Console.WriteLine($"[{GetStatus()}] {GetGoal()} {GetDescription()}. {GetPoints()} Completed: {GetNumberCompleted()}/{_timesToCompletion}");
    }
    public override int RecordEvent()
    {
        IncrementNumberCompleted();
        if (GetNumberCompleted() == _timesToCompletion)
        {
            SetStatus(); //need to handle bonus points
        }
        return GetPoints();
    }
    public override string ToString()
    {
        return $"{base.ToString()}#{GetGoal()}#{GetDescription()}#{GetPoints()}#{GetStatus()}#{GetNumberCompleted()}#{_timesToCompletion}#{_bonusPoints}";
    }
}