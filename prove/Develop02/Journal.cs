using System;
public class Journal
{
    private List<Entry>_entries = new List<Entry>();
    
    // public List<Entry> CompileEntry(string currentDate, string entry)
    // {
    //     Entry newEntry = new Entry(entry, currentDate, "How was your day?");
    //     _entries.Add(newEntry);
    //     return _entries;
    // }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayJournal()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }
}