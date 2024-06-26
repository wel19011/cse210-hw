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
    public string GetReference(string verse)
    {
        _words = verse.Split("-").ToList();
        string reference = _words[0];
        return reference;
    }
    private List<string> ParseReferenceOnSpace(string reference)
    {
        List<string> refList = reference.Split(" ").ToList();
        // foreach (string part in refList) //under construction...
        // {
        //     if (int.Parse(refList[0]) = true)
        // }
        return refList;
    }
}