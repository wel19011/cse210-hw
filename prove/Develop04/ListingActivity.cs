public class ListingActivity : Activity
{
    private string _prompt;
    private List<string> _listingPrompts;
    public ListingActivity(string name, string description) : base(name, description)
    {
        _listingPrompts = new List<string>();
        _prompt = ChoosePrompt();
    }
    public void DisplayListing()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"----- {_prompt} -----");
        PauseActivity(6);
        // Console.Write("Press Enter when you are ready to begin:");
        // Console.Read();
        int responses = 0;

        while (!Timer())
        {
            Console.Write(">");
            string response = Console.ReadLine();
            responses ++;
        }
        Console.WriteLine($"\nWay to go! You listed {responses} responses in {GetDuration()} seconds!");
    }
    public string ChoosePrompt()
    {
        int listLength = GetListingPrompts().Count();
        Random random = new Random();
        int promptIndex = random.Next(listLength);
        _prompt = _listingPrompts[promptIndex];
        return _prompt;
    }
    private List<string> GetListingPrompts()
    {
        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this week?");
        _listingPrompts.Add("Who are some of your personal heroes?");
        _listingPrompts.Add("What have you been able to accomplish today?");
        return _listingPrompts;
    }
}