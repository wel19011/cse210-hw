using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // Have the user input the number to guess
        // Console.Write("Enter a magic number: ");
        // string response = Console.ReadLine();
        // int magicNumber = int.Parse(response);

        // have the computer randomly select a number in a chosen range
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 20);
        Console.WriteLine("Try to guess the random number between 1 and 20!");

        int guessInt;
        do 
        {
            Console.Write("Make a guess at the number: ");
            string guessString = Console.ReadLine();
            guessInt = int.Parse(guessString);
            // if statement logic
            if (magicNumber == guessInt)
            {
                Console.WriteLine("Well done! You guessed the correct number!");
            }
            else if(magicNumber < guessInt)
            {
                Console.WriteLine("Lower!");
            }
            else if (magicNumber > guessInt)
            {
                Console.WriteLine("Higher!");
            }
        } while(magicNumber != guessInt);
    }
}