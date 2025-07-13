/*******************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
*******************************************************************************/
using System;
using System.ComponentModel; // don't know where this came from
using static System.Console;

class Program
{
    static void DisplayWelcome()
    {
        WriteLine("Welcome to the Program!");
    }
    
    static string PromptUserName()
    {
        Write("User name: ");
        
        string name = ReadLine();
        
        return name;
    }
    
    static int PromptUserNumber()
    {
        Write("Enter an Integer: ");
        
        int i = int.Parse(ReadLine());
        
        return i;
    }
    
    static int SquareNumber(int i)
    {
        i *= i;
        
        return i;
    }
    
    static void DisplayResult(string name, int i)
    {
        WriteLine($"{name}, your number squared = {i}");
    }
    
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int yourNumber = PromptUserNumber();
        int square = SquareNumber(yourNumber);
        
        DisplayResult(userName, square);
    }
}