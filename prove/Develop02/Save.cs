using System;


class Save
{
    public void SaveToFile(List<Entry> entries, string filename)
    {
        List<string> lines = new List<string>();
        foreach (Entry entry in entries)
        {
            string line = $"{entry.Prompt},{entry.Response}";
            lines.Add(line);
        }
        string fileContents = string.Join(Environment.NewLine, lines);
        File.WriteAllText(filename, fileContents);
        Console.WriteLine("File saved successfully: {0}", filename);
    }
}