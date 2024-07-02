using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment hw = new Assignment("Mark Nelson", "Subtraction");
        Console.WriteLine(hw.GetSummary());

        MathAssignment hw2 = new MathAssignment("Amy Wells", "PreCalculus", "pages 23-45", "1-12");
        Console.WriteLine(hw2.GetSummary());
        Console.WriteLine(hw2.GetHomeworkList());

        WritingAssignment hw3 = new WritingAssignment("Jamie Red", "Contemporary Literature", "When the Cows come Home");
        Console.WriteLine(hw3.GetSummary());
        Console.WriteLine(hw3.GetWritingInformation());
    }
}