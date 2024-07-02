using System;

class Program
{
    private static string [] ReadScripturesFile()
    {
        string [] lines = System.IO.File.ReadAllLines("scriptures.txt");
        return lines;
    }
    private static string ChooseRandomScripture()
    {
        string [] lines = ReadScripturesFile();
        int countScriptures = 0;
        foreach (string i in lines)
        {
            countScriptures ++;
        }
        Random randomScripture = new Random();
        int choiceIndex = randomScripture.Next(countScriptures);
        string verse = lines[choiceIndex];
        return verse;
    }
    public static Scripture GetFileBasedScripture(string verse)
    {
        List<string> wholeVerse = verse.Split("#").ToList();
        string name = wholeVerse[0];
        int chapter = int.Parse(wholeVerse[1]);
        int v = int.Parse(wholeVerse[2]);
        if (wholeVerse[3].Length == 1 || wholeVerse[3].Length == 2)
        {
            int lv = int.Parse(wholeVerse[3]);
            Reference reference2 = new Reference(name, chapter, v, lv);
            Scripture s2 = new Scripture(reference2, wholeVerse[4]);
            return s2;
        }
        else
        {
            Reference reference = new Reference(name, chapter, v);
            Scripture s = new Scripture(reference, wholeVerse[3]);
            return s;
        }
    }
    // public string GetWordsFromVerse()
    // {
    //     List<string> wholeVerse = _verse.Split("--").ToList();
    //     string wordsFromVerse = wholeVerse[1];
    //     return wordsFromVerse;
    // }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        // Scripture s = new Scripture();
        // string verse = s.GetVerse();
        // Console.WriteLine($"verse: {verse}");

        // Reference myRef = new Reference();
        // // string scriptRef = myRef.GrabReference(verse);
        // // Console.WriteLine($"{scriptRef}");~

        // Words try1 = new Words();
        // List<string> words = try1.ParseVerse(verse);
        // foreach (string word in words)
        // {
        //     Console.WriteLine($"{word}");
        // }

        // Word w = new Word("bob");
        // w.HideWord();
        // if (!w.IsHidden())
        // {
        //     Console.WriteLine(w.GetWord());
        // }
        // else if (w.IsHidden())
        // {
        //     // int wordLength = w.GetWord().Count(char.IsLetter); // I consulted ChatGPT for the char.IsLetter method
            
        //     for (int i = 0; i < w.GetWordLength(); i++)
        //     {
        //         Console.Write("_ ");
        //     }
        //     Console.WriteLine("");
        // }

        // Scripture v1 = new Scripture();
        // string myVerse = v1.GetVerse();
        // Console.WriteLine(myVerse);

        string verse = " came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        
        // Scripture v2 = new Scripture();
        // string verse = v2.GetVerse();
        // v2.GetReference(verse);


        Console.Clear();

        Console.WriteLine("Welcome to the Scripture memorization program!");
        Console.Write("Input 'q' to quit, 'enter' to continue");

        // Reference ref1 = new Reference("1 Nephi", 3,7);
        // Scripture scripture1 = new Scripture(ref1, verse);
        string randomVerse = ChooseRandomScripture();
        Scripture scripture1 = GetFileBasedScripture(randomVerse);
        scripture1.DisplayScripture();
        string input = Console.ReadLine();

        while (input != "q" & !scripture1.AllWordsHidden())
        {
            scripture1.HideSomeWords();
            Console.Clear();
            scripture1.DisplayScripture();
            input = Console.ReadLine();
        }

    }
}