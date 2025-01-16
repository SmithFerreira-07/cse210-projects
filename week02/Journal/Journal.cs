using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {

        foreach (var entry in _entries)
        {
            entry.Display();
            
        }
    }

    public void SaveToFile(string file)
    {
        //string fileName = "JournalEntry.txt";
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}");
                writer.WriteLine($"{entry._promptText}");
                writer.WriteLine($"{entry._entryText}");
            }
        }
        Console.WriteLine("Journal Saved");
    }

    public void LoadFromFile(string file)
    {
        if (!System.IO.File.Exists(file))
        {
            Console.WriteLine("Journal File not found.");
            return;
        }
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string [] parts = line.Split("-");
            Entry myEntry = new Entry();
            myEntry._date = parts[0];
            myEntry._promptText = parts[1];
            myEntry._entryText = parts[2];
            _entries.Add(myEntry);
        }

        Console.WriteLine("Journal Loaded!");
        
    }
}