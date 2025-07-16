/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        
    }
    
    public void DisplayAll()
    {
        
    }
    
    public void SaveToFile(string file)
    {
        
    }
    
    public void LoadFromFile(string file)
    {
        
    }
}