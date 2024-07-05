public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        // _prompt = prompt; // how should I set the prompt? from a list within the parent class?
        //what do i do when it seems like an attribute or method needs to be used in the parent class. GiveInstructions for example
        // How should I set up the if statement in main? there seem to be a lot of lines of code
        //what does the error "could not copy obj" mean?
        // my while loop requires me to input the number twice, it seems that it doesn't know what value is inside of Menu until it is called
    }
    public void GiveInstructions()
    {
        // Console.Clear();
        // Console.Write("Get Ready.");
        // PauseActivity(3);

        int duration = GetDuration();
        int modDuration = duration / 10; // maybe add a try catch block to inform the user that they need a larger number if they choose one less than 10
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