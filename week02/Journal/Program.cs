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
        
        Console.Write("Selection: ");
        
        int num = int.Parse(ReadLine());
        
        return (options[--num], num);
    }
    
    static void Main(string[] args)
    {
        string selectName;
        int selectNum;
        
        do
        {
            (selectName, selectNum) = Menu();
            
            Journal journal1 = new Journal();
            
            
            if (selectName == "Write")
            {
                
            }
            else if (selectName == "Display")
            {
                
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