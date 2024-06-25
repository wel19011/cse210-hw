class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _reference;

    private string GrabReference(string verse)
    {
        // call the parse and grab the first word in the string
        Words w = new Words();
        List<string> _words = w.ParseVerse(verse);
        _reference = _words[0];
        return _reference;
    }
}