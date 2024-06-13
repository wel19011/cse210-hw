using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, one by one, as prompted.");
        int number ;
        List<int> numbers = new List<int>();
        do
        {
            string response = Console.ReadLine();
            number = int.Parse(response);
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }while(number != 0);

        int sumTotal = 0;
        int n = 0;
        int max =0;
        foreach (int i in numbers)
        {
            sumTotal += i;
            n += 1;
            if (i > max)
            {
                max = i;
            }
        }

        // Calculate average
        int average = sumTotal / n;

        Console.WriteLine(numbers);
        Console.WriteLine($"sumTotal: {sumTotal}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum: {max}");

    }
}