using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Eternal Quest World!");

        Menu m = new Menu();
        
        int response = 0;
        while (response != 6)
        {
            response = m.DisplayMainMenu();
        }

    }
}  