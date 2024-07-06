public class ListingActivity : Activity
{
    private string _prompt;
    private List<string> _listingPrompts;
    public ListingActivity(string name, string description) : base(name, description)
    {
        _listingPrompts = new List<string>();
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