public class BreathingActivity : Activity
{
    private string _prompt;
    public BreathingActivity(string name, string description, int duration, string endingMessage, string prompt) : base(name, description, duration, endingMessage)
    {
        _prompt = prompt; // how should I set the prompt? from a list within the parent class?
        //what do i do when it seems like an attribute or method needs to be used in the parent class. GiveInstructions for example
        // How should I set up the if statement in main? there seem to be a lot of lines of code
        //what does the error "could not copy obj" mean?
        // my while loop requires me to input the number twice, it seems that it doesn't know what value is inside of Menu until it is called
    }
    public void GiveInstructions()
    {
        Console.Clear();
        Console.Write("Get Ready.");
        PauseActivity(3);

        int duration = GetDuration();
        int modDuration = duration / 10;
        // bool timesUp = Timer();
        // while (!timesUp)
        for (int i = 0; i < modDuration; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            Animation();
            Console.WriteLine();
            Console.Write("Breathe out...");
            Animation();
            // timesUp = Timer();
        }
    }
}