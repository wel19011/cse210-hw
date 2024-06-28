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

        Word w = new Word("bob");
        if (!w.IsHidden())
        {
            Console.WriteLine(w.GetWord());
        }
        Reference ref1 = new Reference("2 Nephi", 3,7);
        Console.WriteLine(ref1.GetReferenceString());

        Scripture scripture1 = new Scripture(ref1, "Some text");
        Console.WriteLine(scripture1.GetScripture());

    }
}