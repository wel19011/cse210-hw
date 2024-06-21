using System;
public class Entry
{
    private string _response;
    private string _currentDate;
    private string _prompt;

    public Entry() // creating a method of object `Entry` as a method within class `Entry`, aka a constructor
    {              // this keeps the data private but allows the user to change the variable for the purposes of the program
        _response = ""; 
        _currentDate = "";
        _prompt = "";
    }

    public Entry(string date, string prompt, string response)
    {
        _response = response;
        _currentDate = date;
        _prompt = prompt;
    }

    public string GetDate()
    {
        DateTime currentDate = DateTime.Now;
        return currentDate.ToShortDateString();
    }

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