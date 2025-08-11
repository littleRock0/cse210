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
        Write("Please select one of the folowing:\n" +
            "1. Listing Activity\n" +
            "2. Reflecting Activity\n" +
            "3. Breathing Activity\n" +
            "2. Quit\n");
        
        int i = int.Parse(ReadLine());
        
        Clear();
        
        return i;
    }

    static Tuple<string, int> ListingActivityFunc()
    {
        
    }
    
    static void Main(string[] args)
    {
        Activity activity1 = new Activity("", "", 0);
        
        int actNum = Menu();
        
        switch (actNum)
        {
            1: ListingActivityFunc();
            2: ReflectingActivityFunc();
            3: BreathingActivityFunc();
            4: return;
            default: WriteLine("Not a valid option");
        }
    }
}