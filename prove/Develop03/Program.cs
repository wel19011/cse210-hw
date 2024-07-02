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
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");


        // string verse = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";


        Console.Clear();

        Console.WriteLine("Welcome to the Scripture memorization program!");
        Console.Write("Input 'q' to quit, 'enter' to continue. ");

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