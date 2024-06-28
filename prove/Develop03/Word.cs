class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public void HideWord()
    {
        _hidden = true;
    }
    public string GetWord()
    {
        return _word;
    }
}