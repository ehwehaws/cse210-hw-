using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(string response, string prompt)
    {
        Entry entry = new Entry();
        entry._prompt = prompt;
        entry._response = response;
        entry._date = DateTime.Now.ToShortDateString();
        _entries.Add(entry);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    






}
