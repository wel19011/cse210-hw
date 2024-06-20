using System;
public class Journal
{
    private List<Entry>_entries = new List<Entry>();
    
    public List CompileEntry(string currentDate, string entry)
    {
        _entries.Add(currentDate);
        _entries.Add(entry);
        return _entries;
    }
}