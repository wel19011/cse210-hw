using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Jason Bourne, welcome to the program... \nthat computes the square of your favorite number.");
        // return welcomeMessage;
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int numberSquared = userNumber * userNumber;
        return numberSquared;
    }

    static void DisplayResult(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}.");
        // return display
    }

    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    }
}