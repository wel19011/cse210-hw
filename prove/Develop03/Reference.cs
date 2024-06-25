class Reference
{
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
    private string GrabReference(string verse)
    {
        // call the parse and grab the first word in the string
        Words w = new Words();
        List<string> _words = w.ParseVerse(verse);
        _book = _words[0];
        _chapter = int.Parse(_words[1]);
        _verse = int.Parse(_words[2]);
        _reference = CombineParts(_book, _chapter, _verse);
        return _reference;
    }
    private string CombineParts(string book, int chapter, int verse)
    {
        _reference = $"{book} {chapter} {verse}";
        return _reference;
    }
}