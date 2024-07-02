class Scripture
{
    private string _verse;
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference r, string text)
    {
        _reference = r;
        _words = new List<Word>();
        FillList(text);
    }
    public string GetVerse()
    {
        return _verse;
    }
    private string GetScripture()
    {
        return $"{_reference.GetReferenceString()} {_words[0].GetWord()}";
    }
    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.GetReferenceString()} ");
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                Console.Write($"{w.GetWord()} ");
            }
            else if (w.IsHidden())
            {
                for (int i = 0; i < w.GetWordLength(); i++)
                {
                    Console.Write("_");
                }
                Console.Write(" ");
            }
        }
    }
    private void FillList(string text2)
    {
        // _verse = text;
        string[] wordsTemp = text2.Split(" ");
        foreach (string w in wordsTemp)
        {
            Word tempWord = new Word(w);
            _words.Add(tempWord);
        }
    }
    public void HideSomeWords()
    {
        int count = 0;
        while (count < 3 && !AllWordsHidden())
        // for (int i = 0; i < 3; i++)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, _words.Count());
            if (!_words[randomNumber].IsHidden())
            {
                _words[randomNumber].HideWord();
                count++;
            }
        }
    }
    public bool AllWordsHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // private string [] ReadScripturesFile()
    // {
    //     string [] lines = System.IO.File.ReadAllLines("scriptures.txt");
    //     return lines;
    // }
    // private string ChooseRandomScripture()
    // {
    //     string [] lines = ReadScripturesFile();
    //     int countScriptures = 0;
    //     foreach (string i in lines)
    //     {
    //         countScriptures ++;
    //     }
    //     Random randomScripture = new Random();
    //     int choiceIndex = randomScripture.Next(countScriptures);
    //     string verse = lines[choiceIndex];
    //     return verse;
    // }
    // public string GetReference(string verse)
    // {
    //     List<string> wholeVerse = verse.Split("--").ToList();
    //     string reference = wholeVerse[0];
    //     return reference;
    // }
    // public string GetWordsFromVerse()
    // {
    //     List<string> wholeVerse = _verse.Split("--").ToList();
    //     string wordsFromVerse = wholeVerse[1];
    //     return wordsFromVerse;
    // }
}