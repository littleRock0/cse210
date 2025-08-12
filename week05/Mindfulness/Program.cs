/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
 * Showing Creativity:
 *  pulling prompts from a file (a separate one per activity that needs it)
 *  removed GetListFromUser as that is handled by GetRandomPrompt(Question)
 *  made a point to use every type of loop in C# atleased once
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
            "4. Quit\n");
        
        int i = int.Parse(ReadLine());
        
        Clear();
        
        return i;
    }
    
    static bool ListingActivityFunc()
    {
        ListingActivity listing1 = new ListingActivity("Listing Activity",
            "This activity will help you reflect on the good things in " +
            "your life by having you list as many things as you can in " +
            "a certain area.");
        
        return false;
    }
    
    static bool ReflectingActivityFunc()
    {
        ReflectingActivity reflecting1 = new ReflectingActivity(
            "Reflecting Activity", "This activity will help you reflect " +
            "on times in your life when you have shown strength and " +
            "resilience. This will help you recognize the power you have" +
            " and how you can use it in other aspects of your life.");
        
        return false;
    }
    
    static bool BreathingActivityFunc()
    {
        BreathingActivity breathing1 = new BreathingActivity(
            "Breathing Activity", "This activity will help you relax by " +
            "walking your through breathing in and out slowly. Clear your" +
            " mind and focus on your breathing.");
        
        return false;
    }
    
    static void Main(string[] args)
    {       
        bool quit;
        bool invalidSelection = false;
        
        do
        {
            int actNum = Menu();
            
            quit = actNum switch
            {
                1 => ListingActivityFunc(),
                2 => ReflectingActivityFunc(),
                3 => BreathingActivityFunc(),
                4 => true,
                _ => invalidSelection = true,
            };
            
            if (invalidSelection)
            {
                Write("Invalid option\n");
            }
        } while (!quit);
    }
}