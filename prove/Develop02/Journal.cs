using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        DateTime currentTime = DateTime.Now;
        string date = currentTime.ToShortDateString();
        newEntry._date = date;

        PromptGenerator prompt = new PromptGenerator();
        string promptText = prompt.GetRandomPrompt();
        newEntry._promptText = promptText;
                
        Console.WriteLine(promptText);
        newEntry._entryText = Console.ReadLine();
        
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}||{entry._promptText}||{entry._entryText}");
            }
        }
    }

    public List<Entry> LoadFromFile(string file)
    {
        List<Entry> entries = new List<Entry>();
        
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            entries.Add(newEntry);
        }

        _entries = entries;

        return _entries;
    }
}