class Reference
{
    private int _number;
    private string _book;
    private int _chapter;
    private int _verse;
    private string _reference;

    public Reference()
    {

    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public string ParseReference(string verse) // receives the string containing the reference and verse and returns the reference as a formated string
    {
        Words w = new Words();
        string reference = w.GetReference(verse);               // selects the reference from the verse and returns it as a string
        List<string> refList = reference.Split(" ").ToList();   // splits reference on the spaces so Jacob 4:15 goes to [`Jacob`, `4:15`]

        if (refList.Count == 2)                                 // accounts for scriptures that have book numbers. Ie 2 Nephi, 1 Peter, etc.
        {
            _book = refList[0];
            string nums = refList[1];
            List<string> numbers = HandleNumbers(nums);
            _chapter = nums[0];
            _verse = nums[1];
            _reference = $"{_book} {_chapter}:{_verse}";
        }
        else if (refList.Count == 3)
        {
            _number = int.Parse(refList[0]);
            _book = refList[1];
            string nums = refList[1];
            List<string> numbers = HandleNumbers(nums);
            _chapter = nums[0];
            _verse = nums[1];
            _reference = CombineParts(_book, _chapter, _verse, _number);
        }
        return _reference;
    }
    private List<string> HandleNumbers(string combinedNumbers)
    {
        List<string> numbers = combinedNumbers.Split(":").ToList();
        return numbers;
    }
    private string CombineParts(string book, int chapter, int verse, int number = 0)
    {
        if (number == 0)
            _reference = $"{book} {chapter}:{verse}";
        else
            _reference = $"{number} {book} {chapter}:{verse}";
        return _reference;
    }
    public string GetReferenceString()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}