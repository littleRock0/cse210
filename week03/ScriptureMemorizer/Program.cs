/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
 * more then three additional classes
 * loaded scriptures from file
 * gets a random scripture
 * random selection only counts those that aren't already hidden
***************************************************************************/
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int i = 0;
        
        GetScripture aScripture = new GetScripture();
        Scripture scripture;
        Reference reference;
        
        (string book, int chapter, int verse, int endVerse, string text) =
            aScripture.GetRandomScripture();
        
        if (endVerse == 0)
        {
            reference = new Reference(book, chapter, verse);
            scripture = new Scripture(reference, text);
        }
        else
        {
            reference = new Reference(book, chapter, verse,
                endVerse);
            scripture = new Scripture(reference, text);
        }
        
        do
        {
            WriteLine("Press Enter to Continue or type quit to end.\n");
            
            if (i == 0)
            {
                WriteLine(scripture.GetDisplayText(false));
            }
            else
            {
                WriteLine(scripture.GetDisplayText(true));
            }
            
            input = ReadLine();
            
            if (scripture.IsCompletelyHidden())
            {
                input = "quit";
                WriteLine(reference.GetDisplayText() +
                    " is completely hidden.");
            }
            
            if (input != "quit")
            {
                input = "";
            }
            
            Clear();
            
            i++;
        } while (input != "quit");
    }
}