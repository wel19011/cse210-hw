public class BreathingActivity : Activity
{
    private string _prompt;
    public BreathingActivity(string name, string description, int duration, string endingMessage, string prompt) : base(name, description, duration, endingMessage)
    {
        _prompt = prompt;
    }
}