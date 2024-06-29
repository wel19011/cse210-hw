using System;

class Program
{
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

        Scripture v1 = new Scripture();
        string myVerse = v1.GetVerse();
        Console.WriteLine(myVerse);

        string verse = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        // Console.Clear();

        Console.WriteLine("Welcome to the Scripture memorization program!");
        Console.Write("Input 'q' to quit, 'enter' to continue");

        Reference ref1 = new Reference("1 Nephi", 3,7);
        Scripture scripture1 = new Scripture(ref1, verse);
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