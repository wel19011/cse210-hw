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
    public int DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }
    public void Timer()
    {
        // Functions to time the activity
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);

            Console.Write("Waiting...");
        while (DateTime.Now < futureTime)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine("Finished!");
        // if (futureTime < currentTime)
    }
    public void Animation()
    {
        // counts down from 8
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(750);
            Console.Write("\b \b");
        }
    }
}
