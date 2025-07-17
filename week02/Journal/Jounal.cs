/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using System.IO;
using static System.Console;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    
    public void SaveToFile(string file)
    {
        
    }
    
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        
        string[] lines = File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            
            string[] elements = line.Split("|");
            
            newEntry._date = elements[0];
            newEntry._promptText = elements[1];
            newEntry._entryText = elements[2];
            
            AddEntry(newEntry);
        }
    }
}