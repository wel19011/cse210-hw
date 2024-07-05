public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private DateTime _futureTime;


    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    protected int GetDuration()
    {
        return _duration;
    }
    public int DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        DateTime currentTime = DateTime.Now;
        _futureTime = currentTime.AddSeconds(_duration);

        Console.Clear();
        Console.Write("Get Ready.");
        PauseActivity(3);
        Console.WriteLine();

        return _duration;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed a {_duration} second {_activityName} Activity!");
        Thread.Sleep(3000);
    }
    public bool Timer()
    {
        // Functions to time the activity
        // DateTime currentTime = DateTime.Now;
        // DateTime futureTime = currentTime.AddSeconds(_duration);

        // Console.Write("Waiting...");
        // while (DateTime.Now < futureTime)
        // {
        //     Thread.Sleep(1000);
        //     // Console.Write(".");
        //     return false;
        // }
        // Console.WriteLine("Finished!");
        // if (futureTime < currentTime)
        if (DateTime.Now < _futureTime)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void PauseActivity(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(seconds);

        // Console.Write("Waiting...");
        while (DateTime.Now < futureTime)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
    }
    public void Animation()
    {
        // count down
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}
