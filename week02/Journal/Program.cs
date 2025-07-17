/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
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
                PromptGenerator prompt = new PromptGenerator();
                Entry newEntry = new Entry();
                
                newEntry._promptText = prompt.GetRandomPrompt();
                
                WriteLine(newEntry._promptText);
                
                newEntry._entryText = ReadLine();
                
                DateTime today = DateTime.Now.Date;
                
                newEntry._date = today.ToString("MM/dd/yyyy");
                
                journal1.AddEntry(newEntry);
            }
            else if (selectName == "Display")
            {
                journal1.DisplayAll();
            }
            else if (selectName == "Load")
            {
                Write("File Name: ");
                
                string input = ReadLine();
                
                journal1.LoadFromFile(input);
            }
            else if (selectName == "Save")
            {
                Write("File Name: ");
                
                string input = ReadLine();
                
                journal1.SaveToFile(input);
            }
            else if (selectName == "Quit")
            {
                WriteLine("See you tomorrow!");
            }
        } while (selectNum != 5 && selectName != "Quit");
    }
}