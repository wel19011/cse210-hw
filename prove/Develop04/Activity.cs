public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private string _endingMessage;

    public Activity(string activityName, string description, int duration, string endingMessage)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
        _endingMessage = endingMessage;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public void Timer()
    {
        // Functions to time the activity
    }
    public void Animation()
    {
        // for loop that iterates through four symbols (/-\|)
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"{i}");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}
