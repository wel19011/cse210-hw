public class BreathingActivity : Activity
{
    private string _prompt;
    public BreathingActivity(string name, string description, int duration, string endingMessage, string prompt) : base(name, description, duration, endingMessage)
    {
        _prompt = prompt; // how should I set the prompt? from a list within the parent class?
        //what do i do when it seems like an attribute or method needs to be used in the parent class. GiveInstructions for example
    }
        public void GiveInstructions()
    {
        Console.Clear();
        Console.Write("Get Ready.");
        PauseActivity(3);

        int duration = GetDuration();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            Animation();
            Console.WriteLine();
            Console.Write("Breathe out...");
            Animation();
        }
    }
}