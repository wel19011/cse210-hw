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
        // Word tempWord = new Word(text);
        // _words.Add(tempWord);
        // _verse = "John 3:16 - For God so loved the world that He gave His only begotten Son. That whosoever believeth in Him should not perish, but have everlasting life";
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
        while (count < 3)
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
}