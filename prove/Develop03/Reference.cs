class Reference
{
    private int _number;
    private string _book;
    private int _chapter;
    private int _verse;
    private int _lastVerse;
    private string _reference;

    public Reference(string reference)
    {
        _reference = reference;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = firstVerse;
        _lastVerse = lastVerse;
    }
    public string GetReferenceString()
    {
        if (_lastVerse > 0)
        {
        return $"{_book} {_chapter}:{_verse}-{_lastVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
    // private List<int> HandleNumbers(string combinedNumbers)
    // {
    //     List<string> numbers = combinedNumbers.Split(":").ToList();
    //     List<int> numbersInt = new List<int>();
    //     foreach (string number in numbers)
    //     {
    //         int numberInt = int.Parse(number);
    //         numbersInt.Add(numberInt);
    //     }
    //     return numbersInt;
    // }
    // private string CombineParts(string book, int chapter, int verse, int number = 0)
    // {
    //     if (number == 0)
    //         _reference = $"{book} {chapter}:{verse}";
    //     else
    //         _reference = $"{number} {book} {chapter}:{verse}";
    //     return _reference;
    // }
    // public void ParseReference() // receives the string containing the reference and verse and returns the reference as a formated string
    // {
    //     // string reference = GetReference(verse);               // selects the reference from the verse and returns it as a string
    //     List<string> refList = _reference.Split(" ").ToList();   // splits reference on the spaces so Jacob 4:15 goes to [`Jacob`, `4:15`]

    //     if (refList.Count == 2)                                 // accounts for scriptures that have book numbers. Ie 2 Nephi, 1 Peter, etc.
    //     {
    //         _book = refList[0];
    //         string nums = refList[1];
    //         List<int> numbers = HandleNumbers(nums);
    //         _chapter = numbers[0];
    //         _verse = numbers[1];
    //         _reference = $"{_book} {_chapter}:{_verse}";
    //     }
    //     else if (refList.Count == 3)
    //     {
    //         _number = int.Parse(refList[0]);
    //         _book = refList[1];
    //         string nums = refList[1];
    //         List<int> numbers = HandleNumbers(nums);
    //         _chapter = numbers[0];
    //         _verse = numbers[1];
    //         // _reference = CombineParts(_book, _chapter, _verse, _number);
    //     }
    //     // return _reference;
    // }
}