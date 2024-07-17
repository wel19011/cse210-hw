class ChecklistGoal : Goal
{
    private int _timesToCompletion;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int numberCompleted, bool status, int timesToCompletion, int bonusPoints) 
    : base(name, description, points, numberCompleted, status)
    {
        // SetGoal(name);
        // SetPoints(points);
        // SetDescription(description);
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
        return $"ChecklistGoal#{GetGoal()}#{GetDescription()}#{GetPoints()}#{GetNumberCompleted()}#{GetStatusFlag()}#{_timesToCompletion}#{_bonusPoints}";
        // return $"{base.ToString()}#{GetGoal()}#{GetDescription()}#{GetPoints()}#{GetStatus()}#{GetNumberCompleted()}#{_timesToCompletion}#{_bonusPoints}";
    }
}