using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Welcome to the Scripture memorization program!");

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

        Reference ref1 = new Reference("1 Nephi", 3,7);
        // Console.WriteLine(ref1.GetReferenceString());
        Console.Write("Input 'q' to quit, 'enter' to continue");
        string input = Console.ReadLine();
        Scripture scripture1 = new Scripture(ref1, "And it came to pass that I Nephi said unto my Father, I will go and do the things that the Lord has commanded.");
        Console.Clear();
        scripture1.DisplayScripture();
        while (input != "q" & !scripture1.AllWordsHidden())
        {
            scripture1.HideSomeWords();
            Console.Clear();
            scripture1.DisplayScripture();
            input = Console.ReadLine();
        }

    }
}