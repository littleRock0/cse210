/*******************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
*******************************************************************************/
using System;
using static System.Console;

class Program
{
    const int RANGE_END = 101;
    
    static void Main(string[] args)
    {
        Random number = new Random();
        int myNumber = number.Next(1, RANGE_END);
        
        WriteLine("Welcome to \"Guess My Number\"\n");
        WriteLine($"I have a number between 1 and {RANGE_END - 1}.");
        
        int guess;
        
        do 
        {
            Write("Your Guess (whole number): ");
            
            guess = int.Parse(ReadLine());
            
            if (guess == myNumber)
            {
                WriteLine($"Correct my number is: {myNumber}\n");
            }
            else if (guess > myNumber)
            {
                WriteLine($"Sorry {guess} is too large, guess again.\n");
            }
            else if (guess < myNumber)
            {
                WriteLine($"Sorry {guess} is too small guess again.\n");
            }
        } while (guess != myNumber);
    }
}