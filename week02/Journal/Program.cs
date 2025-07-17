/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class Program
{
    static int Menu()
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
        
        return num;
    }
    static void Main(string[] args)
    {
        int selection = Menu();

        WriteLine(selection);
    }
}