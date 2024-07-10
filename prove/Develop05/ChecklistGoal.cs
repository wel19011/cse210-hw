class ChecklistGoal : Goal
{
    private int _timesToCompletion;
    private int _bonusPoints;

    public override void DisplayGoal()
    {
        Console.WriteLine($"This is a checklist goal");
    }

}