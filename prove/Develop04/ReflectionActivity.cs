public class ReflectionActivity : Activity
{
    // private string _someAttribute;
    private string _prompt;
    private string _question;
    private List<string> _reflectionPrompts;
    private List<string> _reflectionQuestions;
    public ReflectionActivity(string name, string description) : base(name, description)
    {
        _reflectionPrompts = new List<string>();
        _reflectionQuestions = new List<string>();
    }
    public string ChoosePrompt()
    {
        // randomly select a prompt from the list found in parent class
        List<string> prompts = GetReflectionPrompts();
        int listLength = GetReflectionPrompts().Count;
        Random random = new Random();
        int promptIndex = random.Next(listLength);
        _prompt = prompts[promptIndex];
        return _prompt;
    }
    public string ChooseQuestion()
    {
        List<string> questions = GetReflectionQuestions();
        int listLength = GetReflectionQuestions().Count;
        Random random = new Random();
        int questionIndex = random.Next(listLength);
        _question = questions[questionIndex];
        return _question;
    }
    private List<string> GetReflectionPrompts()
    {
        _reflectionPrompts.Add("Think of a time when you stood up for someone else");
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");
        _reflectionPrompts.Add("Think of a favorite vacation.");
        _reflectionPrompts.Add("Think of the beginning of a meaningful friendship you have.");
        return _reflectionPrompts;
    }
    private List<string> GetReflectionQuestions()
    {
        _reflectionQuestions.Add("Why was this experience meaningful to you?");
        _reflectionQuestions.Add("Have you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different from other times not as meaningful?");
        _reflectionQuestions.Add("What was your favorite thing about this experience?");
        return _reflectionQuestions;
    }
}