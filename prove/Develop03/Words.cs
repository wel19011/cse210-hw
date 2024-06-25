class Words
{
    private List<string> _words;
    private List<string> _hiddenWords;
    private List<int> _hiddenWordsIndex;

    public Words()
    {

    }
    public List<string> ParseVerse(string verse)
    {
        _words = verse.Split(" ").ToList();
        return _words;
    }
}