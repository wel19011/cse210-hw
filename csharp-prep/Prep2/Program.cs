using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string value = Console.ReadLine();
        int percentage = int.Parse(value);
        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else if (percentage < 60)
        {
            grade = "F";
        }

        Console.WriteLine($"According to our calculations...");
        if (percentage >= 70)
        {
            Console.WriteLine($"Well done! You passed with a {grade}");
        }
        else
        {
            Console.WriteLine($"Your grade is {grade}. You failed.");
        }
    }
}