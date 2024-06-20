using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program");


        Entry response1 = new Entry();
        response1.FillEntry("How was your day?");
        
        // Entry response2 = new Entry();
        // response2.FillEntry("What interesting thing did you see?");

        Journal myJournal = new Journal();
        myJournal.AddEntry(response1);
        // myJournal.AddEntry(response2);
        myJournal.DisplayJournal();

        Prompt prompt1 = new Prompt();
        prompt1.ChooseQuestion();
    }
}