using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
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
    //savespotincasedoesntwork
    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                sw.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }


    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entries.Add(entry);
        }
    }






}
