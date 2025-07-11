/*******************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
 * used switch instead of cascading if's because it is far more efficient and
 *      and makes for far neater code
*******************************************************************************/
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Write("Grade (as a percentage not do NOT add %): ");
        
        string input = ReadLine();
        int grade = int.Parse(input);
        
        string score = grade switch
        {
            >= 93 => "A",
            >= 90 => "A-",
            >= 87 => "B+",
            >= 83 => "B",
            >= 80 => "B-",
            >= 77 => "C+",
            >= 73 => "C",
            >= 70 => "C-",
            >= 67 => "D+",
            >= 63 => "D",
            >= 60 => "D-",
            < 60 => "F",
        };
        
        Write($"Your score is: {score}");
    }
}