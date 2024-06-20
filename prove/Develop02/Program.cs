using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program");
        int select = 0;
        do 
        {
            if (select == 1)
            {
                Prompt prompt1 = new Prompt();
                string newQuestion = prompt1.ChooseQuestion();

                Entry response1 = new Entry();
                response1.FillEntry(newQuestion);

                Journal myJournal = new Journal();
                myJournal.AddEntry(response1);
                myJournal.DisplayJournal();
            }
        } while(select != 5);


    }
}