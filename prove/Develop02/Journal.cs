using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> LoadFromFile(string filename)
    {
        List<Entry> entries = new List<Entry>();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];
                    
                    Entry entry = new Entry(prompt, response, date);
                    entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found: {0}", filename);
        }

        return entries;
    }

    public void SaveToFile(List<Entry> entries, string filename)
    {
        List<string> lines = new List<string>();
        foreach (Entry entry in entries)
        {
            string line = $"{entry.Date.ToShortDateString()}|{entry.Prompt}|{entry.Response}";
            lines.Add(line);
        }
        string fileContents = string.Join(Environment.NewLine, lines);
        File.WriteAllText(filename, fileContents);
        Console.WriteLine("File saved successfully: {0}", filename);
    }
}
