/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
 *
 * Showing Creativity/Exceeding expectations
 *   I put the menu in a separate function
 *   also I put the implementation of each menu item in a separate function
 *      and used a switch statement to call each function
 *   I have 15 prompts instead of the required 5
***************************************************************************/
using System;
using static System.Console;

class Program
{
    static (string, int) Menu()
    {
        List<string> options = new List<string>
        { "Write", "Display", "Load", "Save", "Quit" };
        int i = 0;
        
        WriteLine("Select one:");
        
        foreach (string option in options)
        {
            ++i;
            
            WriteLine($"{i}. {option}");
        }
        
        Write("Selection: ");
        
        int num = int.Parse(ReadLine());
        
        return (options[--num], num);
    }
    
    static string JWrite(Journal journal1)
    {
        PromptGenerator prompt = new PromptGenerator();
        Entry newEntry = new Entry();
        
        newEntry._promptText = prompt.GetRandomPrompt();
        
        WriteLine(newEntry._promptText);
        
        newEntry._entryText = ReadLine();
        
        DateTime today = DateTime.Now.Date;
        
        newEntry._date = today.ToString("MM/dd/yyyy");
        
        journal1.AddEntry(newEntry);
        
        return "";
    }
    
    static string JDisplay(Journal journal1)
    {
        journal1.DisplayAll();
        
        return "";
    }
    
    static string Load(Journal journal1)
    {
        Write("File Name: ");
        
        string input = ReadLine();
        
        journal1.LoadFromFile(input);
        
        return "";
    }
    
    static string Save(Journal journal1)
    {
        Write("File Name: ");
        
        string input = ReadLine();
        
        journal1.SaveToFile(input);
        
        return "";
    }
    
    static string Quit(Journal journal1)
    {
        WriteLine("See you tomorrow!");
        
        return "";
    }
    
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        
        string selectName;
        int selectNum;
        
        do
        {
            (selectName, selectNum) = Menu();
            
            if (selectName == "Write")
            {
                JWrite(journal1);
            }
            else if (selectName == "Display")
            {
                JDisplay(journal1);
            }
            else if (selectName == "Load")
            {
                Load(journal1);
            }
            else if (selectName == "Save")
            {
                Save(journal1);
            }
            else if (selectName == "Quit")
            {
                Quit(journal1);
            }
        } while (selectNum != 5 && selectName != "Quit");
    }
}