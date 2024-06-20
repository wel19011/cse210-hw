using System;

public class Prompt
{
    private string _question;
    private List<string> _questions = new (){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "what was the strongest emotion I felt today?",
        "If I had one thing I could redo today, what would it be?",
        "What story do I want my children to read?",
        "What did I learn or what understanding did I gain?"
    };

    public Prompt()
    {
        string newQuestion = _question;
    }
    public string ChooseQuestion()
    {
        Random rd = new Random();
        int questionIndex = rd.Next(_questions.Count);
        _question = _questions[questionIndex];
        Console.WriteLine($"{questionIndex}{_question}");
        return _question;
    }    
}