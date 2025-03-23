using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;
    private PromptGenerator _promptGenerator;

    public Journal()
    {
        _entries = new List<Entry>();
        _promptGenerator = new PromptGenerator();
    }

    public void AddNewEntry(string promptText, string entryText)
    {
        string date = DateTime.Now.ToString("dd/MM/yyyy");
        Entry newEntry = new Entry(date, promptText, entryText);
        AddEntry(newEntry);
    }

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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        _entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
            Entry entry = new Entry(date, promptText, entryText);
            _entries.Add(entry);
        }
    }

    public string GetRandomPrompt()
    {
        return _promptGenerator.GetRandomPrompt();
    }
}
