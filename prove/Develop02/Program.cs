using System;

class Program
{
    static void Main()
    {
        // Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program");
        int select = 0;
        Journal myJournal = new Journal();
        do 
        {
            Console.WriteLine("Please Select one of the following options: ");
            Console.WriteLine("1. Write. \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("> ");
            select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Prompt prompt1 = new Prompt();
                string newQuestion = prompt1.ChooseQuestion();

                Entry response1 = new Entry(); // instantiate the Entry data type
                response1.FillEntry(newQuestion); // call the FillEntry method which takes a prompt question as a parameter; sets values equal to _currentDate, _prompt, and _response

                myJournal.AddEntry(response1);
                
            }
            else if(select == 2)
            {
                // Display the entries
                myJournal.DisplayJournal();
            }
            else if(select == 3)
            {
                // load the journal
                Console.WriteLine("Enter the journal file name: ");
                string filename = Console.ReadLine();
                myJournal.ReadFromFile(filename);
            }
            else if(select == 4)
            {
                // save the entries to the file
                Console.WriteLine("Enter the journal file name: ");
                string filename = Console.ReadLine();
                myJournal.WriteToFile(filename);
            }
            else if(select == 5)
            {
                break;
            }

        } while(select != 5);



        Console.WriteLine("Thank you for writing in your journal today! ");
        Console.WriteLine("Don't forget to be true to yourself and to God everyday!");
    }
}