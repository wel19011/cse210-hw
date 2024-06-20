using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program");

        Entry response1 = new Entry();
        response1._currentDate = GetDate();
        response1._response = GetResponse();
        

        // Journal entry1 = new Journal();
        // CompileEntry()

    }
}