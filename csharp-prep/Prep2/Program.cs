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

        // Identify letter grade from the percentage
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

        // Get the sign associated with the grade
        string sign = "";
        int getSign = percentage / 10;
        if (getSign >= 7)
        {
            sign = "+";
        }
        else if (getSign <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        
        // Display the letter grade and whether or not they failed
        Console.WriteLine($"According to our calculations...");
        if (percentage >= 70)
        {
            Console.WriteLine($"Well done! You passed with a {sign}{grade}");
        }
        else
        {
            Console.WriteLine($"Your grade is {sign}{grade}. You failed.");
        }
    }
}