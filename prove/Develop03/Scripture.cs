class Scripture
{
    private string _verse;
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference r, string text)
    {
        _reference = r;
        _words = new List<Word>();
        Word tempWord = new Word(text);
        _words.Add(tempWord);
        // _verse = "John 3:16 - For God so loved the world that He gave His only begotten Son. That whosoever believeth in Him should not perish, but have everlasting life";
    }
    public string GetVerse()
    {
        return _verse;
    }
    public string GetScripture()
    {
        return $"{_reference.GetReferenceString()} {_words[0].GetWord()}";
    }
}