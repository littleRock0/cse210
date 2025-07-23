/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string verse = "Jesus wept.";
        string input;
        
        Reference reference = new Reference("John", 11, 35);
        Scripture scripture = new Scripture(reference, verse);
        
        do
        {
            WriteLine(scripture.GetDisplayText());
            
            input = ReadLine();
            
            if (scripture.IsCompletelyHidden())
            {
                input = "quit";
            }
            
            if (input != "quit")
            {
                input = "";
            }
            
            Clear();
        } while (input != "quit");
    }
}