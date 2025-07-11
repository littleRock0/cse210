/*******************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
*******************************************************************************/
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Write("Grade (as a percentage not do NOT add ): ");
        string input = ReadLine();
        int grade = int.Parse(input);
        
        string score = grade switch
        {
            grade >= 93 => "A",
            
            grade <= 93 && grade >= 90 => "A-",
                
            grade > 90 && grade >= 87 => "B+",
                
            case int i when grade >= 93 && grade >= 90:
                return
        };
    }
}