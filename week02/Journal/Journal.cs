using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Creativity Upgrade: Display entries sorted by date
    public void DisplayJournalSorted()
    {
        _entries.Sort((x, y) => DateTime.Parse(x.Date).CompareTo(DateTime.Parse(y.Date)));
        Console.WriteLine("Journal entries sorted by date:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save journal in CSV format
    public void SaveToCsv(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }
    }

    // Load journal from CSV format
    public void LoadFromCsv(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _entries.Add(Entry.FromCsv(line));
        }
    }
}
