using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello SB World!");
        Console.WriteLine("This is a test of working with C# syntax");
        Console.WriteLine("The following are examples the syntax");

        int x = 10;
        double y = 10.5624;
        string a = "bob";

        Console.WriteLine($"My integer: {x}, my double: {y}, the string: {a}");

        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine(j);
        }

        
        // Practicing with while loops
        // int userAge = 0;
        // while (userAge <= 0 || userAge > 120)
        // {
        //     Console.WriteLine("Please input your age");
        //     userAge = int.Parse(Console.ReadLine());
        // }
        // int userAge2 = 2082490;
        // do // do while loops guarentee that the loop will execute at least once, it requires no entrance strategy
        // {
        //     Console.WriteLine("Please input your age again");
        //     userAge2 = int.Parse(Console.ReadLine());
        // } while (userAge2 < 0 || userAge2 > 120);

        // for (int i = 10234; i < 100000; i += 1000)
        // {
        //     Console.WriteLine("" + i);
        // }

        // Practice with Lists
        List<int> myList = new List<int>();
        List<string> myNames = new List<string>();

        myNames.Add("billy");
        myNames.Add("Bob");
        myNames.Add("Betty");

        myList.Add(12);
        myList.Add(13);
        myList.Add(15);
        myList.Add(44);
        myList.Add(35);

        foreach (string name in myNames)
        {
            Console.WriteLine("" + name);
        }

        // Functions in C# 
        static double CalculateCircleArea(double radius)
        {
            double area = 0;
            area = Math.PI * radius * radius;
            return area;
        }

        double area = CalculateCircleArea(10);
        Console.WriteLine("the area of the circle is" + area);
    }
}