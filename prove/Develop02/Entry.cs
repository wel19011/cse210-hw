using System;
public class Entry
{
    private string _response;
    private string _currentDate;

    public Entry(string response = "") // creating a method of object `Entry` as a method within class `Entry`, aka a constructor
    {                                  // this keeps the data private but allows the user to change the variable for the purposes of the program
        _response = response; 
    }

    public void GetDate()
    {
        // function that does stuff to get the system date 
        // Console.WriteLine(DateTime.Now.ToString("d"));
        _currentDate = DateTime.Now("d");
        return _currentDate;
    }

    public string GetResponse()
    {
        Console.WriteLine("Enter response here: ");
        response = Console.ReadLine();
        return _response;
    }
}