using System;
public class Entry
{
    private string _response;
    private string _currentDate;
    private string _prompt;

    public Entry() // creating a method of object `Entry` as a method within class `Entry`, aka a constructor
    {                                  // this keeps the data private but allows the user to change the variable for the purposes of the program
        _response = ""; 
        _currentDate = "";
        _prompt = "";
    }

    public Entry(string response, string date, string prompt)
    {
        _response = response;
        _currentDate = date;
        _prompt = prompt;
    }


    public string GetDate()
    {
        // function that does stuff to get the system date 
        // Console.WriteLine(DateTime.Now.ToString("d"));
        DateTime currentDate = DateTime.Now;
        return currentDate.ToShortDateString();
    }

    // public string GetResponse()
    // {
    //     Console.WriteLine("Enter response here: ");
    //     _response = Console.ReadLine();
    //     return _response;
    // }

    public void FillEntry(string prompt)
    {
        _currentDate = GetDate();
        _prompt = prompt;
        Console.WriteLine(prompt);
        _response = Console.ReadLine();
    }
    public override string ToString()
    {
        return $"{_currentDate}#{_prompt}#{_response}";
    }
}