using System.Security.Cryptography;

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
    // public List<int> ChooseRandomWords(List<string> words)
    // {
    //     int range = words.Count();
    //     for (int i = 0; i < 3; i++) // I'm trying to randomly select three numbers out of a list of however many words there are in the list, storing them iteratively into a list or array that will then be used to compare to the indeces of the list of words from the verse
    //     {
    //         RandomNumberGenerator j = new RandomNumberGenerator();

    //         int number1 = 
    //     }
    //     return _hiddenWords;
    // }
}